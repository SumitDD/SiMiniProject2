using MicroService1.Models;
using Newtonsoft.Json;
using RedisLibrary.RedisConnector;

namespace MicroService1.Services
{
    public class ComplaintsService
    {
        public bool ProcessComplaint(Complaint complaint) {
            try
            {
                var connection = RedisConnector.GetConnection();
                var jsonComplaintSerialized = JsonConvert.SerializeObject(complaint);
                var pubSub = connection.GetSubscriber();
                pubSub.PublishAsync("channel", jsonComplaintSerialized);
                return true;

            }
            catch (Exception)
            {

                return false;
            }
          

        
        
        
        }


    }
}
