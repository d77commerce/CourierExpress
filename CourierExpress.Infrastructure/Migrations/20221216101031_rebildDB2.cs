using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourierExpress.Infrastructure.Migrations
{
    public partial class rebildDB2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Branch_Addresses_AddressId",
                table: "Branch");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

            migrationBuilder.RenameTable(
                name: "Addresses",
                newName: "BranchAddress");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BranchAddress",
                table: "BranchAddress",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3472bdcb-5cc4-4e2b-9ccf-85aec7d3e586", "AQAAAAEAACcQAAAAEOYB0P2hKy7lV9Y6WWO5lEjL7XzZ86sk5AKdg3m2TXgGn6se/yEv4kp85XZ1Rqk2dw==", "12691b56-168f-4f0b-a6d8-9e8449b7eeb3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ace9cc31-ca13-4299-9bfd-c824a4b4d0af", "AQAAAAEAACcQAAAAEIN4bd0hay8a9xfyuA4WacBea3dyG65iWKZcbPUn9c7n9NLIcUpW5FVBzTVGgeQW4g==", "628d98cc-8d9f-4e62-bba4-7a5c428b803d" });

            migrationBuilder.AddForeignKey(
                name: "FK_Branch_BranchAddress_AddressId",
                table: "Branch",
                column: "AddressId",
                principalTable: "BranchAddress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Branch_BranchAddress_AddressId",
                table: "Branch");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BranchAddress",
                table: "BranchAddress");

            migrationBuilder.RenameTable(
                name: "BranchAddress",
                newName: "Addresses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d87d1f30-3d45-4946-8069-f6095af2cd0a", "AQAAAAEAACcQAAAAEAaWwIdiJpI1/CM0tA+eAM1YcYfdQLjqbOLeNaO0a6hKnAYk3OUikOLAet7kU+Gqow==", "f11eb5fc-ede6-48c8-bd90-05e745100247" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c54d546c-c72d-440f-b381-54f706aa82c1", "AQAAAAEAACcQAAAAEPdI3qhXPI8kUE8kQnCzOFKuEDxsQkIdxx3iqjuJjSshx7CLG7oWJCtqdeuxR6kpsQ==", "20a1b736-1195-47e0-a8f3-699841be8c3e" });

            migrationBuilder.AddForeignKey(
                name: "FK_Branch_Addresses_AddressId",
                table: "Branch",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
