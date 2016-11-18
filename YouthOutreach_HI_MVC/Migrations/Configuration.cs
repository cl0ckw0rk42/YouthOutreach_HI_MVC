namespace YouthOutreach_HI_MVC.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using YouthOutreach_HI_MVC.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<YouthOutreach_HI_MVC.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(YouthOutreach_HI_MVC.Models.ApplicationDbContext context)
        {
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
