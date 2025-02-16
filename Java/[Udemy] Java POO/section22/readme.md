## Seção 22: Bônus: Projeto Web Services com Spring Boot e JPA / Hibernate

Nesta seção, será criado um projeto completo de Web Services. O projeto inclui a construção de uma API RESTful, integração com banco de dados e boas práticas de desenvolvimento.
O projeto será salvo no repositório de projetos [jrd-dev0/Projects](https://github.com/jrd-dev0/Projects/tree/main/Java/Public/WebServices-SpringBoot-JPA-Hibernate).

### Tecnologias Utilizadas e Tópicos Apresentados

1. **Spring Boot**
    - Criação do Projeto
    - Estruturação de camadas lógicas: resource, service, repository
    - Configuração de banco de dados de teste (H2)
    - Povoar o banco de dados
    - Criação de APIs RESTful
    - Boas práticas de desenvolvimento

2. **JPA (Java Persistence API)**
    - Mapeamento de entidades e tabelas
    - Associações (muitos-para-muitos, um-para-um)
    - Repository, Injeção de Dependência, Database Seeding
    - Métodos CRUD (Create, Retrieve, Update, Delete)

3. **Hibernate**
    - Integração com JPA para persistência de dados
    - Configuração do Hibernate como provedor JPA
    - Implementação de funcionalidades como lazy loading e cache

4. **H2 Database**
    - Configuração e uso de banco de dados em memória
    - Criação de perfis de teste
    - Teste e verificação de integração com a aplicação

5. **Heroku**
    - Implantação de aplicações na nuvem
    - Criação e provisionamento de bancos de dados PostgreSQL
    - Configuração e deploy do projeto

6. **PostgreSQL**
    - Configuração e instalação local
    - Integração com Heroku
    - Exportação e importação de scripts SQL
    - Criação e gerenciamento de bancos de dados

7. **Maven**
    - Gerenciamento de dependências do projeto
    - Configuração do projeto Spring Boot
    - Execução de scripts e comandos de build

8. **Apache Tomcat**
    - Configuração do container web para executar a aplicação
    - Integração com Spring Boot para servir as APIs RESTful
    - Gerenciamento de requisições e respostas HTTP

9. **Postman**
    - Testes das requisições da API
    - Configuração de coleções de testes
    - Verificação e validação de endpoints
    - Automação de testes para garantir a qualidade e funcionamento da API

### Resumo dos Tópicos Apresentados:

- **Criação e Configuração do Projeto:** Uso do Spring Initializr, configuração de dependências e estruturação das camadas lógicas do projeto.
- **Modelagem de Domínio:** Implementação de entidades, mapeamento JPA, e criação de associações entre entidades.
- **Banco de Dados:** Configuração de H2 para testes e PostgreSQL para produção, incluindo a integração com Heroku.
- **CRUD e Serviços:** Criação de métodos CRUD, camada de serviço, e configuração de injeção de dependência.
- **Tratamento de Exceções:** Implementação de classes de exceções, tratamento de erros em diferentes operações (findById, delete, update).
- **Implantação e Deploy:** Criação e configuração de aplicação no Heroku, deploy da aplicação e testes em produção.
- **Execução da Aplicação:** Configuração e utilização do Apache Tomcat para executar a aplicação.
- **Testes:** Utilização do Postman para testar as requisições da API, configurar coleções de testes e automação de testes.