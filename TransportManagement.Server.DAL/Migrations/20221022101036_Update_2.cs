using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TransportManagement.Server.DAL.Migrations
{
    public partial class Update_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "DepotId",
                table: "Vehicles",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepotId",
                table: "Vehicles");
        }
    }
}
