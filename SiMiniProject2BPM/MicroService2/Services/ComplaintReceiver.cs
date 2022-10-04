using RedisLibrary.RedisConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroService2.Services
{
    public static class ComplaintReceiver
    {
        public static void ListenToComplaint()
        {
            var connection = RedisConnector.GetConnection();
            var pubSub = connection.GetSubscriber();
            pubSub.Subscribe("channel", (channel, message)=>Console.WriteLine(message));
            Console.ReadLine();
        }

    }
}
