using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SIB.Migrations
{
    public partial class Migration6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SIB_CTc",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoTarjeta = table.Column<int>(type: "int", nullable: false),
                    Banco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LimiteCredito = table.Column<int>(type: "int", nullable: false),
                    FechaCorte = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaPago = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SIB_CTc", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SIB_PagoPrestamo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoPrestamo = table.Column<int>(type: "int", nullable: false),
                    Saldo = table.Column<int>(type: "int", nullable: false),
                    FechaLimitedePago = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PagoContado = table.Column<int>(type: "int", nullable: false),
                    PagoMinimo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SIB_PagoPrestamo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SIB_PagoTC",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoTarjeta = table.Column<int>(type: "int", nullable: false),
                    Saldo = table.Column<int>(type: "int", nullable: false),
                    FechaLimitedePago = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PagoContado = table.Column<int>(type: "int", nullable: false),
                    PagoMinimo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SIB_PagoTC", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SIB_Servicios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoDeServicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdServicio = table.Column<int>(type: "int", nullable: false),
                    Saldo = table.Column<int>(type: "int", nullable: false),
                    FechaPago = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SIB_Servicios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SIB_Transferencias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoCuenta = table.Column<int>(type: "int", nullable: false),
                    TipoCuenta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Banco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoTransferencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaTransferencia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Monto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SIB_Transferencias", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SIB_CTc");

            migrationBuilder.DropTable(
                name: "SIB_PagoPrestamo");

            migrationBuilder.DropTable(
                name: "SIB_PagoTC");

            migrationBuilder.DropTable(
                name: "SIB_Servicios");

            migrationBuilder.DropTable(
                name: "SIB_Transferencias");
        }
    }
}
