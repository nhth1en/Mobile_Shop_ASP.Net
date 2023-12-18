using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileShop.Migrations
{
    public partial class CreateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Account_Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Account_Email = table.Column<string>(nullable: true),
                    Account_FullName = table.Column<string>(nullable: true),
                    Account_Password = table.Column<string>(nullable: true),
                    Account_PhoneNumber = table.Column<string>(nullable: true),
                    Account_Sex = table.Column<string>(nullable: true),
                    Account_Permission = table.Column<string>(nullable: true),
                    Account_IsBlocked = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Account_Id);
                });

            migrationBuilder.CreateTable(
                name: "Banners",
                columns: table => new
                {
                    Banner_Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Banner_Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banners", x => x.Banner_Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Category_Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category_Name = table.Column<string>(nullable: true),
                    Category_Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Category_Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Order_Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Order_Name = table.Column<string>(nullable: true),
                    Order_Address = table.Column<string>(nullable: true),
                    Order_PhoneNumber = table.Column<string>(nullable: true),
                    Order_Email = table.Column<string>(nullable: true),
                    Order_Total = table.Column<decimal>(nullable: false),
                    Order_Placed = table.Column<DateTime>(nullable: false),
                    IsCompleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Order_Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Product_Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Product_Name = table.Column<string>(nullable: true),
                    Product_Price = table.Column<decimal>(nullable: false),
                    Product_Description = table.Column<string>(nullable: true),
                    Product_InStock = table.Column<bool>(nullable: false),
                    Product_IsPreferred = table.Column<bool>(nullable: false),
                    Product_ImageThumbnail = table.Column<string>(nullable: true),
                    Product_OperatingSystem = table.Column<string>(nullable: true),
                    Product_Chipset = table.Column<string>(nullable: true),
                    Product_CPUSpeed = table.Column<string>(nullable: true),
                    Product_GPU = table.Column<string>(nullable: true),
                    Product_ScreenResolution = table.Column<string>(nullable: true),
                    Product_ScreenWidth = table.Column<string>(nullable: true),
                    Product_RAM = table.Column<string>(nullable: true),
                    Product_ROM = table.Column<string>(nullable: true),
                    Product_SDCardSupport = table.Column<bool>(nullable: false),
                    Product_SDCard = table.Column<string>(nullable: true),
                    Product_FrontCamera = table.Column<string>(nullable: true),
                    Product_RearCamera = table.Column<string>(nullable: true),
                    Category_Id = table.Column<int>(nullable: false),
                    Product_Purchased = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Product_Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_Category_Id",
                        column: x => x.Category_Id,
                        principalTable: "Categories",
                        principalColumn: "Category_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetail_Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Order_Id = table.Column<int>(nullable: false),
                    Product_Id = table.Column<int>(nullable: false),
                    OrderDetail_Amount = table.Column<int>(nullable: false),
                    OrderDetail_Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetail_Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_Order_Id",
                        column: x => x.Order_Id,
                        principalTable: "Orders",
                        principalColumn: "Order_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_Product_Id",
                        column: x => x.Product_Id,
                        principalTable: "Products",
                        principalColumn: "Product_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItem_Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ShoppingCartItem_Amount = table.Column<int>(nullable: false),
                    Product_Id = table.Column<int>(nullable: true),
                    ShoppingCart_Id = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartItem_Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Products_Product_Id",
                        column: x => x.Product_Id,
                        principalTable: "Products",
                        principalColumn: "Product_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_Order_Id",
                table: "OrderDetails",
                column: "Order_Id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_Product_Id",
                table: "OrderDetails",
                column: "Product_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Category_Id",
                table: "Products",
                column: "Category_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_Product_Id",
                table: "ShoppingCartItems",
                column: "Product_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Banners");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
