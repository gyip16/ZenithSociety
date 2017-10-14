using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenithDataLib.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public DateTime EventFromDateAndTime { get; set; }
        public DateTime EventToDateAndTime { get; set; }
        public string EnteredByUsername { get; set; }
        
        public ActivityCategory ActiveCategory { get; set; }

        public DateTime CreationDate { get; set; }
        public bool IsActive { get; set; }
    }
}
