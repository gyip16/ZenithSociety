using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenithDataLib.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }
        public DateTime EventFromDateAndTime { get; set; }
        public DateTime EventToDateAndTime { get; set; }
        public string EnteredByUsername { get; set; }
        
        public int ActivityCategoryId { get; set; }
        public ActivityCategory ActivityCategory { get; set; }

        public DateTime CreationDate { get; set; }
        public bool IsActive { get; set; }
    }
}
