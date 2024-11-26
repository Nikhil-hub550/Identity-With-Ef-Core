using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentProject.Migrations
{
    public partial class RoleSeeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoleCode",
                schema: "Identity",
                table: "Roles");

            migrationBuilder.AlterColumn<string>(
                name: "Disabled",
                schema: "Identity",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "True",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AddColumn<int>(
                name: "Heirarchy",
                schema: "Identity",
                table: "Roles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Heirarchy", "Name", "NormalizedName" },
                values: new object[] { "66c13c38-93ab-4718-9146-b2786a536fbf", "78b2237e-7fc8-405c-bc6d-a3d474fccc8f", 1, "Administration", "ADMIN" });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Heirarchy", "Name", "NormalizedName" },
                values: new object[] { "92962ba3-7d9b-43e0-9e13-940c23074ef4", "1910146f-dccc-43ac-92d6-83b23e15d908", 2, "Client", "CLIENT" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "66c13c38-93ab-4718-9146-b2786a536fbf");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "92962ba3-7d9b-43e0-9e13-940c23074ef4");

            migrationBuilder.DropColumn(
                name: "Heirarchy",
                schema: "Identity",
                table: "Roles");

            migrationBuilder.AlterColumn<bool>(
                name: "Disabled",
                schema: "Identity",
                table: "Roles",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "True");

            migrationBuilder.AddColumn<string>(
                name: "RoleCode",
                schema: "Identity",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
