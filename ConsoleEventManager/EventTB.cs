using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEventManager
{
    public partial class EventTB
    {
            public int EventId { get; set; }
            public string EventName { get; set; }
            public Nullable<System.DateTime> EventStartDate { get; set; }
            public Nullable<System.DateTime> EventEndDate { get; set; }
            public string EventLocation { get; set; }
    }
}
