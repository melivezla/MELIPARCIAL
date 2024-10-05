using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MELIPARCIAL.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ConversionHistoriales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MontoOriginal = table.Column<decimal>(type: "numeric", nullable: false),
                    MonedaOriginal = table.Column<string>(type: "text", nullable: false),
                    MontoConvertido = table.Column<decimal>(type: "numeric", nullable: false),
                    MonedaConvertida = table.Column<string>(type: "text", nullable: false),
                    TasaCambio = table.Column<decimal>(type: "numeric", nullable: false),
                    FechaConversion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConversionHistoriales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Remesas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NombreRemitente = table.Column<string>(type: "text", nullable: false),
                    NombreDestinatario = table.Column<string>(type: "text", nullable: false),
                    PaisOrigen = table.Column<string>(type: "text", nullable: false),
                    PaisDestino = table.Column<string>(type: "text", nullable: false),
                    MontoEnviado = table.Column<decimal>(type: "numeric", nullable: false),
                    Moneda = table.Column<string>(type: "text", nullable: false),
                    TasaCambio = table.Column<decimal>(type: "numeric", nullable: false),
                    MontoFinal = table.Column<decimal>(type: "numeric", nullable: false),
                    EstadoTransaccion = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Remesas", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConversionHistoriales");

            migrationBuilder.DropTable(
                name: "Remesas");
        }
    }
}
