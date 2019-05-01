﻿// <auto-generated />
using System;
using Divar.DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Divar.DataAccessLayer.Migrations
{
    [DbContext(typeof(DivarContext))]
    [Migration("20190331085450_two_change")]
    partial class two_change
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Divar.DataAccessLayer.Entities.Advert", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<int>("CityId");

                    b.Property<string>("Date")
                        .HasMaxLength(10);

                    b.Property<string>("Des");

                    b.Property<bool>("IsExpire");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("Seen");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CityId");

                    b.HasIndex("UserId");

                    b.ToTable("Adverts");
                });

            modelBuilder.Entity("Divar.DataAccessLayer.Entities.AdvertField", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdvertId");

                    b.Property<int>("FieldId");

                    b.Property<string>("FieldValue")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("AdvertId");

                    b.HasIndex("FieldId");

                    b.ToTable("AdvertFields");
                });

            modelBuilder.Entity("Divar.DataAccessLayer.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int?>("ParentId");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Divar.DataAccessLayer.Entities.CategoryField", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<int>("FieldId");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("FieldId");

                    b.ToTable("CategoryFields");
                });

            modelBuilder.Entity("Divar.DataAccessLayer.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Divar.DataAccessLayer.Entities.Field", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("HideInFilter");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Fields");
                });

            modelBuilder.Entity("Divar.DataAccessLayer.Entities.Gallery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdvertId");

                    b.Property<string>("Img")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("AdvertId");

                    b.ToTable("Galleries");
                });

            modelBuilder.Entity("Divar.DataAccessLayer.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Divar.DataAccessLayer.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasMaxLength(6);

                    b.Property<bool>("IsActive");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasMaxLength(11);

                    b.Property<string>("Password")
                        .HasMaxLength(50);

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Divar.DataAccessLayer.Entities.Advert", b =>
                {
                    b.HasOne("Divar.DataAccessLayer.Entities.Category", "Category")
                        .WithMany("Adverts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Divar.DataAccessLayer.Entities.City", "City")
                        .WithMany("Adverts")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Divar.DataAccessLayer.Entities.User", "User")
                        .WithMany("Adverts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Divar.DataAccessLayer.Entities.AdvertField", b =>
                {
                    b.HasOne("Divar.DataAccessLayer.Entities.Advert", "Advert")
                        .WithMany("AdvertFields")
                        .HasForeignKey("AdvertId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Divar.DataAccessLayer.Entities.Field", "Field")
                        .WithMany("AdvertFields")
                        .HasForeignKey("FieldId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Divar.DataAccessLayer.Entities.Category", b =>
                {
                    b.HasOne("Divar.DataAccessLayer.Entities.Category", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("Divar.DataAccessLayer.Entities.CategoryField", b =>
                {
                    b.HasOne("Divar.DataAccessLayer.Entities.Category", "Category")
                        .WithMany("CategoryFields")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Divar.DataAccessLayer.Entities.Field", "Field")
                        .WithMany("CategoryFields")
                        .HasForeignKey("FieldId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Divar.DataAccessLayer.Entities.Gallery", b =>
                {
                    b.HasOne("Divar.DataAccessLayer.Entities.Advert", "Advert")
                        .WithMany("Galleries")
                        .HasForeignKey("AdvertId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Divar.DataAccessLayer.Entities.User", b =>
                {
                    b.HasOne("Divar.DataAccessLayer.Entities.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
