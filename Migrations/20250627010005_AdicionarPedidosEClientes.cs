using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LanchoneteApp.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarPedidosEClientes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Telefone = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Endereco = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Descricao = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    Preco = table.Column<decimal>(type: "TEXT", precision: 10, scale: 2, nullable: false),
                    Categoria = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Disponivel = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ClienteId = table.Column<int>(type: "INTEGER", nullable: false),
                    DataPedido = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false),
                    ValorTotal = table.Column<decimal>(type: "TEXT", precision: 10, scale: 2, nullable: false),
                    Observacoes = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pedidos_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PedidoItens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PedidoId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProdutoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantidade = table.Column<int>(type: "INTEGER", nullable: false),
                    PrecoUnitario = table.Column<decimal>(type: "TEXT", precision: 10, scale: 2, nullable: false),
                    Observacoes = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidoItens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PedidoItens_Pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidoItens_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "DataCadastro", "Email", "Endereco", "Nome", "Telefone" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 6, 26, 22, 0, 5, 256, DateTimeKind.Local).AddTicks(9757), "joao@email.com", "Rua A, 123", "João Silva", "(11) 99999-1111" },
                    { 2, new DateTime(2025, 6, 26, 22, 0, 5, 256, DateTimeKind.Local).AddTicks(9760), "maria@email.com", "Rua B, 456", "Maria Santos", "(11) 88888-2222" }
                });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Categoria", "Descricao", "Disponivel", "Nome", "Preco" },
                values: new object[,]
                {
                    { 1, "Lanches", "Hambúrguer com queijo e salada", true, "X-Burger", 15.90m },
                    { 2, "Bebidas", "Refrigerante 350ml", true, "Coca-Cola", 5.50m },
                    { 3, "Acompanhamentos", "Porção média de batata frita", true, "Batata Frita", 12.00m },
                    { 4, "Lanches", "Hambúrguer com alface, tomate e queijo", true, "X-Salada", 18.50m },
                    { 5, "Bebidas", "Suco natural de laranja 300ml", true, "Suco Natural", 7.00m },
                    { 6, "Sobremesas", "Sorvete de chocolate com cobertura", true, "Sorvete", 8.90m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PedidoItens_PedidoId",
                table: "PedidoItens",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoItens_ProdutoId",
                table: "PedidoItens",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_ClienteId",
                table: "Pedidos",
                column: "ClienteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PedidoItens");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
