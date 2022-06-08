using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class Activity
    {
        public Guid Id { get; set; }
        public string Title{set;get;}
        public DateTime Date{set;get;}
        public string Description{set;get;}
        public string Category {set;get;}
        public string City{set;get;}
        public string Venue{set;get;}
        
    }
}