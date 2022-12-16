using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourierExpress.Infrastructure.Migrations
{
    public partial class UserIsActive4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "DeliveryAddress");

            migrationBuilder.DropTable(
                name: "TrackingStatus");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "847be300-741d-481f-b5ee-afd4d324e01d", "AQAAAAEAACcQAAAAEIt78Wf2N8GZ1dH/IO3lSo68DolWK4OLd9xIcxPjA0EnSnOu7OIBMuWPzEBzBrIVpg==" });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6814db10-fdc5-43da-ba5b-abdf0340c445", "AQAAAAEAACcQAAAAEPeItfS+4pMMfjLItVCg91nEdbLg5p3DF2V3tlMxiC10Qy9rJ8FcWfCF6OvU0V2jUw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeliveryAddress",
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
                    table.PrimaryKey("PK_DeliveryAddress", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrackingStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Info = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrackingStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CollectionAddressId = table.Column<int>(type: "int", nullable: false),
                    DeliveryAddressId = table.Column<int>(type: "int", nullable: false),
                    ParcelId = table.Column<int>(type: "int", nullable: false),
                    SenderId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TrackingStatusId = table.Column<int>(type: "int", nullable: false),
                    CustomerMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReceiverName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceiverPhone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AppUser_SenderId",
                        column: x => x.SenderId,
                        principalTable: "AppUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_CollectionAddress_CollectionAddressId",
                        column: x => x.CollectionAddressId,
                        principalTable: "CollectionAddress",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_DeliveryAddress_DeliveryAddressId",
                        column: x => x.DeliveryAddressId,
                        principalTable: "DeliveryAddress",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Parcels_ParcelId",
                        column: x => x.ParcelId,
                        principalTable: "Parcels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_TrackingStatus_TrackingStatusId",
                        column: x => x.TrackingStatusId,
                        principalTable: "TrackingStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EnumStatus = table.Column<int>(type: "int", nullable: false),
                    Info = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrackingStatusId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Status_TrackingStatus_TrackingStatusId",
                        column: x => x.TrackingStatusId,
                        principalTable: "TrackingStatus",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CollectionAddressId",
                table: "Orders",
                column: "CollectionAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_DeliveryAddressId",
                table: "Orders",
                column: "DeliveryAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ParcelId",
                table: "Orders",
                column: "ParcelId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_SenderId",
                table: "Orders",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_TrackingStatusId",
                table: "Orders",
                column: "TrackingStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Status_TrackingStatusId",
                table: "Status",
                column: "TrackingStatusId");
        }
    }
}
