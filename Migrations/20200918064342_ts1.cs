using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductApi.Migrations
{
    public partial class ts1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customerdetails",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(nullable: true),
                    EmailId = table.Column<string>(nullable: true),
                    MobileNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customerdetails", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Orderdetails",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    CustomerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orderdetails", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orderdetails_Customerdetails_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customerdetails",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Productdetails",
                columns: table => new
                {
                    Productid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productdetails", x => x.Productid);
                    table.ForeignKey(
                        name: "FK_Productdetails_Orderdetails_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orderdetails",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orderdetails_CustomerId",
                table: "Orderdetails",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Productdetails_OrderId",
                table: "Productdetails",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Productdetails");

            migrationBuilder.DropTable(
                name: "Orderdetails");

            migrationBuilder.DropTable(
                name: "Customerdetails");
        }
    }
}
