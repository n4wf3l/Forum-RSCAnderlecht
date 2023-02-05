using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RSCAnderlechtF.Models;
using System.Reflection.Emit;

namespace RSCAnderlechtF.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            seedData(builder);
            //modelBuilder.Entity<AspNetUserLogin>().HasNoKey();
        }

        private void seedData(ModelBuilder builder)
        {

            #region Users
            var user1 = new IdentityUser()
            {
                Id = "a1ac0183-e84b-4fd2-b5b6-bc69b55519c1",
                Email = "user1@user.com",
                NormalizedEmail = "USER1@USER.COM",
                UserName = "user1@user.com",
                NormalizedUserName = "USER1@USER.COM",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
            };

            var admin1 = new IdentityUser()
            {
                Id = "99d666d3-40ed-4e9d-bc18-e56f2b69dceb",
                Email = "admin1@test.com",
                NormalizedEmail = "ADMIN1@TEST.COM",
                UserName = "admin1@test.com",
                NormalizedUserName = "ADMIN1@TEST.COM",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
            };

            var passwordHasher = new PasswordHasher<IdentityUser>();
            user1.PasswordHash = passwordHasher.HashPassword(user1, "User1-123");
            admin1.PasswordHash = passwordHasher.HashPassword(admin1, "Admin1-123");

            builder.Entity<IdentityUser>().HasData(user1, admin1);
            #endregion

            #region Roles
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole() { Id = "68bdf9cb-4866-444d-8cf5-56d54170dc81", Name = "Admin", ConcurrencyStamp = "1", NormalizedName = "ADMIN" },
                new IdentityRole() { Id = "544ac087-b472-4914-8104-a55bd381d0e9", Name = "User", ConcurrencyStamp = "2", NormalizedName = "USER" }
                );

            #endregion

            #region Assign roles to users
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>() { RoleId = "544ac087-b472-4914-8104-a55bd381d0e9", UserId = "a1ac0183-e84b-4fd2-b5b6-bc69b55519c1" },
                new IdentityUserRole<string>() { RoleId = "68bdf9cb-4866-444d-8cf5-56d54170dc81", UserId = "99d666d3-40ed-4e9d-bc18-e56f2b69dceb" }
                ) ;
            #endregion

          //  #region Posts
           // builder.Entity<Post>().HasData(
             //   new Post() { Id = 10, Content = "This is my first post", UserId = "a1ac0183-e84b-4fd2-b5b6-bc69b55519c1", CreateAt = new DateTime(2022, 12, 01, 12, 00, 00) },
               // new Post() { Id = 11, Content = "This is my second post", UserId = "a1ac0183-e84b-4fd2-b5b6-bc69b55519c1", CreateAt = new DateTime(2022, 12, 02, 12, 00, 00) },
                //new Post() { Id = 12, Content = "This is my third post", UserId = "99d666d3-40ed-4e9d-bc18-e56f2b69dceb", CreateAt = new DateTime(2022, 12, 03, 12, 00, 00) },
                //new Post() { Id = 13, Content = "This is my fourth post", UserId = "99d666d3-40ed-4e9d-bc18-e56f2b69dceb", CreateAt = new DateTime(2022, 12, 04, 12, 00, 00) }
                //);
            //#endregion
        }
    }
}
