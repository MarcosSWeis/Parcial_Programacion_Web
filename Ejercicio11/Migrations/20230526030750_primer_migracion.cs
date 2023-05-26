using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ejercicio11.Migrations
{
    public partial class primer_migracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ruedas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rodado = table.Column<short>(nullable: false),
                    PresionMaximaAire = table.Column<int>(nullable: false),
                    AltoLlanta = table.Column<short>(nullable: false),
                    AnchoLlanta = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ruedas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marca = table.Column<string>(nullable: false),
                    Modelo = table.Column<string>(nullable: false),
                    TipoVehiculo = table.Column<int>(nullable: false),
                    Peso = table.Column<int>(nullable: false),
                    FechaLanzamiento = table.Column<DateTime>(nullable: false),
                    CantidadRuedas = table.Column<int>(nullable: false),
                    RuedaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehiculos_Ruedas_RuedaId",
                        column: x => x.RuedaId,
                        principalTable: "Ruedas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Ruedas",
                columns: new[] { "Id", "AltoLlanta", "AnchoLlanta", "PresionMaximaAire", "Rodado" },
                values: new object[,]
                {
                    { 1, (short)55, (short)245, 35, (short)20 },
                    { 2, (short)50, (short)215, 32, (short)17 },
                    { 3, (short)60, (short)265, 35, (short)18 },
                    { 4, (short)55, (short)235, 34, (short)19 },
                    { 5, (short)50, (short)245, 36, (short)20 },
                    { 6, (short)50, (short)205, 32, (short)16 },
                    { 7, (short)55, (short)265, 35, (short)17 },
                    { 8, (short)55, (short)235, 34, (short)18 },
                    { 9, (short)50, (short)215, 32, (short)17 },
                    { 10, (short)60, (short)265, 35, (short)18 }
                });

            migrationBuilder.InsertData(
                table: "Vehiculos",
                columns: new[] { "Id", "CantidadRuedas", "FechaLanzamiento", "Marca", "Modelo", "Peso", "RuedaId", "TipoVehiculo" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ford", "Mustang", 1500, 1, 0 },
                    { 2, 0, new DateTime(2019, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Toyota", "Corolla", 1300, 2, 1 },
                    { 3, 0, new DateTime(2018, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chevrolet", "Silverado", 2000, 3, 2 },
                    { 4, 0, new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Honda", "CR-V", 1600, 4, 3 },
                    { 5, 0, new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BMW", "i8", 1700, 5, 0 },
                    { 6, 0, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nissan", "Sentra", 1400, 6, 1 },
                    { 7, 0, new DateTime(2017, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ford", "Ranger", 1800, 7, 2 },
                    { 8, 0, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Toyota", "RAV4", 1500, 8, 3 },
                    { 9, 0, new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chevrolet", "Cruze", 1300, 9, 1 },
                    { 10, 0, new DateTime(2021, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jeep", "Wrangler", 1900, 10, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_RuedaId",
                table: "Vehiculos",
                column: "RuedaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehiculos");

            migrationBuilder.DropTable(
                name: "Ruedas");
        }
    }
}
