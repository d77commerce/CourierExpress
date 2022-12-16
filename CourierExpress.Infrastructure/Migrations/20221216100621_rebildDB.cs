using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourierExpress.Infrastructure.Migrations
{
    public partial class rebildDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_AppUserId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Parcels_PartOfParcel_PartsId",
                table: "Parcels");

            migrationBuilder.DropIndex(
                name: "IX_Parcels_PartsId",
                table: "Parcels");

            migrationBuilder.DropIndex(
                name: "IX_Orders_AppUserId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PartsId",
                table: "Parcels");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "ParcelId",
                table: "PartOfParcel",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_PartOfParcel_ParcelId",
                table: "PartOfParcel",
                column: "ParcelId");

            migrationBuilder.AddForeignKey(
                name: "FK_PartOfParcel_Parcels_ParcelId",
                table: "PartOfParcel",
                column: "ParcelId",
                principalTable: "Parcels",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PartOfParcel_Parcels_ParcelId",
                table: "PartOfParcel");

            migrationBuilder.DropIndex(
                name: "IX_PartOfParcel_ParcelId",
                table: "PartOfParcel");

            migrationBuilder.DropColumn(
                name: "ParcelId",
                table: "PartOfParcel");

            migrationBuilder.AddColumn<int>(
                name: "PartsId",
                table: "Parcels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: true);

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

            migrationBuilder.UpdateData(
                table: "Parcels",
                keyColumn: "Id",
                keyValue: 1,
                column: "PartsId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Parcels_PartsId",
                table: "Parcels",
                column: "PartsId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AppUserId",
                table: "Orders",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_AppUserId",
                table: "Orders",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Parcels_PartOfParcel_PartsId",
                table: "Parcels",
                column: "PartsId",
                principalTable: "PartOfParcel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
