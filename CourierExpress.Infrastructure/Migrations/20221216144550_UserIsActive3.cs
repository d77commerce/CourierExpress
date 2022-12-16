using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourierExpress.Infrastructure.Migrations
{
    public partial class UserIsActive3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b6b39097-ebe3-4be0-b61a-ca9d07472213", "AQAAAAEAACcQAAAAEP6Yo7cKbHrCWCFv/oysaWplw2vVmO8p26lMCxQToMdmaV74ESqGjFXm8F2T183sfg==" });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3de16402-5389-4bda-aa56-114feadd9d73", "AQAAAAEAACcQAAAAEIgYv8Hgrj7uBaHcwJc5VWUZGBthWr4rs5iVS/TJCpV6FP+SlrqXnVahSCtITk01gQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
