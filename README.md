# 🍔 Lanchonete App - Sistema de Gerenciamento

Sistema completo de gerenciamento para lanchonetes desenvolvido em ASP.NET Core MVC com Entity Framework Core e SQLite.

## 🚀 Funcionalidades

### 📋 Gerenciamento de Produtos
- ✅ Cadastro, edição e exclusão de produtos
- ✅ Categorização (Lanches, Bebidas, Acompanhamentos, Sobremesas)
- ✅ Controle de disponibilidade
- ✅ Validação de preços e dados

### 🎨 Interface
- ✅ Design responsivo com Bootstrap 5
- ✅ Cardápio público para clientes
- ✅ Interface administrativa intuitiva
- ✅ Tema de lanchonete com emojis

## 🛠️ Tecnologias Utilizadas

- **ASP.NET Core 8.0** - Framework web
- **Entity Framework Core** - ORM para banco de dados
- **SQLite** - Banco de dados local
- **Bootstrap 5** - Framework CSS responsivo
- **HTML5/CSS3** - Interface frontend
- **C#** - Linguagem de programação

## 📁 Estrutura do Projeto

```
LanchoneteApp/
├── Models/
│   ├── Cliente.cs          # Modelo de cliente
│   ├── Produto.cs          # Modelo de produto
│   ├── Pedido.cs           # Modelo de pedido
│   ├── PedidoItem.cs       # Itens do pedido
│   └── LanchoneteContext.cs # Contexto do banco
├── Controllers/
│   ├── HomeController.cs      # Cardápio público
│   ├── ProdutosController.cs  # CRUD produtos
│   ├── ClientesController.cs  # CRUD clientes
│   ├── PedidosController.cs   # Gerenciamento pedidos
│   └── RelatoriosController.cs # Dashboard e relatórios
├── Views/
│   ├── Shared/
│   │   └── _Layout.cshtml     # Layout principal
│   ├── Home/
│   │   └── Index.cshtml       # Cardápio público
│   └── [Controllers]/         # Views específicas
├── Program.cs                 # Configuração da aplicação
├── LanchoneteApp.csproj      # Arquivo do projeto
└── appsettings.json          # Configurações
```

## ⚙️ Configuração e Instalação

### Pré-requisitos
- .NET 8.0 SDK
- Visual Studio 2022 ou VS Code
- Git (opcional)

### Passos para Instalação

1. **Clone ou baixe o projeto:**
```bash
git clone [url-do-repositorio]
cd LanchoneteApp
```

2. **Restaure os pacotes NuGet:**
```bash
dotnet restore
```

3. **Execute a aplicação:**
```bash
dotnet run
```

4. **Acesse no navegador:**
```
https://localhost:5001
```

## 📦 Pacotes NuGet Utilizados

```xml
<PackageReference Include="Microsoft.EntityFrameworkCore.Sqlite" Version="8.0.0" />
<PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="8.0.0" />
<PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="8.0.0" />
```

## 🗄️ Banco de Dados

O sistema utiliza SQLite como banco de dados local. O arquivo `lanchonete.db` será criado automaticamente na primeira execução.

### Dados Iniciais (Seeds)
O sistema inclui dados iniciais para facilitar os testes:

**Produtos:**
- X-Burger (R$ 15,90)
- Coca-Cola (R$ 5,50)
- Batata Frita (R$ 12,00)
- X-Salada (R$ 18,50)
- Suco Natural (R$ 7,00)
- Sorvete (R$ 8,90)

**Clientes:**
- João Silva
- Maria Santos

## 🔧 Funcionalidades Técnicas

### Validações Implementadas
- Campos obrigatórios
- Validação de email
- Faixas de preço (R$ 0,01 - R$ 999,99)
- Quantidade de itens (1-100)

### Relacionamentos do Banco
- Cliente → Pedidos (1:N)
- Pedido → PedidoItens (1:N)
- Produto → PedidoItens (1:N)

### Recursos Avançados
- Busca de clientes
- Filtros por período nos relatórios
- Cálculo automático de subtotais
- Status de pedidos em tempo real

## 🚀 Próximas Melhorias

- [ ] Sistema de autenticação
- [ ] Integração com WhatsApp
- [ ] Impressão de pedidos
- [ ] Controle de estoque
- [ ] Relatórios em PDF
- [ ] Sistema de delivery com mapa

## 📞 Contato

Para dúvidas ou sugestões sobre o projeto, entre em contato através dos issues do repositório.
