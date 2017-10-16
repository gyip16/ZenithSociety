using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZenithDataLib;

namespace ZenithWebSite.Data
{
    public class DummyData
    {
        public static System.Collections.Generic.List<ActivityCategory> getActivityCategories()
        {
            List<ActivityCategory> ActivityCategories = new List<ActivityCategory>()
            {
                new ActivityCategory
                {
                    ActivityDescription = "Senior's Golf Tournament",
                    CreationDate = DateTime.Now
                },
                new ActivityCategory
                {
                    ActivityDescription = "Leadership General Assembly Meeting",
                    CreationDate = DateTime.Now
                },
                new ActivityCategory
                {
                    ActivityDescription = "Youth Bowling Tournament",
                    CreationDate = DateTime.Now
                },
                new ActivityCategory
                {
                    ActivityDescription = "Young ladies cooking lessons",
                    CreationDate = DateTime.Now
                },
                new ActivityCategory
                {
                    ActivityDescription = "Youth craft lessons",
                    CreationDate = DateTime.Now
                },
                new ActivityCategory
                {
                    ActivityDescription = "Youth choir practice",
                    CreationDate = DateTime.Now
                },
                new ActivityCategory
                {
                    ActivityDescription = "Lunch",
                    CreationDate = DateTime.Now
                },
                new ActivityCategory
                {
                    ActivityDescription = "Pancake Breakfast",
                    CreationDate = DateTime.Now
                },
                new ActivityCategory
                {
                    ActivityDescription = "Swimming Lessons for the youth",
                    CreationDate = DateTime.Now
                },
                new ActivityCategory
                {
                    ActivityDescription = "Swimming Excercise for parents",
                    CreationDate = DateTime.Now
                },
                new ActivityCategory
                {
                    ActivityDescription = "Bingo Tournament",
                    CreationDate = DateTime.Now
                },
                new ActivityCategory
                {
                    ActivityDescription = "BBQ Lunch",
                    CreationDate = DateTime.Now
                },
                new ActivityCategory
                {
                    ActivityDescription = "Garage Sale",
                    CreationDate = DateTime.Now
                }
            };
            return ActivityCategories;
        }

