# CRUD Products

Uma API REST desenvolvida em **C# / .NET** com persistência em **PostgreSQL**, projetada seguindo boas práticas de arquitetura em camadas, tratamento global de erros padronizado e containerização com Docker.

---

## Tecnologias e Ferramentas

- **Linguagem / Runtime:** C# | .NET
- **Framework Web:** ASP.NET Core
- **ORM / Acesso a Dados:** Entity Framework Core (EF Core) + Npgsql
- **Banco de Dados:** PostgreSQL 17
- **Tratamento de Exceções:** `IExceptionHandler` seguind os padrões do RFC 7807.
- **Containerização:** Docker & Docker Compose

---

## Estrutura e Arquitetura

O projeto adota uma estrutura em camadas limpa e desacoplada:

- **`Controller/`**: Exposição dos endpoints REST e roteamento HTTP.
- **`Service/`**: Regras de negócio e validações da aplicação.
- **`Data/`**: Configuração do contexto do banco de dados (`DbContext`) e mapeamento relacional.
- **`Entity/`**: Modelos de domínio mapeados para as tabelas do PostgreSQL.
- **`DTO/`**: Objetos de transferência de dados e contratos de entrada/saída da API.
- **`Exception/`**: Middleware e interceptador global de erros.

---

## 📌 Endpoints da API

| Método | Endpoint | Descrição | Status de Sucesso |
| :--- | :--- | :--- | :--- |
| `POST` | `/products` | Cria um novo produto | `201 Created` |
| `GET` | `/products` | Lista todos os produtos cadastrados | `200 OK` |
| `GET` | `/products/{id}` | Busca um produto por ID | `200 OK` |
| `PATCH`| `/products/{id}` | Atualização parcial de dados do produto | `200 OK` |
| `DELETE`| `/products/{id}` | Remove um produto por ID | `204 No Content` |
