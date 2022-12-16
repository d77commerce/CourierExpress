using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourierExpress.Infrastructure.Migrations
{
    public partial class UserIsActive2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AppUser",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AppUser",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0f6cd2eb-255d-4b53-8055-071778ff16b1", "AQAAAAEAACcQAAAAEIRI0DTN2pYxGoIGF6QDYiZNzXHwotP+jUpz/IOlSbFJpY+Up7Dqen1ZvGSLZVadrQ==" });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7ab99020-6160-4a2b-8d2e-2d1f3508f306", "AQAAAAEAACcQAAAAEO44cCjOhcJgjfEGp2d9FsfXHr//H/orJiwoicsVozwjG1fuEYMdqIOsB2gicFn5lQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AppUser",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AppUser",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8913ea63-386b-47a0-b98b-ab2ace198d6e", "AQAAAAEAACcQAAAAEENWTay6xyncJaRxM6po3YYb3/Pq+mg42aVBRRSvFAklb85XjjGT7PoTQezTWeYMtg==" });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d1c306b2-5638-4228-85e5-f6c13e203198", "AQAAAAEAACcQAAAAEACDb2bEdLWVUuIxje+x/+2mkhM4Gk6hlUvW+/zsuFxr4v/bYvGzjmf8czgcaSEuKw==" });
        }
    }
}
