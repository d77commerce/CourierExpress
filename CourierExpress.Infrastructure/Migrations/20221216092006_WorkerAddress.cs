using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourierExpress.Infrastructure.Migrations
{
    public partial class WorkerAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Branch_BranchAddress_AddressId",
                table: "Branch");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Addresses_CollectionAddressId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "BranchAddress");

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.CreateTable(
                name: "CollectionAddress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Postcode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollectionAddress", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e9b3e79-ff44-4076-9948-247c50b2d07a", "AQAAAAEAACcQAAAAEIoOGNnSuSwBwbe1NYY72hS7rCZOLnfdPUzR1IlwHAaYXG5h6CxEkTtcKXVLOcu6TQ==", "5257004d-3e96-48ed-9c82-f14f704948e9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d8c0e74-2e98-4462-949a-9c93a28da788", "AQAAAAEAACcQAAAAEP4sxb5v5mVCFVNrOZi2yHKSBzeDAFXCyET7YaIxhcHalbIgRoHCwylqvKJi334+dg==", "d3763ea7-4ad7-45cc-b03a-5fd76d68875a" });

            migrationBuilder.InsertData(
                table: "CollectionAddress",
                columns: new[] { "Id", "AddressLine1", "AddressLine2", "City", "Country", "Postcode", "Street" },
                values: new object[] { 1, null, null, "Sofia", "Bulgaria", "1000", "Nezabravka" });

            migrationBuilder.AddForeignKey(
                name: "FK_Branch_Addresses_AddressId",
                table: "Branch",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_CollectionAddress_CollectionAddressId",
                table: "Orders",
                column: "CollectionAddressId",
                principalTable: "CollectionAddress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Branch_Addresses_AddressId",
                table: "Branch");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_CollectionAddress_CollectionAddressId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "CollectionAddress");

            migrationBuilder.CreateTable(
                name: "BranchAddress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Postcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchAddress", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "AddressLine1", "AddressLine2", "City", "Country", "Postcode", "Street" },
                values: new object[] { 1, null, null, "Sofia", "Bulgaria", "1000", "Nezabravka" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7ac96751-a6e1-4f77-829e-2d66268dbd9f", "AQAAAAEAACcQAAAAEJdLGd5xiJbMYkwF4acIYNpNFv3ITM2k4YY4vxgPfFVTcTQhZ1MHmrUCfGf2svsrog==", "d43d8371-d4b9-463c-b998-5c7747a6860d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc0f3753-dcca-4afa-b5c6-8988f5aaac15", "AQAAAAEAACcQAAAAEMsPVIjz6TRInqadBUhq0IWX4j4e1BD6mOCCCsb5v9ZZeRgMbMPcle3C3Fbc/3Zgqw==", "21e1943a-04fc-43ed-99ff-d478f4ebe628" });

            migrationBuilder.AddForeignKey(
                name: "FK_Branch_BranchAddress_AddressId",
                table: "Branch",
                column: "AddressId",
                principalTable: "BranchAddress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Addresses_CollectionAddressId",
                table: "Orders",
                column: "CollectionAddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
