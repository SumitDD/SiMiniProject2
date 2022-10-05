using System;
using Common.Models;
using Dapper;
using Npgsql;
using System.Data;
using System.Threading.Tasks;

namespace MicroService2.DataAccess
{
    public class ComplaintRepository
    {
        private const string PostgresConnectionString =
            "Server=localhost;Port=5432;User Id=postgres;Password=P@ris2027!;Database=postgres;";
        private readonly IDbConnection _connection;

        public ComplaintRepository()
        {
            _connection = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=P@ris2027!;Database=postgres;");
        }

        public async Task<bool> SaveComplaint(Complaint complaint)
        {
            try
            {
                await _connection.ExecuteAsync(@"INSERT INTO complaint (email, complaintmessage) VALUES (@Email, @ComplaintMessage)",
                    new { Email = complaint.Email, ComplaintMessage = complaint.Email });

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
