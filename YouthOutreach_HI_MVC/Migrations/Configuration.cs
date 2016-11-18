namespace YouthOutreach_HI_MVC.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using YouthOutreach_HI_MVC.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    internal sealed class Configuration : DbMigrationsConfiguration<YouthOutreach_HI_MVC.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        bool AddUserAndRole(YouthOutreach_HI_MVC.Models.ApplicationDbContext context)
        {
            IdentityResult ir;
            var rm = new RoleManager<IdentityRole>
                (new RoleStore<IdentityRole>(context));

            ir = rm.Create(new IdentityRole("canEdit"));

            var um = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(context));

            //testing giving updated permissions to my own entry
            var user = new ApplicationUser()
            {
                UserName = "user1@contoso.com",
            };

            //hard-coded password REMOVED but standard basic boring one
           //ir = um.Create(user, "REMOVED");

            if (ir.Succeeded == false)               
                return ir.Succeeded;

            ir = um.AddToRole(user.Id, "canEdit");
            return ir.Succeeded;
        }

        protected override void Seed(YouthOutreach_HI_MVC.Models.ApplicationDbContext context)
        {
            //adding authority here
            AddUserAndRole(context);

            context.Donations.AddOrUpdate(p => p.Name,
                new Donations
                {
                    Category = "Girl Clothes",
                    Name = "Short Sleeve T-Shirt",
                    Quantity = 1,
                    Hot = false                    
                },
                new Donations
                {
                    Category = "Boy Clothes",
                    Name = "Long Sleeve T-Shirt",
                    Quantity = 1,
                    Hot = false
                },
                new Donations
                {
                    Category = "Girl Clothes",
                    Name = "Shoes",
                    Quantity = 1,
                    Hot = true
                },
                new Donations
                {
                    Category = "Food",
                    Name = "Bento Box",
                    Quantity = 5,
                    Hot = true
                }
                );
        }
    }
}
