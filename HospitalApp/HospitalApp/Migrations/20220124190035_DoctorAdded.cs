using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalApp.Migrations
{
    public partial class DoctorAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Surname = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Name", "Surname", "Type" },
                values: new object[,]
                {
                    { 1, "Savo", "Naokmet", 0 },
                    { 2, "Simo", "Samardzic", 1 },
                    { 3, "Nikola", "Kosjerina", 0 },
                    { 4, "Milorad Miko Messi", "Medan", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.InsertData(
                table: "RegUsers",
                columns: new[] { "Id", "Address", "Birthday", "City", "Discriminator", "Email", "Name", "Password", "Phone", "Surname" },
                values: new object[] { 1, "Njegoseva 2", new DateTime(1938, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ljubinje", "Admin", "admin@gmail.com", "Kosa", "123", "059621610", "Pesut" });
        }
    }
}
