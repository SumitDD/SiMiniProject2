using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisLibrary.RedisConnector
{
    public static class RedisConnector
    {
        private const string RedisConnectionString = "localhost:6379";
        private const string MessageChannel = "channel";

        public static ConnectionMultiplexer GetConnection()
        {
            return ConnectionMultiplexer.Connect(RedisConnectionString);
        }
        
        


    }
}
