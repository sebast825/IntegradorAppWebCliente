using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Integrador.Migrations
{
    /// <inheritdoc />
    public partial class data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Camiones",
                columns: new[] { "Id", "Anio", "Conductor", "Dominio", "Marca", "Modelo", "NumeroChasis", "NumeroMotor" },
                values: new object[,]
                {
                    { 1, 2000, "Rossi Leonardo", "AAA111", "Scania", "P310", "12345645", "9685741" },
                    { 2, 2024, "Martinez Carlos", "AA1251BC", "Scania", "P420", "9124584", "987452" },
                    { 3, 2005, "German Rios", "BBB123", "Ford", "F7000", "963258", "753159" }
                });

            migrationBuilder.InsertData(
                table: "Viajes",
                columns: new[] { "Id", "CiudadDestino", "CiudadOrigen", "FechaLLegada", "FechaSalida", "IdCamion", "kilometraje" },
                values: new object[,]
                {
                    { 1, "Buenos Aires", "Corrientes", new DateTime(2024, 10, 10, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, 800m },
                    { 2, "Mendoza", "Buenos Aires", new DateTime(2023, 9, 16, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 15, 9, 35, 0, 0, DateTimeKind.Unspecified), 2, 1050m },
                    { 3, "Buenos Aires", "Salta", new DateTime(2021, 2, 4, 22, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), 3, 1500m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Viajes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Viajes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Viajes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Camiones",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Camiones",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Camiones",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
