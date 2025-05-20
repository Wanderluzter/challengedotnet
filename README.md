# 🏍️ challengedotnet

Repositório do projeto desenvolvido para a disciplina **Advanced Business Development with .Net** do Challenge FIAP/Mottu 2025.

Apesar do nome da disciplina, o projeto foi desenvolvido com **.NET 8 (Minimal API)**, utilizando C#. Ele simula um sistema backend de rastreamento de motos em tempo real, com CRUD completo, paginação e relacionamento entre entidades.

Cada moto está associada a uma **Tag BLE (Bluetooth Low Energy)** que envia dados para a API, permitindo o monitoramento em tempo real.

> ⚠️ Este é um protótipo acadêmico, criado para fins de aprendizado.

---

## 👥 Grupo

- **Leonardo Botelho** – RM: 556110  
- **Raul Clauson** – RM: 555006  
- **Mirian Bronzati** – RM: 555041

---

## 🚀 Como executar o projeto

### ✅ Pré-requisitos

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)
- IDE (Visual Studio, VS Code ou Rider)

### ▶️ Passos para rodar

1. Clone o repositório:
   ```
   git clone https://github.com/wanderluzter/challengedotnet.git

2. Acesse a página do projeto.
   ```
   cd challengedotnet
3. Compile e rode a aplicação
   ```
   dotnet run
4. Acesse a API em:
- http://localhost:5000


📌 Endpoints principais

🔗 Documentação Scalar
Acesse a documentação completa aqui:
https://sprint1dotnet.apidocumentation.com/reference

🛵 Motos
- GET /motos – Listar todas as motos

- GET /motos/{id} – Buscar moto por ID

- POST /motos – Criar nova moto

- PUT /motos/{id} – Atualizar moto existente

- DELETE /motos/{id} – Deletar moto

📚 Tecnologias utilizadas
.NET 8

- C# com Minimal APIs

- Entity Framework Core

- Swagger (para documentação e testes)



