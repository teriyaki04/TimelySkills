using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TimelySkills.Web.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderFirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SenderLastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SenderPatronymic = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SenderCity = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SenderAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ReceiverFirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ReceiverLastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ReceiverPatronymic = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ReceiverCity = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ReceiverAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DateOfDispatch = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
