## **Sistema de Vendas em C# ASP.NET Core MVC e Entity Framework**

Este é um sistema de vendas desenvolvido em C# com o framework ASP.NET Core MVC e Entity Framework, que permite o gerenciamento de produtos, clientes, vendas e pedidos.

#### Funcionalidades

O sistema de vendas tem as seguintes funcionalidades:

Gerenciamento de Setores: permite adicionar, editar e excluir setores, além de listar todos os setores.

Gerenciamento de Vendedores: permite adicionar, editar e excluir vendedores, além de listar todos os vendedores.

Gerenciamento de Produtos: permite adicionar, editar e excluir produtos, além de listar todos os produtos disponíveis por setor.

Gerenciamento de Vendas: permite adicionar vendas e listar todas as vendas realizadas e filtrar por vendedor ou por setor. Além disso, o sistema permite visualizar os detalhes de uma venda específica, incluindo a lista de produtos vendidos e o valor total da venda.

Gerenciamento de Pedidos: permite adicionar pedidos e listar todos os pedidos realizados. Além disso, o sistema permite visualizar os detalhes de um pedido específico, incluindo a lista de produtos pedidos e o valor total do pedido.

**O sistema de vendas utiliza expressões lambda e Linq para filtrar e ordenar os dados dos clientes, produtos, vendas e pedidos.**

#### Requisitos

Para executar o sistema de vendas, é necessário ter os seguintes requisitos instalados:

.NET Core 5 SDK ou posterior

##### Para executar o sistema de vendas, siga os seguintes passos:

- Faça o download do repositório ou clone o repositório usando o comando git clone:
git clone https://github.com/Andershowrj/Sistema_de_vendas_MVC.git

- Abra o prompt de comando ou terminal e navegue até o diretório onde o repositório foi clonado.

- Execute o comando dotnet restore para restaurar as dependências do projeto.

- Execute o comando dotnet ef database update para criar o banco de dados com as tabelas necessárias.

- Execute o comando dotnet run para executar o sistema de vendas.

- Abra um navegador e acesse o endereço http://localhost:7101 para acessar o sistema de vendas.

### Conclusão

Este é um sistema de vendas simples, mas completo, desenvolvido em C# com o framework ASP.NET Core MVC e Entity Framework. Ele pode ser facilmente personalizado e expandido para atender às necessidades específicas de uma empresa ou organização.