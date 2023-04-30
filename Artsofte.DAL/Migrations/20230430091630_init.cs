using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Artsofte.DAL.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departaments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Floor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departaments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProgrammingLanguages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgrammingLanguages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    DepartamentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProgrammingLanguageId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Departaments_DepartamentId",
                        column: x => x.DepartamentId,
                        principalTable: "Departaments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Employees_ProgrammingLanguages_ProgrammingLanguageId",
                        column: x => x.ProgrammingLanguageId,
                        principalTable: "ProgrammingLanguages",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Departaments",
                columns: new[] { "Id", "Floor", "Name" },
                values: new object[,]
                {
                    { new Guid("309ae420-177a-41b3-8da9-aa39280f19c3"), 3, "GameDev" },
                    { new Guid("7e044f87-61ca-4379-9612-4b732dfbdad5"), 5, "Analytics" },
                    { new Guid("a9274e70-c65c-4a16-b225-663c34bc6363"), 4, "AI" }
                });

            migrationBuilder.InsertData(
                table: "ProgrammingLanguages",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2010bf49-978e-4c50-9c90-17526e35660b"), "Scala" },
                    { new Guid("30d8f615-8378-4343-8aaf-7505bcbae688"), "C++" },
                    { new Guid("35277897-a6bb-450e-b5f9-b4865a8a25fb"), "Go" },
                    { new Guid("48f5d342-647f-4dd1-afc8-b6f30c6e22be"), "JavaScript" },
                    { new Guid("6f95e39b-83af-47e2-9dad-c3faff4fb7fb"), "C#" },
                    { new Guid("8e195f00-3b2e-4075-8386-ab19960dbabd"), "Кумир" },
                    { new Guid("93077adb-6815-47f2-a901-68444c2cc8dd"), "Python" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartamentId",
                table: "Employees",
                column: "DepartamentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ProgrammingLanguageId",
                table: "Employees",
                column: "ProgrammingLanguageId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Departaments");

            migrationBuilder.DropTable(
                name: "ProgrammingLanguages");
        }
    }
}
