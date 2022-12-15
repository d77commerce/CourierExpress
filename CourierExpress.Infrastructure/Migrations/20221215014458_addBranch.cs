using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourierExpress.Infrastructure.Migrations
{
    public partial class addBranch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branch",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branch", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Branch_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BranchWorker",
                columns: table => new
                {
                    WorkerId = table.Column<int>(type: "int", nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchWorker", x => new { x.WorkerId, x.BranchId });
                    table.ForeignKey(
                        name: "FK_BranchWorker_Branch_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BranchWorker_Workers_WorkerId",
                        column: x => x.WorkerId,
                        principalTable: "Workers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "197fd54a-562e-46bc-bd34-a6ed84d89fee", "AQAAAAEAACcQAAAAEAH+mgyWJ8U142Wx6ZcS+6TjLb06iWwb+ZpMMjuR1CmVV5sZeHVsY01ot7G1jDZIqA==", "7b50a7eb-7266-4e0a-947a-4cfc6e05f71d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c6bb6df-0b81-4594-9075-3cf996aaf538", "AQAAAAEAACcQAAAAEORYIf7QbOylTn6uFDK4L7rbaQxcBq0/OPIPPU8TS68Wo7rO5C8W9zscwEOFx8IW1A==", "87d29c87-f5bd-49d2-bf52-1303b1a6a633" });

            migrationBuilder.CreateIndex(
                name: "IX_Branch_AddressId",
                table: "Branch",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchWorker_BranchId",
                table: "BranchWorker",
                column: "BranchId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BranchWorker");

            migrationBuilder.DropTable(
                name: "Branch");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9d2bb5d-3f23-48b2-8f02-ad5b21485b72", "AQAAAAEAACcQAAAAECeMO/ubq5NiteqAhUWfBPa7VSUniz7qGBflo7gZJw39d5veLYV+yO2nbrM3Z8HT7g==", "65be8f13-3eda-4b93-bd1d-0db1d468d5fc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8af81c7-7492-4373-8557-51fb54163685", "AQAAAAEAACcQAAAAEL9qyFhSfucEahhtzfL/O04jkhA4sxKPogA8iSl/SjZpww1AOjJefNKDfG8TVVUEIQ==", "a02cba30-70ab-4a42-997e-ccc48ed00a8c" });
        }
    }
}
