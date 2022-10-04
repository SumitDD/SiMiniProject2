using Common.Models;
using Newtonsoft.Json;
using RedisLibrary.RedisConnector;

namespace MicroService2.Services
{
    public static class ComplaintReceiver
    {
        public static void ListenToComplaint()
        {
            var connection = RedisConnector.GetConnection();
            var pubSub = connection.GetSubscriber();
            pubSub.Subscribe("channel", async (channel, message)=> {
                Console.WriteLine(message);
                var deserializedComplaint = JsonConvert.DeserializeObject<Complaint>(message);

                // send email
                await EmailService.SendEmailComplaintResponse(new ComplaintResponse { Email = deserializedComplaint.Email});
            });

            Console.ReadLine();
        }

    }
}
