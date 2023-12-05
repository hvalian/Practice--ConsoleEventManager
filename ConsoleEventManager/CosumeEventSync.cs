using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace ConsoleEventManager
{
    public class CosumeEventSync
    {
        public void GetAllEventData() //Get All Events Records  
        {
            using (var client = new WebClient()) //WebClient  
            {
                client.Headers.Add("Content-Type:application/json"); //Content-Type  
                client.Headers.Add("Accept:application/json");
                var result = client.DownloadString("http://localhost:3454/api/Event"); //URI  
                Console.WriteLine(Environment.NewLine + result);
            }
        }


        public void GetAllEventData_ByEventID(string EventID) //Get All Events Records By ID  
        {
            using (var client = new WebClient()) //WebClient  
            {
                client.Headers.Add("Content-Type:application/json"); //Content-Type  
                client.Headers.Add("Accept:application/json");
                var result = client.DownloadString("http://localhost:3454/api/Event/" + EventID); //URI  
                Console.WriteLine(Environment.NewLine + result);
            }
        }

        public void PostEvent_data() //Adding Event  
        {
            using (var client = new WebClient())
            {
                EventTB objtb = new EventTB(); //Setting parameter to post  
                objtb.EventId = 0;
                objtb.EventName = "Late-Night Music";
                objtb.EventStartDate = DateTime.Now;
                objtb.EventEndDate = DateTime.Now;
                objtb.EventLocation = "Mumbai";
                client.Headers.Add("Content-Type:application/json");
                client.Headers.Add("Accept:application/json");
                var result = client.UploadString("http://localhost:3454/api/Event", JsonConvert.SerializeObject(objtb));
                Console.WriteLine(result);
            }
        }

        public void PutEvent_data(int EventID) //Update Event  
        {
            using (var client = new WebClient())
            {
                EventTB objtb = new EventTB();
                objtb.EventId = 7;
                objtb.EventName = "Late-Night Music Rocks"; //Value to Update  
                objtb.EventStartDate = DateTime.Now;
                objtb.EventEndDate = DateTime.Now;
                objtb.EventLocation = "Mumbai";
                client.Headers.Add("Content-Type:application/json");
                client.Headers.Add("Accept:application/json");
                var result = client.UploadString("http://localhost:3454/api/Event/" + EventID, "PUT", JsonConvert.SerializeObject(objtb));
                Console.WriteLine(result);
            }
        }

        public void DeleteEvent_data(int EventID) //Update Event  
        {
            using (var client = new WebClient())
            {
                client.Headers.Add("Content-Type:application/json");
                client.Headers.Add("Accept:application/json");
                var result = client.UploadString("http://localhost:3454/api/Event/" + EventID, "Delete", "");
                Console.WriteLine(result);
            }
        }


    }

}