        public static List<Event> getEvents(ZenithDataLib.ApplicationDbContext context)
        {
            List<Event> events = new List<Event>()
            {
                new Event
                {
                    EventFromDateAndTime = new DateTime(2017, 10, 17, 8, 30, 0),
                    EventToDateAndTime = new DateTime(2017, 10, 17, 10, 30, 0),
                    EnteredByUsername = "Seed",
                    ActivityCategory = context.ActivityCategories.FirstOrDefault(
                        a => a.ActivityDescription == "Senior's Golf Tournament"),
                    CreationDate = DateTime.Now,
                    IsActive = true
                },
                new Event
                {
                    EventFromDateAndTime = new DateTime(2017, 10, 18, 8, 30, 0),
                    EventToDateAndTime = new DateTime(2017, 10, 18, 10, 30, 0),
                    EnteredByUsername = "Seed",
                    ActivityCategory = context.ActivityCategories.FirstOrDefault(
                        a => a.ActivityDescription == "Leadership General Assembly Meeting"),
                    CreationDate = DateTime.Now,
                    IsActive = true
                },
                new Event
                {
                    EventFromDateAndTime = new DateTime(2017, 10, 20, 17, 30, 0),
                    EventToDateAndTime = new DateTime(2017, 10, 20, 19, 15, 0),
                    EnteredByUsername = "Seed",
                    ActivityCategory = context.ActivityCategories.FirstOrDefault(
                        a => a.ActivityDescription == "Youth Bowling Tournament"),
                    CreationDate = DateTime.Now,
                    IsActive = true
                },
                new Event
                {
                    EventFromDateAndTime = new DateTime(2017, 10, 20, 19, 0, 0),
                    EventToDateAndTime = new DateTime(2017, 10, 20, 20, 0, 0),
                    EnteredByUsername = "Seed",
                    ActivityCategory = context.ActivityCategories.FirstOrDefault(
                        a => a.ActivityDescription == "Young ladies cooking lessons"),
                    CreationDate = DateTime.Now,
                    IsActive = true
                },
                new Event
                {
                    EventFromDateAndTime = new DateTime(2017, 10, 21, 8, 30, 0),
                    EventToDateAndTime = new DateTime(2017, 10, 21, 10, 30, 0),
                    EnteredByUsername = "Seed",
                    ActivityCategory = context.ActivityCategories.FirstOrDefault(
                        a => a.ActivityDescription == "Youth craft lessons"),
                    CreationDate = DateTime.Now,
                    IsActive = true
                },
                new Event
                {
                    EventFromDateAndTime = new DateTime(2017, 10, 21, 10, 30, 0),
                    EventToDateAndTime = new DateTime(2017, 10, 21, 12, 00, 0),
                    EnteredByUsername = "Seed",
                    ActivityCategory = context.ActivityCategories.FirstOrDefault(
                        a => a.ActivityDescription == "Youth choir practice"),
                    CreationDate = DateTime.Now,
                    IsActive = true
                },
                new Event
                {
                    EventFromDateAndTime = new DateTime(2017, 10, 21, 12, 0, 0),
                    EventToDateAndTime = new DateTime(2017, 10, 21, 13, 30, 0),
                    EnteredByUsername = "Seed",
                    ActivityCategory = context.ActivityCategories.FirstOrDefault(
                        a => a.ActivityDescription == "Lunch"),
                    CreationDate = DateTime.Now,
                    IsActive = true
                },
                new Event
                {
                    EventFromDateAndTime = new DateTime(2017, 10, 22, 7, 30, 0),
                    EventToDateAndTime = new DateTime(2017, 10, 2, 8, 30, 0),
                    EnteredByUsername = "Seed",
                    ActivityCategory = context.ActivityCategories.FirstOrDefault(
                        a => a.ActivityDescription == "Pancake Breakfast"),
                    CreationDate = DateTime.Now,
                    IsActive = true
                },
                new Event
                {
                    EventFromDateAndTime = new DateTime(2017, 10, 22, 8, 30, 0),
                    EventToDateAndTime = new DateTime(2017, 10, 22, 10, 30, 0),
                    EnteredByUsername = "Seed",
                    ActivityCategory = context.ActivityCategories.FirstOrDefault(
                        a => a.ActivityDescription == "Swimming Lessons for the youth"),
                    CreationDate = DateTime.Now,
                    IsActive = true
                },
                new Event
                {
                    EventFromDateAndTime = new DateTime(2017, 10, 22, 8, 30, 0),
                    EventToDateAndTime = new DateTime(2017, 10, 22, 10, 30, 0),
                    EnteredByUsername = "Seed",
                    ActivityCategory = context.ActivityCategories.FirstOrDefault(
                        a => a.ActivityDescription == "Swimming Excercise for parents"),
                    CreationDate = DateTime.Now,
                    IsActive = true
                },
                new Event
                {
                    EventFromDateAndTime = new DateTime(2017, 10, 22, 10, 30, 0),
                    EventToDateAndTime = new DateTime(2017, 10, 22, 12, 00, 0),
                    EnteredByUsername = "Seed",
                    ActivityCategory = context.ActivityCategories.FirstOrDefault(
                        a => a.ActivityDescription == "Bingo Tournament"),
                    CreationDate = DateTime.Now,
                    IsActive = true
                },
                new Event
                {
                    EventFromDateAndTime = new DateTime(2017, 10, 22, 12, 0, 0),
                    EventToDateAndTime = new DateTime(2017, 10, 22, 13, 0, 0),
                    EnteredByUsername = "Seed",
                    ActivityCategory = context.ActivityCategories.FirstOrDefault(
                        a => a.ActivityDescription == "BBQ Lunch"),
                    CreationDate = DateTime.Now,
                    IsActive = true
                },
                new Event
                {
                    EventFromDateAndTime = new DateTime(2017, 10, 22, 13, 0, 0),
                    EventToDateAndTime = new DateTime(2017, 10, 22, 18, 0, 0),
                    EnteredByUsername = "Seed",
                    ActivityCategory = context.ActivityCategories.FirstOrDefault(
                        a => a.ActivityDescription == "Garage Sale"),
                    CreationDate = DateTime.Now,
                    IsActive = true
                }
            };
            return events;
        }

        public static void createRolesandUsers()
        {
            ZenithDataLib.ApplicationDbContext context = new ZenithDataLib.ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var UserManager = new UserManager<ZenithDataLib.ApplicationUser>(new UserStore<ApplicationUser>(context));


            // In Startup iam creating first Admin Role and creating a default Admin User    
            if (!roleManager.RoleExists("Admin"))
            {

                // first we create Admin role   
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Admin";
                roleManager.Create(role);

                //Here we create a Admin super user who will maintain the website                  

                var user = new ApplicationUser();
                user.UserName = "a";
                user.Email = "a@a.a";

                string userPWD = "P@$$w0rd";

                var chkUser = UserManager.Create(user, userPWD);

                //Add default User to Role Admin   
                if (chkUser.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user.Id, "Admin");

                }
            }

            // creating Creating Member role    
            if (!roleManager.RoleExists("Member"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Member";
                roleManager.Create(role);

                var user = new ApplicationUser();
                user.UserName = "m";
                user.Email = "m@m.m";

                string userPWD = "P@$$w0rd";

                var chkUser = UserManager.Create(user, userPWD);

                //Add default User to Role member   
                if (chkUser.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user.Id, "Member");

                }
            }
        }
    }
}