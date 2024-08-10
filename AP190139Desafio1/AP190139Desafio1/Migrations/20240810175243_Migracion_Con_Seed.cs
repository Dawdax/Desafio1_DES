using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AP190139Desafio1.Migrations
{
    /// <inheritdoc />
    public partial class Migracion_Con_Seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    FechaDeNacimiento = table.Column<DateOnly>(type: "date", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Cargo = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    SueldoBase = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "Id", "Apellidos", "Cargo", "Direccion", "FechaDeNacimiento", "Nombres", "SueldoBase", "Telefono" },
                values: new object[,]
                {
                    { 1, "Aguilar Panameño", "Programador", "Apopa,Col. 2, Psj.6, Casa #2", new DateOnly(2000, 7, 6), "David Alexander", 1200m, "72226082" },
                    { 2, "Perez Guerrero", "Vendedor", "Nejapa,Col. 11, Psj.1, Casa #32", new DateOnly(1992, 2, 1), "Pedro Felipe", 550m, "71710021" },
                    { 3, "Reyes Flores", "Vendedor", "Aguilares,Col. 2, Psj.4, Casa #12", new DateOnly(1990, 5, 9), "Sandra Alejandra", 550m, "76663625" },
                    { 4, "Díaz Figueroa", "Contador", "Guazapa,Col. 31, Psj.29, Casa #1", new DateOnly(1993, 12, 8), "Juan Pablo", 650m, "74545466" },
                    { 5, "Aguilar Cortez", "Vendedor", "Soyapango,Col. 45, Psj.20, Casa #32", new DateOnly(1999, 4, 2), "Mariela Alexandra", 575m, "70212325" },
                    { 6, "Lopez Tobar", "Supervisor", "San Marcos,Col. 11, Psj.49, Casa #11", new DateOnly(2001, 12, 12), "Roberto Rodrigo", 600m, "76663636" },
                    { 7, "Flores Aguilar", "Programador", "Panchimalco,Col. 28, Psj.21, Casa #7", new DateOnly(1996, 2, 12), "Brenda Alejandra", 1000m, "78785525" },
                    { 8, "Melara Argueta", "Contador", "Apopa,Col. 17, Psj.17, Casa #8", new DateOnly(1998, 10, 12), "Juan David", 625m, "73636399" },
                    { 9, "Huezo Perez", "Bodeguero", "Soyapango,Col. 29, Psj.23, Casa #63", new DateOnly(1992, 8, 11), "Ricardo Mauricio", 500m, "70121589" },
                    { 10, "Ayala Pineda", "Bodeguero", "Nejapa,Col. 39, Psj.36, Casa #13", new DateOnly(1995, 1, 15), "Karla Lisset", 525m, "71477701" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empleados");
        }
    }
}
