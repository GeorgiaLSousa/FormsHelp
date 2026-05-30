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

<p align="center">
  <img src="docs/login.png" width="900">
</p>

### 👤 Tela de Novo Usuário

<p align="center">
  <img src="docs/novo-usuario.png" width="900">
</p>

### 🎫 Dashboard Cliente

<p align="center">
  <img src="docs/dashboard-cliente.png" width="900">
</p>

### 🛠️ Dashboard Analista

<p align="center">
  <img src="docs/dashboard-analista.png" width="900">
</p>

### ➕ Tela de Novo Chamado

<p align="center">
  <img src="docs/novo-chamado.png" width="900">
</p>

### 🔍 Detalhes do Chamado - Analista

<p align="center">
  <img src="docs/detalhes-analista.png" width="900">
</p>

### 👨‍💼 Detalhes do Chamado - Usuário

<p align="center">
  <img src="docs/detalhes-usuario.png" width="900">
</p>

### ✏️ Atualizar Chamado

<p align="center">
  <img src="docs/atualizar-chamado.png" width="900">
</p>

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
