using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace ARJOU_V001.Migrations.Pedido
{
    public partial class Mig00 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PedidoSet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstiloDeseado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ColorDeseado = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LongitudDeseada = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DescripcionAdicional = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ImagenReferencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrecioEstimado = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FechaSolicitud = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfirmadoPorUsuario = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidoSet", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PedidoSet");
        }
    }
}
