﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MobileShop.Data;

namespace MobileShop.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113");

            modelBuilder.Entity("MobileShop.Data.Models.Account", b =>
                {
                    b.Property<int>("Account_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Account_Email");

                    b.Property<string>("Account_FullName");

                    b.Property<bool?>("Account_IsBlocked");

                    b.Property<string>("Account_Password");

                    b.Property<string>("Account_Permission");

                    b.Property<string>("Account_PhoneNumber");

                    b.Property<string>("Account_Sex");

                    b.HasKey("Account_Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("MobileShop.Data.Models.Banner", b =>
                {
                    b.Property<int>("Banner_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Banner_Image");

                    b.HasKey("Banner_Id");

                    b.ToTable("Banners");
                });

            modelBuilder.Entity("MobileShop.Data.Models.Category", b =>
                {
                    b.Property<int>("Category_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Category_Description");

                    b.Property<string>("Category_Name");

                    b.HasKey("Category_Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("MobileShop.Data.Models.Order", b =>
                {
                    b.Property<int>("Order_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool?>("IsCompleted");

                    b.Property<string>("Order_Address");

                    b.Property<string>("Order_Email");

                    b.Property<string>("Order_Name");

                    b.Property<string>("Order_PhoneNumber");

                    b.Property<DateTime>("Order_Placed");

                    b.Property<decimal>("Order_Total");

                    b.HasKey("Order_Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("MobileShop.Data.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetail_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("OrderDetail_Amount");

                    b.Property<decimal>("OrderDetail_Price");

                    b.Property<int>("Order_Id");

                    b.Property<int>("Product_Id");

                    b.HasKey("OrderDetail_Id");

                    b.HasIndex("Order_Id");

                    b.HasIndex("Product_Id");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("MobileShop.Data.Models.Product", b =>
                {
                    b.Property<int>("Product_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Category_Id");

                    b.Property<string>("Product_CPUSpeed");

                    b.Property<string>("Product_Chipset");

                    b.Property<string>("Product_Description");

                    b.Property<string>("Product_FrontCamera");

                    b.Property<string>("Product_GPU");

                    b.Property<string>("Product_ImageThumbnail");

                    b.Property<bool>("Product_InStock");

                    b.Property<bool>("Product_IsPreferred");

                    b.Property<string>("Product_Name");

                    b.Property<string>("Product_OperatingSystem");

                    b.Property<decimal>("Product_Price");

                    b.Property<int>("Product_Purchased");

                    b.Property<string>("Product_RAM");

                    b.Property<string>("Product_ROM");

                    b.Property<string>("Product_RearCamera");

                    b.Property<string>("Product_SDCard");

                    b.Property<bool>("Product_SDCardSupport");

                    b.Property<string>("Product_ScreenResolution");

                    b.Property<string>("Product_ScreenWidth");

                    b.HasKey("Product_Id");

                    b.HasIndex("Category_Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("MobileShop.Data.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItem_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Product_Id");

                    b.Property<int>("ShoppingCartItem_Amount");

                    b.Property<string>("ShoppingCart_Id");

                    b.HasKey("ShoppingCartItem_Id");

                    b.HasIndex("Product_Id");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("MobileShop.Data.Models.OrderDetail", b =>
                {
                    b.HasOne("MobileShop.Data.Models.Order", "Order")
                        .WithMany("OrderLines")
                        .HasForeignKey("Order_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MobileShop.Data.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("Product_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MobileShop.Data.Models.Product", b =>
                {
                    b.HasOne("MobileShop.Data.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("Category_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MobileShop.Data.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("MobileShop.Data.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("Product_Id");
                });
#pragma warning restore 612, 618
        }
    }
}