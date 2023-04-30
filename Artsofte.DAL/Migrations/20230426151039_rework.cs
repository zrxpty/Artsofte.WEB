using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Artsofte.DAL.Migrations
{
    /// <inheritdoc />
    public partial class rework : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departaments",
                keyColumn: "Id",
                keyValue: new Guid("2aa8b6de-a94b-4a61-8de2-1c1dd3081d9b"));

            migrationBuilder.DeleteData(
                table: "Departaments",
                keyColumn: "Id",
                keyValue: new Guid("37eeb94e-0af2-47fe-8fb7-1020eb2d965f"));

            migrationBuilder.DeleteData(
                table: "Departaments",
                keyColumn: "Id",
                keyValue: new Guid("d27b4d10-c4f7-46c6-be3f-13b3e7dc2614"));

            migrationBuilder.DeleteData(
                table: "ProgrammingLanguages",
                keyColumn: "Id",
                keyValue: new Guid("091dfd53-a344-4dad-aea0-6399e871ec6c"));

            migrationBuilder.DeleteData(
                table: "ProgrammingLanguages",
                keyColumn: "Id",
                keyValue: new Guid("19e545ad-bd0b-42e4-ac4f-4e1de9274dda"));

            migrationBuilder.DeleteData(
                table: "ProgrammingLanguages",
                keyColumn: "Id",
                keyValue: new Guid("57d5dd46-4a64-45ec-800f-fd299cba761f"));

            migrationBuilder.DeleteData(
                table: "ProgrammingLanguages",
                keyColumn: "Id",
                keyValue: new Guid("651709a0-5eb1-45d7-8f7f-122dc1bfa066"));

            migrationBuilder.DeleteData(
                table: "ProgrammingLanguages",
                keyColumn: "Id",
                keyValue: new Guid("7e2a4608-f5e1-4ba5-a7ed-d7516f7803e8"));

            migrationBuilder.DeleteData(
                table: "ProgrammingLanguages",
                keyColumn: "Id",
                keyValue: new Guid("c810e669-1840-4af7-8f50-d47cfc25a3fe"));

            migrationBuilder.DeleteData(
                table: "ProgrammingLanguages",
                keyColumn: "Id",
                keyValue: new Guid("ecd57f42-d96e-481c-a6e7-f13061531059"));

            migrationBuilder.InsertData(
                table: "Departaments",
                columns: new[] { "Id", "Floor", "Name" },
                values: new object[,]
                {
                    { new Guid("5487ec23-ca3e-48f5-b269-76750ce8d0c1"), 4, "AI" },
                    { new Guid("778342d4-d285-446b-b61f-45777dfc1261"), 5, "Analytics" },
                    { new Guid("fdce7ce6-712f-40fc-b4d0-79fe2d20767c"), 3, "GameDev" }
                });

            migrationBuilder.InsertData(
                table: "ProgrammingLanguages",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0766f8b1-83d1-476f-996b-6d8abe5af6ba"), "Кумир" },
                    { new Guid("13939561-3327-41f6-909c-2a09c48e82b3"), "Go" },
                    { new Guid("5a71d13c-9111-462c-94d7-a8ee4a71a8dd"), "Scala" },
                    { new Guid("681bd6db-ab50-414f-9131-3d239c25af41"), "C#" },
                    { new Guid("6e74d219-589c-49b0-9c4a-954e0029d521"), "C++" },
                    { new Guid("9139235e-fb1e-4ba3-92b7-46462aa3c443"), "JavaScript" },
                    { new Guid("ae0db73e-e8ed-4c20-b80b-9c5e0b59d45b"), "Python" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departaments",
                keyColumn: "Id",
                keyValue: new Guid("5487ec23-ca3e-48f5-b269-76750ce8d0c1"));

            migrationBuilder.DeleteData(
                table: "Departaments",
                keyColumn: "Id",
                keyValue: new Guid("778342d4-d285-446b-b61f-45777dfc1261"));

            migrationBuilder.DeleteData(
                table: "Departaments",
                keyColumn: "Id",
                keyValue: new Guid("fdce7ce6-712f-40fc-b4d0-79fe2d20767c"));

            migrationBuilder.DeleteData(
                table: "ProgrammingLanguages",
                keyColumn: "Id",
                keyValue: new Guid("0766f8b1-83d1-476f-996b-6d8abe5af6ba"));

            migrationBuilder.DeleteData(
                table: "ProgrammingLanguages",
                keyColumn: "Id",
                keyValue: new Guid("13939561-3327-41f6-909c-2a09c48e82b3"));

            migrationBuilder.DeleteData(
                table: "ProgrammingLanguages",
                keyColumn: "Id",
                keyValue: new Guid("5a71d13c-9111-462c-94d7-a8ee4a71a8dd"));

            migrationBuilder.DeleteData(
                table: "ProgrammingLanguages",
                keyColumn: "Id",
                keyValue: new Guid("681bd6db-ab50-414f-9131-3d239c25af41"));

            migrationBuilder.DeleteData(
                table: "ProgrammingLanguages",
                keyColumn: "Id",
                keyValue: new Guid("6e74d219-589c-49b0-9c4a-954e0029d521"));

            migrationBuilder.DeleteData(
                table: "ProgrammingLanguages",
                keyColumn: "Id",
                keyValue: new Guid("9139235e-fb1e-4ba3-92b7-46462aa3c443"));

            migrationBuilder.DeleteData(
                table: "ProgrammingLanguages",
                keyColumn: "Id",
                keyValue: new Guid("ae0db73e-e8ed-4c20-b80b-9c5e0b59d45b"));

            migrationBuilder.InsertData(
                table: "Departaments",
                columns: new[] { "Id", "Floor", "Name" },
                values: new object[,]
                {
                    { new Guid("2aa8b6de-a94b-4a61-8de2-1c1dd3081d9b"), 4, "AI" },
                    { new Guid("37eeb94e-0af2-47fe-8fb7-1020eb2d965f"), 5, "Analytics" },
                    { new Guid("d27b4d10-c4f7-46c6-be3f-13b3e7dc2614"), 3, "GameDev" }
                });

            migrationBuilder.InsertData(
                table: "ProgrammingLanguages",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("091dfd53-a344-4dad-aea0-6399e871ec6c"), "Go" },
                    { new Guid("19e545ad-bd0b-42e4-ac4f-4e1de9274dda"), "C++" },
                    { new Guid("57d5dd46-4a64-45ec-800f-fd299cba761f"), "JavaScript" },
                    { new Guid("651709a0-5eb1-45d7-8f7f-122dc1bfa066"), "Python" },
                    { new Guid("7e2a4608-f5e1-4ba5-a7ed-d7516f7803e8"), "Кумир" },
                    { new Guid("c810e669-1840-4af7-8f50-d47cfc25a3fe"), "Scala" },
                    { new Guid("ecd57f42-d96e-481c-a6e7-f13061531059"), "C#" }
                });
        }
    }
}
