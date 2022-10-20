using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TransportManagement.Server.DAL.Migrations
{
    public partial class Update_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UniqueName",
                table: "VehicleTypes",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UniqueName",
                table: "TicketTypes",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UniqueName",
                table: "TicketActions",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleTypes_UniqueKey",
                table: "VehicleTypes",
                column: "UniqueKey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TicketTypes_UniqueName",
                table: "TicketTypes",
                column: "UniqueName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TicketActions_UniqueName",
                table: "TicketActions",
                column: "UniqueName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_VehicleTypes_UniqueKey",
                table: "VehicleTypes");

            migrationBuilder.DropIndex(
                name: "IX_TicketTypes_UniqueName",
                table: "TicketTypes");

            migrationBuilder.DropIndex(
                name: "IX_TicketActions_UniqueName",
                table: "TicketActions");

            migrationBuilder.DropColumn(
                name: "UniqueName",
                table: "VehicleTypes");

            migrationBuilder.DropColumn(
                name: "UniqueName",
                table: "TicketTypes");

            migrationBuilder.DropColumn(
                name: "UniqueName",
                table: "TicketActions");
        }
    }
}