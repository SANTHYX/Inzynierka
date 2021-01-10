﻿// <auto-generated />
using System;
using Farmino.Infrastructure.ORM;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Farmino.Infrastructure.Migrations
{
    [DbContext(typeof(FarminoDbContext))]
    partial class FarminoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Farmino.Data.Models.Aggregations.Auction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AuctionerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasMaxLength(10)
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasMaxLength(10)
                        .HasColumnType("datetime2");

                    b.Property<decimal>("StartingPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AuctionerId");

                    b.ToTable("Auctions");
                });

            modelBuilder.Entity("Farmino.Data.Models.Aggregations.Auctioner", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Auctioners");
                });

            modelBuilder.Entity("Farmino.Data.Models.Aggregations.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Farmino.Data.Models.Aggregations.Farmer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Farmers");
                });

            modelBuilder.Entity("Farmino.Data.Models.Aggregations.Offer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasMaxLength(10)
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("FarmerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("FarmerId");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("Offers");
                });

            modelBuilder.Entity("Farmino.Data.Models.Aggregations.RefreshToken", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ExpiresAt")
                        .HasMaxLength(10)
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("GeneratedAt")
                        .HasMaxLength(10)
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsRevoked")
                        .HasMaxLength(1)
                        .HasColumnType("bit");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("RefreshTokens");
                });

            modelBuilder.Entity("Farmino.Data.Models.Aggregations.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasMaxLength(10)
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasMaxLength(10)
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Farmino.Data.Models.Entities.Order", b =>
                {
                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OfferId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("BoughtQuantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("CustomAddress")
                        .HasColumnType("bit");

                    b.Property<decimal>("PriceSummary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Released")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("CustomerId", "OfferId");

                    b.HasIndex("OfferId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Farmino.Data.Models.Entities.Participant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Participants");
                });

            modelBuilder.Entity("Farmino.Data.Models.Entities.ParticipantAuction", b =>
                {
                    b.Property<Guid>("AuctionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ParticipantId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("ProposedPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("AuctionId", "ParticipantId");

                    b.HasIndex("ParticipantId");

                    b.ToTable("ParticipantAuctions");
                });

            modelBuilder.Entity("Farmino.Data.Models.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Farmino.Data.Models.Entities.Profile", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("Farmino.Data.Models.Aggregations.Auction", b =>
                {
                    b.HasOne("Farmino.Data.Models.Aggregations.Auctioner", "Auctioner")
                        .WithMany("Auctions")
                        .HasForeignKey("AuctionerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Auctioner");
                });

            modelBuilder.Entity("Farmino.Data.Models.Aggregations.Auctioner", b =>
                {
                    b.HasOne("Farmino.Data.Models.Aggregations.User", "User")
                        .WithOne("Auctioner")
                        .HasForeignKey("Farmino.Data.Models.Aggregations.Auctioner", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Farmino.Data.Models.Aggregations.Customer", b =>
                {
                    b.HasOne("Farmino.Data.Models.Aggregations.User", "User")
                        .WithOne("Customer")
                        .HasForeignKey("Farmino.Data.Models.Aggregations.Customer", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Farmino.Data.Models.Aggregations.Farmer", b =>
                {
                    b.HasOne("Farmino.Data.Models.Aggregations.User", "User")
                        .WithOne("Farmer")
                        .HasForeignKey("Farmino.Data.Models.Aggregations.Farmer", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Farmino.Data.Models.Aggregations.Offer", b =>
                {
                    b.HasOne("Farmino.Data.Models.Aggregations.Farmer", "Farmer")
                        .WithMany("Offers")
                        .HasForeignKey("FarmerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Farmino.Data.Models.Entities.Product", "Product")
                        .WithOne("Offer")
                        .HasForeignKey("Farmino.Data.Models.Aggregations.Offer", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Farmer");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Farmino.Data.Models.Aggregations.RefreshToken", b =>
                {
                    b.HasOne("Farmino.Data.Models.Aggregations.User", "User")
                        .WithMany("RefreshTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Farmino.Data.Models.Entities.Order", b =>
                {
                    b.HasOne("Farmino.Data.Models.Aggregations.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Farmino.Data.Models.Aggregations.Offer", "Offer")
                        .WithMany("Orders")
                        .HasForeignKey("OfferId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.OwnsOne("Farmino.Data.Models.ValueObjects.Address", "OrderAddress", b1 =>
                        {
                            b1.Property<Guid>("OrderCustomerId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<Guid>("OrderOfferId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("City")
                                .HasMaxLength(30)
                                .HasColumnType("nvarchar(30)")
                                .HasColumnName("City");

                            b1.Property<string>("HouseNumber")
                                .HasMaxLength(5)
                                .HasColumnType("nvarchar(5)")
                                .HasColumnName("HouseNumber");

                            b1.Property<string>("PostalCode")
                                .HasMaxLength(7)
                                .HasColumnType("nvarchar(7)")
                                .HasColumnName("PostalCode");

                            b1.Property<string>("Street")
                                .HasMaxLength(30)
                                .HasColumnType("nvarchar(30)")
                                .HasColumnName("Street");

                            b1.HasKey("OrderCustomerId", "OrderOfferId");

                            b1.ToTable("Orders");

                            b1.WithOwner()
                                .HasForeignKey("OrderCustomerId", "OrderOfferId");
                        });

                    b.Navigation("Customer");

                    b.Navigation("Offer");

                    b.Navigation("OrderAddress");
                });

            modelBuilder.Entity("Farmino.Data.Models.Entities.Participant", b =>
                {
                    b.HasOne("Farmino.Data.Models.Aggregations.User", "User")
                        .WithOne("Participant")
                        .HasForeignKey("Farmino.Data.Models.Entities.Participant", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Farmino.Data.Models.Entities.ParticipantAuction", b =>
                {
                    b.HasOne("Farmino.Data.Models.Aggregations.Auction", "Auction")
                        .WithMany("Participants")
                        .HasForeignKey("AuctionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Farmino.Data.Models.Entities.Participant", "Participant")
                        .WithMany("Auctions")
                        .HasForeignKey("ParticipantId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Auction");

                    b.Navigation("Participant");
                });

            modelBuilder.Entity("Farmino.Data.Models.Entities.Product", b =>
                {
                    b.OwnsOne("Farmino.Data.Models.ValueObjects.Weight", "Weight", b1 =>
                        {
                            b1.Property<Guid>("ProductId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<int>("Unit")
                                .HasColumnType("int")
                                .HasColumnName("Unit");

                            b1.Property<double>("Value")
                                .HasColumnType("float")
                                .HasColumnName("Value");

                            b1.HasKey("ProductId");

                            b1.ToTable("Products");

                            b1.WithOwner()
                                .HasForeignKey("ProductId");
                        });

                    b.Navigation("Weight");
                });

            modelBuilder.Entity("Farmino.Data.Models.Entities.Profile", b =>
                {
                    b.HasOne("Farmino.Data.Models.Aggregations.User", "User")
                        .WithOne("Profile")
                        .HasForeignKey("Farmino.Data.Models.Entities.Profile", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("Farmino.Data.Models.ValueObjects.Address", "Address", b1 =>
                        {
                            b1.Property<Guid>("ProfileId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("City")
                                .HasMaxLength(30)
                                .HasColumnType("nvarchar(30)")
                                .HasColumnName("City");

                            b1.Property<string>("HouseNumber")
                                .HasMaxLength(5)
                                .HasColumnType("nvarchar(5)")
                                .HasColumnName("HouseNumber");

                            b1.Property<string>("PostalCode")
                                .HasMaxLength(7)
                                .HasColumnType("nvarchar(7)")
                                .HasColumnName("PostalCode");

                            b1.Property<string>("Street")
                                .HasMaxLength(30)
                                .HasColumnType("nvarchar(30)")
                                .HasColumnName("Street");

                            b1.HasKey("ProfileId");

                            b1.ToTable("Profiles");

                            b1.WithOwner()
                                .HasForeignKey("ProfileId");
                        });

                    b.Navigation("Address");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Farmino.Data.Models.Aggregations.Auction", b =>
                {
                    b.Navigation("Participants");
                });

            modelBuilder.Entity("Farmino.Data.Models.Aggregations.Auctioner", b =>
                {
                    b.Navigation("Auctions");
                });

            modelBuilder.Entity("Farmino.Data.Models.Aggregations.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Farmino.Data.Models.Aggregations.Farmer", b =>
                {
                    b.Navigation("Offers");
                });

            modelBuilder.Entity("Farmino.Data.Models.Aggregations.Offer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Farmino.Data.Models.Aggregations.User", b =>
                {
                    b.Navigation("Auctioner");

                    b.Navigation("Customer");

                    b.Navigation("Farmer");

                    b.Navigation("Participant");

                    b.Navigation("Profile");

                    b.Navigation("RefreshTokens");
                });

            modelBuilder.Entity("Farmino.Data.Models.Entities.Participant", b =>
                {
                    b.Navigation("Auctions");
                });

            modelBuilder.Entity("Farmino.Data.Models.Entities.Product", b =>
                {
                    b.Navigation("Offer");
                });
#pragma warning restore 612, 618
        }
    }
}
