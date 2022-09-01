using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalApp.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "surname",
                table: "RegUsers",
                newName: "Surname");

            migrationBuilder.RenameColumn(
                name: "phone",
                table: "RegUsers",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "RegUsers",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "RegUsers",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "medicalRecordId",
                table: "RegUsers",
                newName: "MedicalRecordId");

            migrationBuilder.RenameColumn(
                name: "isBlocked",
                table: "RegUsers",
                newName: "IsBlocked");

            migrationBuilder.RenameColumn(
                name: "isBlockable",
                table: "RegUsers",
                newName: "IsBlockable");

            migrationBuilder.RenameColumn(
                name: "healthCard",
                table: "RegUsers",
                newName: "HealthCard");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "RegUsers",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "city",
                table: "RegUsers",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "bloodType",
                table: "RegUsers",
                newName: "BloodType");

            migrationBuilder.RenameColumn(
                name: "birthday",
                table: "RegUsers",
                newName: "Birthday");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "RegUsers",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "RegUsers",
                newName: "Id");

            migrationBuilder.InsertData(
                table: "RegUsers",
                columns: new[] { "Id", "Address", "Birthday", "City", "Discriminator", "Email", "Name", "Password", "Phone", "Surname" },
                values: new object[] { 1, "Njegoseva 2", new DateTime(1938, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ljubinje", "Admin", "admin@gmail.com", "Kosa", "123", "059621610", "Pesut" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RegUsers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "RegUsers",
                newName: "surname");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "RegUsers",
                newName: "phone");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "RegUsers",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "RegUsers",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "MedicalRecordId",
                table: "RegUsers",
                newName: "medicalRecordId");

            migrationBuilder.RenameColumn(
                name: "IsBlocked",
                table: "RegUsers",
                newName: "isBlocked");

            migrationBuilder.RenameColumn(
                name: "IsBlockable",
                table: "RegUsers",
                newName: "isBlockable");

            migrationBuilder.RenameColumn(
                name: "HealthCard",
                table: "RegUsers",
                newName: "healthCard");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "RegUsers",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "RegUsers",
                newName: "city");

            migrationBuilder.RenameColumn(
                name: "BloodType",
                table: "RegUsers",
                newName: "bloodType");

            migrationBuilder.RenameColumn(
                name: "Birthday",
                table: "RegUsers",
                newName: "birthday");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "RegUsers",
                newName: "address");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "RegUsers",
                newName: "id");
        }
    }
}
