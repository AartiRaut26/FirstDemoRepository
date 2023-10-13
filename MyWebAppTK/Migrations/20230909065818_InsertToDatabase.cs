using System;
using System.Data;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyWebAppTK.Migrations
{
    /// <inheritdoc />
    public partial class InsertToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bookings",
                columns: table => new
                {
                    Booking_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Client_City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Display_Booking = table.Column<int>(type: "int", nullable: false),
                    Booking_Date = table.Column<DateTime>(type: "datetime2", nullable: false),

                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookings", x => x.Booking_Id);

                table.UniqueConstraint("Client_Name",x => x.Client_Name);
                table.UniqueConstraint("Email", x => x.Email);
                table.UniqueConstraint("Client_Name", x => x.Client_Name);




                }) ;
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bookings");
        }
    }
}
