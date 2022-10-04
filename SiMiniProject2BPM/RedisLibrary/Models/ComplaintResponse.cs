using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class ComplaintResponse
    {
        public string Email { get; set; }
        public string ComplaintMessage { get; set; } = "We have succesfully recieved your message";
    }
}
