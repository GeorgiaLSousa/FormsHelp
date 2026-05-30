using Microsoft.AspNetCore.Mvc;
using FormsHelp.Models;
using FormsHelp.Data;
using FormsHelp.Repositories;
using FormsHelp.Sessao;


namespace FormsHelp.Services
{

    public class ChamadoService
    {
        private readonly ChamadoRepositories chamadoRespositories;

        public ChamadoService(ChamadoRepositories chamadoRespositories)
        {
            this.chamadoRespositories = chamadoRespositories;
        }

        public void CriarChamado(Chamado chamado)
        {
            if (SessaoUsuario.UsuarioLogado == null)
            {
                throw new Exception("Usuário não está logado.");
            }

            chamado.Solicitante = SessaoUsuario.UsuarioLogado;
            chamado.Status = 0;

            chamadoRespositories.SalvarChamado(chamado);
        }

        public List<Chamado> ListarChamadosAbertos()
        {
            return chamadoRespositories.chamadoAberto();
        }

        public List<Chamado> ListarChamadosAnalista()
        {
            if (SessaoUsuario.UsuarioLogado == null)
            {
                throw new Exception("Usuário não está logado.");
            }

            return chamadoRespositories.chamadoAnalista(SessaoUsuario.UsuarioLogado);
        }   

        public List<Chamado> ListaChamadoUsuario()
        {
            if (SessaoUsuario.UsuarioLogado == null)
            {
                throw new Exception("Usuário não está logado.");
            }
            return chamadoRespositories.chamadoUsuario(SessaoUsuario.UsuarioLogado);
        }

        public List<Chamado> TodosChamados()
        {

            if (SessaoUsuario.UsuarioLogado == null)
            {
                throw new Exception("Usuário não está logado.");
            }
            return chamadoRespositories.todosChamados(SessaoUsuario.UsuarioLogado);
        }

        public void AtualizarChamado(Chamado chamadoModificado)
        {
            if (SessaoUsuario.UsuarioLogado == null)
            {
                throw new Exception("Usuário não está logado.");
            }

            if (chamadoModificado == null)
            {
                throw new Exception("Dados do chamado inválidos.");
            }

            // 1. Busca o chamado original como está hoje no banco (rastreado pelo EF)
            var chamadoOriginal = chamadoRespositories.DetalhesChamado(chamadoModificado.Id);

            if (chamadoOriginal == null)
            {
                throw new Exception("Chamado não encontrado para atualização.");
            }

            // 2. Verifica e atualiza APENAS se houve modificação na tela
            if (chamadoOriginal.Status != chamadoModificado.Status)
            {
                chamadoOriginal.Status = chamadoModificado.Status;
            }

            if (chamadoOriginal.Prioridade != chamadoModificado.Prioridade)
            {
                chamadoOriginal.Prioridade = chamadoModificado.Prioridade;
            }

            // Se você tiver campos de texto editáveis (como solução ou descrição), pode aplicar a mesma lógica:
            // if (chamadoOriginal.Descricao != chamadoModificado.Descricao) { chamadoOriginal.Descricao = chamadoModificado.Descricao; }

            // 3. Define a data de atualização e o analista responsável atual
            chamadoOriginal.DataAtualizacao = DateTime.Now;
            chamadoOriginal.Analista = SessaoUsuario.UsuarioLogado;

            // 4. Salva o objeto original (que agora está com as modificações aplicadas)
            chamadoRespositories.AtualizarChamado(chamadoOriginal);
        }

        public Chamado DetalhesChamado(long id)
        {
            if(id <= 0)
            {
                throw new Exception("ID de chamado inválido.");
            }
            return chamadoRespositories.DetalhesChamado(id);
        }

        public Chamado AtenderChamado(long id)
        {
            if (SessaoUsuario.UsuarioLogado == null)
            {
                throw new Exception("Usuário não está logado.");
            }
            if(id <= 0)
            {
                throw new Exception("ID de chamado inválido.");
            }
            return chamadoRespositories.atenderChamado(id, SessaoUsuario.UsuarioLogado);
        }

        public void ExcluirChamado(long id)
        {
            // 1. Busca o chamado completo direto do repositório
            var chamado = chamadoRespositories.DetalhesChamado(id);

            if (chamado == null)
            {
                throw new Exception("Chamado não encontrado no sistema.");
            }

            // 2. REGRA DE NEGÓCIO: Só permite excluir se o status for estritamente "Aberto" e sem analista
            if (chamado.Status != StatusChamado.Aberto || chamado.Analista != null)
            {
                throw new Exception("Não é possível excluir este chamado porque ele já foi assumido por um analista.");
            }

            // 3. Executa a deleção chamando o seu repositório de dados
            chamadoRespositories.DeletarChamado(chamado);
        }
    }
}
