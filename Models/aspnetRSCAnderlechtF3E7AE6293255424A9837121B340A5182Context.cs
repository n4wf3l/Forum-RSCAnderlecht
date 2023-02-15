using System;
using System.Collections.Generic;
using FluentAssertions.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RSCAnderlechtF.Models
{
    public partial class aspnetRSCAnderlechtF3E7AE6293255424A9837121B340A5182Context : DbContext
    {
        public aspnetRSCAnderlechtF3E7AE6293255424A9837121B340A5182Context()
        {
        }

        public aspnetRSCAnderlechtF3E7AE6293255424A9837121B340A5182Context(DbContextOptions<aspnetRSCAnderlechtF3E7AE6293255424A9837121B340A5182Context> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRole> AspNetRoles { get; set; } = null!;
        public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; } = null!;
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; } = null!;
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; } = null!;
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; } = null!;
        public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; } = null!;
        public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; } = null!;
        public virtual DbSet<Comment> Comments { get; set; } = null!;
        public virtual DbSet<Post> Posts { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=aspnet-RSCAnderlechtF-3E7AE629-3255-424A-9837-121B340A5182;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserRole>(entity =>
            {
                entity.Property(e => e.UserId).HasMaxLength(450);


                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AspNetUserRole__UserId__5CD6CB2B");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AspNetUserRole__RoleId__5CD6CB2B");
            });

            modelBuilder.Entity<AspNetRoleClaim>(entity =>
            {
                entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserToken>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.Property(e => e.Body).HasMaxLength(550);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.PostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Table__PostId__70DDC3D8");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Table__UserId__6FE99F9F");
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.Property(e => e.Content).HasMaxLength(500);

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Posts__UserId__5CD6CB2B");
            });


            seedData(modelBuilder);

            OnModelCreatingPartial(modelBuilder);

        }

        private void seedData(ModelBuilder builder)
        {

            var user1 = new AspNetUser()
            {
                Id = "a1ac0183-e84b-4fd2-b5b6-bc69b55519c1",
                Email = "user1@user.com",
                NormalizedEmail = "USER1@USER.COM",
                UserName = "user1@user.com",
                NormalizedUserName = "USER1@USER.COM",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
            };

            var admin1 = new AspNetUser()
            {
                Id = "99d666d3-40ed-4e9d-bc18-e56f2b69dceb",
                Email = "admin1@test.com",
                NormalizedEmail = "ADMIN1@TEST.COM",
                UserName = "admin1@test.com",
                NormalizedUserName = "ADMIN1@TEST.COM",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
            };

            var passwordHasher = new PasswordHasher<AspNetUser>();
            user1.PasswordHash = passwordHasher.HashPassword(user1, "User1-123");
            admin1.PasswordHash = passwordHasher.HashPassword(admin1, "Admin1-123");

            builder.Entity<AspNetUser>().HasData(user1, admin1);

            builder.Entity<AspNetRole>().HasData(
                new AspNetRole() { Id = "68bdf9cb-4866-444d-8cf5-56d54170dc81", Name = "Admin", ConcurrencyStamp = "1", NormalizedName = "ADMIN" },
                new AspNetRole() { Id = "544ac087-b472-4914-8104-a55bd381d0e9", Name = "User", ConcurrencyStamp = "2", NormalizedName = "USER" }
                );


            #region Assign roles to users
            builder.Entity<AspNetUserRole>().HasData(
                new AspNetUserRole() {Id=1, RoleId = "544ac087-b472-4914-8104-a55bd381d0e9", UserId = "a1ac0183-e84b-4fd2-b5b6-bc69b55519c1" },
                new AspNetUserRole() {Id = 2,  RoleId = "68bdf9cb-4866-444d-8cf5-56d54170dc81", UserId = "99d666d3-40ed-4e9d-bc18-e56f2b69dceb" }
                );
            #endregion

            builder.Entity<Post>().HasData(
                new Post() { Id = 1, Content = "This is my first post", UserId = "a1ac0183-e84b-4fd2-b5b6-bc69b55519c1", CreateAt = DateTime.UtcNow },
                new Post() { Id = 2, Content = "This is my second post", UserId = "99d666d3-40ed-4e9d-bc18-e56f2b69dceb", CreateAt = DateTime.UtcNow }
                );

            builder.Entity<Comment>().HasData(
                new Comment() { Id = 1, Body = "This is my first comment", UserId = "99d666d3-40ed-4e9d-bc18-e56f2b69dceb", PostId = 1, CreatedAt = DateTime.UtcNow },
                new Comment() { Id = 2, Body = "This is my first comment", UserId = "a1ac0183-e84b-4fd2-b5b6-bc69b55519c1", PostId = 2, CreatedAt = DateTime.UtcNow }
                );

        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
