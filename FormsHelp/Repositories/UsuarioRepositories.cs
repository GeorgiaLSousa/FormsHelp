using Microsoft.AspNetCore.Mvc;
using FormsHelp.Models;
using FormsHelp.Data;
using System.Linq;
using System;

namespace FormsHelp.Repositories
{
    public class UsuarioRepositories
    {

        private readonly AppDbContext _context;

        public UsuarioRepositories(AppDbContext context)
        {
            _context = context;
        }

        public void SalvarUsuario(Usuario usuario)
        {
            var usuarioExistente = _context.Usuarios.FirstOrDefault(u => u.Email == usuario.Email);
            var cpfExistente = _context.Usuarios.FirstOrDefault(u => u.CPF == usuario.CPF);
            
             if (cpfExistente != null)
            {
                throw new Exception("Já existe um usuário com este CPF.");
            }
            if (usuarioExistente != null)
            {
                throw new Exception("Já existe um usuário com este email.");
            }
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public Usuario login(string email, string senha)
        {

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
            {
                throw new Exception("Email ou senha inválidos.");
            }

            // 2. Transforma o e-mail digitado em minúsculo e remove espaços
            string emailLimpo = email.Trim().ToLower();
            string senhaLimpa = senha.Trim();

            // 3. Faz a busca no banco ignorando maiúsculas/minúsculas no e-mail
            var usuario = _context.Usuarios
                .FirstOrDefault(u => u.Email.ToLower() == emailLimpo && u.Senha == senhaLimpa);

            if (usuario == null)
            {
                throw new Exception("Email ou senha inválidos.");
            }

            return usuario;
        }
    }
}
