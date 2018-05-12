﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using netcore.Data;
using System;

namespace netcore.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180512181937_initialdb")]
    partial class initialdb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("netcore.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<bool>("ApplicationUserRole");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("HomeRole");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<bool>("SalesOrderLineRole");

                    b.Property<bool>("SalesOrderRole");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TodoLineRole");

                    b.Property<bool>("TodoRole");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.Property<bool>("isSuperAdmin");

                    b.Property<string>("profilePictureUrl");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("netcore.Models.SalesOrder", b =>
                {
                    b.Property<string>("salesOrderId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(38);

                    b.Property<string>("HasChild");

                    b.Property<DateTime>("createdAt");

                    b.Property<string>("salesOrderName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("salesOrderId");

                    b.ToTable("SalesOrder");
                });

            modelBuilder.Entity("netcore.Models.SalesOrderLine", b =>
                {
                    b.Property<string>("salesOrderLineId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(38);

                    b.Property<string>("salesOrderId")
                        .HasMaxLength(38);

                    b.Property<string>("salesOrderLineName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("salesOrderLineId");

                    b.HasIndex("salesOrderId");

                    b.ToTable("SalesOrderLine");
                });

            modelBuilder.Entity("netcore.Models.Todo", b =>
                {
                    b.Property<string>("todoId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(38);

                    b.Property<string>("HasChild");

                    b.Property<DateTime>("createdAt");

                    b.Property<string>("description")
                        .HasMaxLength(100);

                    b.Property<string>("todoName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("todoId");

                    b.ToTable("Todo");
                });

            modelBuilder.Entity("netcore.Models.TodoLine", b =>
                {
                    b.Property<string>("todoLineId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(38);

                    b.Property<DateTime>("createdAt");

                    b.Property<string>("description")
                        .HasMaxLength(100);

                    b.Property<string>("todoId")
                        .HasMaxLength(38);

                    b.Property<string>("todoLineName")
                        .HasMaxLength(50);

                    b.HasKey("todoLineId");

                    b.HasIndex("todoId");

                    b.ToTable("TodoLine");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("netcore.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("netcore.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("netcore.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("netcore.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("netcore.Models.SalesOrderLine", b =>
                {
                    b.HasOne("netcore.Models.SalesOrder", "salesOrder")
                        .WithMany("salesOrderLine")
                        .HasForeignKey("salesOrderId");
                });

            modelBuilder.Entity("netcore.Models.TodoLine", b =>
                {
                    b.HasOne("netcore.Models.Todo", "todo")
                        .WithMany("todoLines")
                        .HasForeignKey("todoId");
                });
#pragma warning restore 612, 618
        }
    }
}
