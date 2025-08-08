📦 API de Armazém – Gerenciamento de Produtos
Esta API foi desenvolvida com o objetivo de oferecer um serviço completo de CRUD de produtos para um sistema de armazém. Com ela, é possível cadastrar, consultar, atualizar e excluir produtos, mantendo o controle eficiente do estoque.

A API foi construída com foco em clareza, padronização e boas práticas, utilizando as tecnologias modernas do ecossistema .NET.

## 🚀 Tecnologias Utilizadas

- [.NET 9](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
- [Entity Framework Core](https://learn.microsoft.com/ef/core/)
- [SQL Server](https://www.microsoft.com/pt-br/sql-server/)
- [Scalar](https://scalar.com/) – documentação interativa da API
- Padrões de **respostas HTTP** estruturadas (200, 201, 400, 404, 500)

🔧 Funcionalidades principais
POST /produtos – Cadastro de um novo produto no armazém

GET /produtos – Listagem completa dos produtos

GET /produtos/{id} – Consulta detalhada de um produto por ID

PUT /produtos/{id} – Atualização das informações de um produto

DELETE /produtos/{id} – Exclusão de um produto do sistema

📄 Documentação Interativa
A documentação interativa da API está disponível via Scalar. Após rodar o projeto, acesse:

## ▶️ Como Executar o Projeto

1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/sua-api-armazem.git

2. Acesse a pasta do projeto:
   ```bash
   cd seu-repositorio

3. Configure a connection string no appsettings.json
   ```bash
   "DefaultConnection": "server= localhost\\SQLEXPRESS; database= WebApiLivraria; trusted_connection=true; trustservercertificate=true;"

4. Aplique as migrations:
   ```bash
   dotnet ef database update

5. Execute o projeto:
   ```bash
   dotnet run

6. Acesse a documentação Swagger:
   ```bash
   [https://localhost:{porta}/swagger](https://localhost:{porta}/scalar/v1)
