using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZenithDataLib.Models;

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

        public static List<Event> getEvents(ZenithDataLib.Models.ApplicationDbContext context)
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
    }
}