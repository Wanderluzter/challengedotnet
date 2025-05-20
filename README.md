# challengejava

# challengedotnet

Repositório do projeto desenvolvido para a disciplina **Java Advanced** do Challenge FIAP/Mottu 2025.

O projeto consiste em uma API REST desenvolvida com **.NET 8 (Minimal API)**, implementando um CRUD completo com relacionamento entre entidades, paginação e outras funcionalidades comuns em aplicações modernas baseadas em C#.

Este protótipo simula um sistema backend de rastreamento de motos em tempo real, utilizando tags com sensores conectadas às motos. Cada tag armazena e transmite informações sobre a moto associada, que podem ser acessadas através da API.

> ⚠️ Este é apenas um protótipo para fins acadêmicos, demonstrando como seria a estrutura de um sistema backend de apoio ao rastreamento de veículos.

## 👥 Grupo

- **Leonardo Botelho** – RM: 556110  
- **Raul Clauson** – RM: 555006  
- **Mirian Bronzati** – RM: 555041

---

## 🚀 Como executar o projeto

### ✅ Pré-requisitos

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)
- IDE (Visual Studio, VSCode ou Rider)

### ▶️ Passos para rodar:

1. Clone o repositório:


> ⚠️ Este é apenas um protótipo para fins acadêmicos, demonstrando como seria a estrutura de um sistema backend de apoio ao rastreamento de veículos.

## Grupo

- **Leonardo Botelho** – RM: 556110  
- **Raul Clauson** – RM: 555006  
- **Mirian Bronzati** – RM: 555041


---

## 🚀 Como executar o projeto

### ✅ Pré-requisitos

- Java 17+
- Maven 3.8+
- IDE (IntelliJ, VSCode, Eclipse etc.)

### ▶️ Passos para rodar:

1. Clone o repositório:
   ```
   git clone https://github.com/wanderluzter/challengedotnet.git

2. Acesse a página do projeto.
   ```
   cd challengedotnet
3. Compile e rode a aplicação
   ```
   dotnet run
4. Acesse a aplicação
- API: http://localhost:5000 ou http://localhost:8080

---

## 📌 Endpoints principais

### Entidade 1 - Motos
- `GET /motos` – Listar todos as motos
- `GET /motos/{id}` – Buscar moto por ID
- `POST /motos` – Criar nova moto
- `PUT /motos/{id}` – Atualizar moto existente
- `DELETE /motos/{id}` – Deletar moto

### Entidade 2 - Tags
- `GET /tags` – Listar todas as tags
- `GET /tags/{id}` – Buscar tag por ID
- `POST /tags` – Criar nova tag
- `PUT /tags/{id}` – Atualizar tag existente
- `DELETE /tags/{id}` – Deletar tag
