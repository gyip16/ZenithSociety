namespace ZenithWebSite.Migrations.ZenithSociety
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ZenithWebSite.Data;

    internal sealed class Configuration : DbMigrationsConfiguration<ZenithDataLib.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\ZenithSociety";
        }

        protected override void Seed(ZenithDataLib.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.ActivityCategories.AddOrUpdate(
                a => a.ActivityCategoryId, DummyData.getActivityCategories().ToArray());
            context.SaveChanges();

            context.Events.AddOrUpdate(
                e => e.EventId, DummyData.getEvents(context).ToArray());
        }
    }
}
