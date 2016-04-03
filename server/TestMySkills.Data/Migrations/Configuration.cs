namespace TestMySkills.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using TestMySkills.Data;
    using TestMySkills.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>, IDisposable
    {
        private UserManager<ApplicationUser> userManager;

        private RoleManager<IdentityRole> roleManager;

        private bool disposed = false;

        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            context.Configuration.AutoDetectChangesEnabled = false;

            this.userManager = this.CreateUserManager(context);

            this.roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            if (context.Tests.Any())
            {
                return;
            }

            context.Tests.AddOrUpdate(
                new Test()
                {
                    Title = "C# Syntax",
                    CreatedBy = "Ivo",
                    Date = "12.10.2015",
                    Category = "C#",
                    Description = "dolor sit amet"
                },
                new Test()
                {
                    Title = "JavaScript Promises",
                    CreatedBy = "Puha",
                    Date = "11.09.2015",
                    Category = "JavaScript",
                    Description = "dolor sit amet"
                },

                new Test()
                {
                    Title = "ASP.NET MVC Model Validation",
                    CreatedBy = "Tosha",
                    Date = "05.08.2015",
                    Category = "ASP.NET",
                    Description = "dolor sit amet"
                });

            context.Configuration.AutoDetectChangesEnabled = true;
        }

        private UserManager<ApplicationUser> CreateUserManager(ApplicationDbContext context)
        {
            var userManagerLocal = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            // Configure user manager
            // Configure validation logic for usernames
            userManagerLocal.UserValidator = new UserValidator<ApplicationUser>(userManagerLocal)
            {
                AllowOnlyAlphanumericUserNames = true,
                RequireUniqueEmail = true
            };

            // Configure validation logic for passwords
            userManagerLocal.PasswordValidator = new PasswordValidator
            {
                RequiredLength = 3,
                RequireNonLetterOrDigit = false,
                RequireDigit = false,
                RequireLowercase = false,
                RequireUppercase = false,
            };

            return userManagerLocal;
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this.roleManager.Dispose();
                }
            }

            this.disposed = true;
        }

    }
}
