# 🎫 HelpDesk Pro System

Sistema de Help Desk desenvolvido em C# Windows Forms com SQLite para gerenciamento de chamados de suporte técnico.

---

## 📋 Sobre o Projeto

O HelpDesk Pro System foi criado para organizar chamados de suporte dentro de uma empresa.

O sistema permite que usuários abram chamados e acompanhem o andamento do atendimento, enquanto analistas conseguem visualizar e gerenciar todas as solicitações.

O projeto foi desenvolvido utilizando Windows Forms, SQLite e arquitetura em camadas.

---

## 🎯 Objetivos do Projeto

- Aplicar conceitos de Programação Orientada a Objetos
- Utilizar banco de dados SQLite
- Implementar operações CRUD
- Trabalhar arquitetura em camadas
- Desenvolver interface gráfica em Windows Forms

---

## 👥 Integrantes do Grupo

| RA | Nome |
|----|------|
| 2225103962 | Rafael Silva De Almeida |
| 2226107005 | Georgia Ligia Ribeiro de Sousa |
| 2225106837 | Guilherme Vasconcelos de Souza |
| 2225104475 | Lucas da Cruz |
| 2225103186 | Ronald Ribeiro |
| 2225204468 | Elizabete Fatima Chauca Condori |
| 2225204439 | Vinicius Bueno da Silva |

---

## 📸 Screenshots

### 🔐 Tela de Login

<img width="1144" height="653" alt="image" src="https://github.com/user-attachments/assets/10702745-a7e5-41a4-b481-109c4fb12690" />


### 👤 Tela de Novo Usuário

<img width="1167" height="656" alt="image" src="https://github.com/user-attachments/assets/cbab026a-b317-4379-a2c7-0f3fce60cdb0" />


### 🎫 Dashboard Cliente
<img width="1002" height="556" alt="image" src="https://github.com/user-attachments/assets/de690332-4905-4f56-97a3-6fff4497cf9c" />

### 🛠️ Dashboard Analista

<img width="990" height="558" alt="image" src="https://github.com/user-attachments/assets/c064f607-392b-40c1-9b03-38cdf8f08683" />

### ➕ Tela de Novo Chamado

<img width="1166" height="653" alt="image" src="https://github.com/user-attachments/assets/f95d16f5-1522-442e-a242-ae6998f08858" />


### 🔍 Detalhes do Chamado - Analista

<img width="996" height="557" alt="image" src="https://github.com/user-attachments/assets/216bbb5d-1d03-42d2-abc3-5bf7cd6fbdcb" />


### 👨‍💼 Detalhes do Chamado - Usuário

<img width="947" height="534" alt="image" src="https://github.com/user-attachments/assets/48e0e94c-c97f-43a1-b031-bd19f8c0fe92" />


### ✏️ Atualizar Chamado

<img width="957" height="534" alt="image" src="https://github.com/user-attachments/assets/568ce5c5-1595-4d4c-ad1c-34a7a9119c3d" />


---

## 🚀 Funcionalidades

### 👤 Cliente

- Realizar login
- Cadastrar novo usuário
- Abrir chamados
- Acompanhar chamados
- Filtrar chamados por status

### 🛠️ Analista

- Visualizar chamados
- Filtrar chamados
- Atualizar informações do chamado
- Alterar status do atendimento

---

## 🖥️ Telas do Sistema

- Login
- Novo Usuário
- Dashboard Cliente
- Dashboard Analista
- Novo Chamado
- Detalhes do Chamado
- Atualizar Chamado

---

## 🛠️ Tecnologias Utilizadas

- C#
- .NET
- Windows Forms
- SQLite
- Entity Framework Core
- Visual Studio 2022
- Git
- GitHub

---

## 🗄️ Banco de Dados

O sistema utiliza SQLite como banco de dados local.

### Entidade Usuário

| Campo | Tipo |
|---------|---------|
| Id | Integer |
| Nome | Text |
| CPF | Text |
| Email | Text |
| Senha | Text |
| Perfil | Integer |

### Entidade Chamado

| Campo | Tipo |
|---------|---------|
| Id | Integer |
| Titulo | Text |
| Descricao | Text |
| Categoria | Text |
| Prioridade | Text |
| Status | Text |
| DataAbertura | DateTime |

---

## 🎨 Interface

Características da interface:

- Layout moderno
- Interface inspirada em sistemas corporativos
- Componentes reutilizáveis
- Navegação simples

---

## 🚀 Como Executar

### Pré-requisitos

- Visual Studio 2022
- .NET 8 ou superior

### Clonar o Projeto

bash
https://github.com/GeorgiaLSousa/FormsHelpDesk.git


### Executar

text
1. Abra a solução no Visual Studio
2. Restaure os pacotes NuGet
3. Execute o projeto (F5)
