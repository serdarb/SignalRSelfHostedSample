using System;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using Microsoft.Owin.Hosting;
using Owin;
using POC.Service;

namespace POC.ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://localhost:8081";

            using (WebApplication.Start<Startup>(url))
            {
                Console.WriteLine("Server running on {0}", url);
                Console.ReadLine();
            }
        }

        public class Startup
        {
            public void Configuration(IAppBuilder app)
            {
                Console.WriteLine("Configuration");
                app.MapHubs();
            }
        }

        [HubName("workhub")]
        public class WorkHub : Hub
        {
            public void DoWork(string userId, string work)
            {
                var srv = new WorkService();
                srv.DoWork(userId, work);

                Console.WriteLine(work);

                Clients.All.addMessage(work);
            }
        }
    }
}
