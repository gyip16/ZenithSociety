using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenithDataLib
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }
        [DisplayName("Event Start")]
        public DateTime EventFromDateAndTime { get; set; }
        [DisplayName("Event End")]
        public DateTime EventToDateAndTime { get; set; }
        [DisplayName("Created by")]
        public string EnteredByUsername { get; set; }

        [DisplayName("Activity ID")]
        public int ActivityCategoryId { get; set; }
        [DisplayName("Activity")]
        public ActivityCategory ActivityCategory { get; set; }

        [DisplayName("Created on")]
        public DateTime CreationDate { get; set; }
        [DisplayName("Is Active")]
        public bool IsActive { get; set; }
    }
}
