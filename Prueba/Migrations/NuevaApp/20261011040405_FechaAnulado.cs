using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prueba.Migrations.NuevaApp
{
    /// <inheritdoc />
    public partial class FechaAnulado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FechaAnulado",
                table: "Referencias_PE",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaAnulado",
                table: "PagosNotaDebito",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaAnulado",
                table: "PagosNomina",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaAnulado",
                table: "PagoFactura",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaAnulado",
                table: "PagoAnticipo",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaAnulado",
                table: "OrdenPago",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaAnulado",
                table: "Referencias_PE");

            migrationBuilder.DropColumn(
                name: "FechaAnulado",
                table: "PagosNotaDebito");

            migrationBuilder.DropColumn(
                name: "FechaAnulado",
                table: "PagosNomina");

            migrationBuilder.DropColumn(
                name: "FechaAnulado",
                table: "PagoFactura");

            migrationBuilder.DropColumn(
                name: "FechaAnulado",
                table: "PagoAnticipo");

            migrationBuilder.DropColumn(
                name: "FechaAnulado",
                table: "OrdenPago");
        }
    }
}
