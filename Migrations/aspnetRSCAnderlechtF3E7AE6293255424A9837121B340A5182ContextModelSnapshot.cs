﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RSCAnderlechtF.Models;

#nullable disable

namespace RSCAnderlechtF.Migrations
{
    [DbContext(typeof(aspnetRSCAnderlechtF3E7AE6293255424A9837121B340A5182Context))]
    partial class aspnetRSCAnderlechtF3E7AE6293255424A9837121B340A5182ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AspNetRoleAspNetUser", b =>
                {
                    b.Property<string>("RolesId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UsersId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("RolesId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("AspNetRoleAspNetUser");
                });

            modelBuilder.Entity("RSCAnderlechtF.Models.AspNetRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "NormalizedName" }, "RoleNameIndex")
                        .IsUnique()
                        .HasFilter("([NormalizedName] IS NOT NULL)");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "68bdf9cb-4866-444d-8cf5-56d54170dc81",
                            ConcurrencyStamp = "1",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "544ac087-b472-4914-8104-a55bd381d0e9",
                            ConcurrencyStamp = "2",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("RSCAnderlechtF.Models.AspNetRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "RoleId" }, "IX_AspNetRoleClaims_RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("RSCAnderlechtF.Models.AspNetUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "NormalizedEmail" }, "EmailIndex");

                    b.HasIndex(new[] { "NormalizedUserName" }, "UserNameIndex")
                        .IsUnique()
                        .HasFilter("([NormalizedUserName] IS NOT NULL)");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "a1ac0183-e84b-4fd2-b5b6-bc69b55519c1",
                            AccessFailedCount = 0,
                            Email = "user1@user.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER1@USER.COM",
                            NormalizedUserName = "USER1@USER.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEI5I6xUWVikFNITNr3NDaCQv5zpQrq+pY9gvn0Q3+3rEyzBVI8qtaAU7OhhaYNdLJQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "bd7b7674-81ff-4215-9aa1-627a030fe346",
                            TwoFactorEnabled = false,
                            UserName = "user1@user.com"
                        },
                        new
                        {
                            Id = "99d666d3-40ed-4e9d-bc18-e56f2b69dceb",
                            AccessFailedCount = 0,
                            Email = "admin1@test.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN1@TEST.COM",
                            NormalizedUserName = "ADMIN1@TEST.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEMbjE54dA/8aDnZjM0KqGyxcl194XpKHOD4Gz5cwKDlBG2uqv08xn8JFBpyIN5gNkQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "6d4b905a-bcc8-42eb-90f9-9e393c3a7064",
                            TwoFactorEnabled = false,
                            UserName = "admin1@test.com"
                        });
                });

            modelBuilder.Entity("RSCAnderlechtF.Models.AspNetUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "UserId" }, "IX_AspNetUserClaims_UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("RSCAnderlechtF.Models.AspNetUserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex(new[] { "UserId" }, "IX_AspNetUserLogins_UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("RSCAnderlechtF.Models.AspNetUserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            RoleId = "544ac087-b472-4914-8104-a55bd381d0e9",
                            UserId = "a1ac0183-e84b-4fd2-b5b6-bc69b55519c1"
                        },
                        new
                        {
                            Id = 2,
                            RoleId = "68bdf9cb-4866-444d-8cf5-56d54170dc81",
                            UserId = "99d666d3-40ed-4e9d-bc18-e56f2b69dceb"
                        });
                });

            modelBuilder.Entity("RSCAnderlechtF.Models.AspNetUserToken", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("RSCAnderlechtF.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasMaxLength(550)
                        .HasColumnType("nvarchar(550)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Body = "This is my first comment",
                            CreatedAt = new DateTime(2023, 2, 15, 16, 5, 26, 921, DateTimeKind.Utc).AddTicks(7291),
                            PostId = 1,
                            UserId = "99d666d3-40ed-4e9d-bc18-e56f2b69dceb"
                        },
                        new
                        {
                            Id = 2,
                            Body = "This is my first comment",
                            CreatedAt = new DateTime(2023, 2, 15, 16, 5, 26, 921, DateTimeKind.Utc).AddTicks(7292),
                            PostId = 2,
                            UserId = "a1ac0183-e84b-4fd2-b5b6-bc69b55519c1"
                        });
                });

            modelBuilder.Entity("RSCAnderlechtF.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "This is my first post",
                            CreateAt = new DateTime(2023, 2, 15, 16, 5, 26, 921, DateTimeKind.Utc).AddTicks(7272),
                            UserId = "a1ac0183-e84b-4fd2-b5b6-bc69b55519c1"
                        },
                        new
                        {
                            Id = 2,
                            Content = "This is my second post",
                            CreateAt = new DateTime(2023, 2, 15, 16, 5, 26, 921, DateTimeKind.Utc).AddTicks(7275),
                            UserId = "99d666d3-40ed-4e9d-bc18-e56f2b69dceb"
                        });
                });

            modelBuilder.Entity("AspNetRoleAspNetUser", b =>
                {
                    b.HasOne("RSCAnderlechtF.Models.AspNetRole", null)
                        .WithMany()
                        .HasForeignKey("RolesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RSCAnderlechtF.Models.AspNetUser", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RSCAnderlechtF.Models.AspNetRoleClaim", b =>
                {
                    b.HasOne("RSCAnderlechtF.Models.AspNetRole", "Role")
                        .WithMany("AspNetRoleClaims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("RSCAnderlechtF.Models.AspNetUserClaim", b =>
                {
                    b.HasOne("RSCAnderlechtF.Models.AspNetUser", "User")
                        .WithMany("AspNetUserClaims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("RSCAnderlechtF.Models.AspNetUserLogin", b =>
                {
                    b.HasOne("RSCAnderlechtF.Models.AspNetUser", "User")
                        .WithMany("AspNetUserLogins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("RSCAnderlechtF.Models.AspNetUserRole", b =>
                {
                    b.HasOne("RSCAnderlechtF.Models.AspNetRole", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .IsRequired()
                        .HasConstraintName("FK__AspNetUserRole__RoleId__5CD6CB2B");

                    b.HasOne("RSCAnderlechtF.Models.AspNetUser", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK__AspNetUserRole__UserId__5CD6CB2B");

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("RSCAnderlechtF.Models.AspNetUserToken", b =>
                {
                    b.HasOne("RSCAnderlechtF.Models.AspNetUser", "User")
                        .WithMany("AspNetUserTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("RSCAnderlechtF.Models.Comment", b =>
                {
                    b.HasOne("RSCAnderlechtF.Models.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostId")
                        .IsRequired()
                        .HasConstraintName("FK__Table__PostId__70DDC3D8");

                    b.HasOne("RSCAnderlechtF.Models.AspNetUser", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK__Table__UserId__6FE99F9F");

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("RSCAnderlechtF.Models.Post", b =>
                {
                    b.HasOne("RSCAnderlechtF.Models.AspNetUser", "User")
                        .WithMany("Posts")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK__Posts__UserId__5CD6CB2B");

                    b.Navigation("User");
                });

            modelBuilder.Entity("RSCAnderlechtF.Models.AspNetRole", b =>
                {
                    b.Navigation("AspNetRoleClaims");

                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("RSCAnderlechtF.Models.AspNetUser", b =>
                {
                    b.Navigation("AspNetUserClaims");

                    b.Navigation("AspNetUserLogins");

                    b.Navigation("AspNetUserTokens");

                    b.Navigation("Comments");

                    b.Navigation("Posts");

                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("RSCAnderlechtF.Models.Post", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}
