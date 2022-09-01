using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalApp.Migrations
{
    public partial class AppointmentAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(type: "datetime", nullable: false),
                    DoctorId = table.Column<int>(type: "int", nullable: false),
                    IsTaken = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PatientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "Date", "DoctorId", "IsTaken", "PatientId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 2, 23, 10, 30, 50, 0, DateTimeKind.Unspecified), 1, false, 0 },
                    { 2, new DateTime(2022, 2, 27, 11, 30, 0, 0, DateTimeKind.Unspecified), 2, false, 0 },
                    { 3, new DateTime(2022, 1, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), 3, false, 0 },
                    { 4, new DateTime(2022, 2, 5, 18, 0, 0, 0, DateTimeKind.Unspecified), 4, false, 0 },
                    { 5, new DateTime(2022, 2, 2, 13, 30, 0, 0, DateTimeKind.Unspecified), 1, false, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");
        }
    }
}
