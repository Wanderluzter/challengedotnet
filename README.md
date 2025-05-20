# 🏍️ challengedotnet

Repositório do projeto desenvolvido para a disciplina **Java Advanced** do Challenge FIAP/Mottu 2025.

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

   ```bash
   git clone https://github.com/Wanderluzter/challengedotnet.git
   
2.Acesse a pasta do projeto:

   ```bash
   git clone https://github.com/Wanderluzter/challengedotnet.git

3.Execute o projeto

   ```bash
   git clone https://github.com/Wanderluzter/challengedotnet.git

4. Acesse a API em:

- http://localhost:5000


- http://localhost:5000

📌 Endpoints principais
🛵 Motos
- GET /motos – Listar todas as motos

- GET /motos/{id} – Buscar moto por ID

- POST /motos – Criar nova moto

- PUT /motos/{id} – Atualizar moto existente

- DELETE /motos/{id} – Deletar moto

📡 Tags
- GET /tags – Listar todas as tags

- GET /tags/{id} – Buscar tag por ID

- POST /tags – Criar nova tag

- PUT /tags/{id} – Atualizar tag existente

- DELETE /tags/{id} – Deletar tag

📚 Tecnologias utilizadas
.NET 8

- C# com Minimal APIs

- Entity Framework Core

- Swagger (para documentação e testes)



