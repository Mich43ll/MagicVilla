using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AlimentarTablaVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaActualizacion", "FechaCreacion", "ImagenUlr", "Nombre", "Ocupantes", "Tarifa", "metrosCuadrados" },
                values: new object[,]
                {
                    { 1, "", "Detalle de la villa...", new DateTime(2023, 6, 16, 17, 37, 41, 74, DateTimeKind.Local).AddTicks(5333), new DateTime(2023, 6, 16, 17, 37, 41, 74, DateTimeKind.Local).AddTicks(5319), "", "Villa Real", 5, 200.0, 50 },
                    { 2, "", "Detalle de la villa...", new DateTime(2023, 6, 16, 17, 37, 41, 74, DateTimeKind.Local).AddTicks(5336), new DateTime(2023, 6, 16, 17, 37, 41, 74, DateTimeKind.Local).AddTicks(5336), "", "Premium Vista a la piscina", 5, 150.0, 40 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
