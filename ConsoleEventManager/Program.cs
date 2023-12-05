using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEventManager
{
    class Program
    {
        static void Main(string[] args)
        {
            CosumeEventSync objsync = new CosumeEventSync();
            objsync.GetAllEventData();
//            objsync.GetAllEventData_ByEventID("2");
//            objsync.PostEvent_data();
    //        objsync.PutEvent_data(7); 
           // objsync.DeleteEvent_data(7);

        }
    }
}
