using Common.Models;
using System.Net;
using System.Net.Mail;

namespace MicroService2.Services
{
    public static class EmailService
    {
        public async static Task<bool> SendEmailComplaintResponse(ComplaintResponse complaintResponse)
        {
            bool isSucces = false;

            // Create the SmtpClient
            SmtpClient Client = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential()
                {
                    UserName = "dbassignmenttwopostgres@gmail.com",
                    Password = "ddujswjsnyfrvzrg"
                }
            };

            MailAddress FromEmail = new MailAddress("dbassignmenttwopostgres@gmail.com", "ComplaintAssignment");
            MailAddress ToEmail = new MailAddress(complaintResponse.Email, "Complaint Assignment");
            MailMessage Message = new MailMessage()
            {
                From = FromEmail,
                Subject = "Auto complaint response",
                Body = complaintResponse.ComplaintMessage
            };

            Message.To.Add(ToEmail);

            try
            {
                await Client.SendMailAsync(Message);
            }
            catch (System.Exception ex)
            {
                throw;
            }
            return isSucces;
        }
    }
}
