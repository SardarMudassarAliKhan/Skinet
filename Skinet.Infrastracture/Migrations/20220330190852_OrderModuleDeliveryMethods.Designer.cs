﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Skinet.Infrastracture.Data;

namespace Skinet.Infrastracture.Migrations
{
    [DbContext(typeof(StoreContext))]
    [Migration("20220330190852_OrderModuleDeliveryMethods")]
    partial class OrderModuleDeliveryMethods
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Skinet.Core.Entities.OrderAggregate.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("State")
                        .HasColumnType("TEXT");

                    b.Property<string>("Street")
                        .HasColumnType("TEXT");

                    b.Property<string>("ZipCode")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("Skinet.Core.Entities.OrderAggregate.DeliveryMethod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DeliveryTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Shortname")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("DeliveryMethods");
                });

            modelBuilder.Entity("Skinet.Core.Entities.OrderAggregate.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BuyerEmial")
                        .HasColumnType("TEXT");

                    b.Property<int?>("DeliveryMethodId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset>("OrderDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("OrderStatus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PaymentIntentId")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ShipToAddressId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("SubTotal")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DeliveryMethodId");

                    b.HasIndex("ShipToAddressId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Skinet.Core.Entities.OrderAggregate.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("OrderId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItem");
                });

            modelBuilder.Entity("Skinet.Core.Entities.ProductBrand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ProductBrands");
                });

            modelBuilder.Entity("Skinet.Core.Entities.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ProductTypes");
                });

            modelBuilder.Entity("Skinet.Core.Entities.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(180);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<string>("PictureUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProductBrandId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProductBrandId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Skinet.Core.Entities.OrderAggregate.Order", b =>
                {
                    b.HasOne("Skinet.Core.Entities.OrderAggregate.DeliveryMethod", "DeliveryMethod")
                        .WithMany()
                        .HasForeignKey("DeliveryMethodId");

                    b.HasOne("Skinet.Core.Entities.OrderAggregate.Address", "ShipToAddress")
                        .WithMany()
                        .HasForeignKey("ShipToAddressId");
                });

            modelBuilder.Entity("Skinet.Core.Entities.OrderAggregate.OrderItem", b =>
                {
                    b.HasOne("Skinet.Core.Entities.OrderAggregate.Order", null)
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId");

                    b.OwnsOne("Skinet.Core.Entities.OrderAggregate.ProductItemOrdered", "ItemOrdered", b1 =>
                        {
                            b1.Property<int>("OrderItemId")
                                .HasColumnType("INTEGER");

                            b1.Property<string>("PictureUrl")
                                .HasColumnType("TEXT");

                            b1.Property<int>("ProductItemId")
                                .HasColumnType("INTEGER");

                            b1.Property<string>("ProductName")
                                .HasColumnType("TEXT");

                            b1.HasKey("OrderItemId");

                            b1.ToTable("OrderItem");

                            b1.WithOwner()
                                .HasForeignKey("OrderItemId");
                        });
                });

            modelBuilder.Entity("Skinet.Core.Entities.Products", b =>
                {
                    b.HasOne("Skinet.Core.Entities.ProductBrand", "ProductBrand")
                        .WithMany()
                        .HasForeignKey("ProductBrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Skinet.Core.Entities.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
