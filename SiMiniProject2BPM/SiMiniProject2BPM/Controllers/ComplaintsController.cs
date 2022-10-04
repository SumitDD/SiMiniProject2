using MicroService1.Models;
using MicroService1.Services;
using Microsoft.AspNetCore.Mvc;

namespace SiMiniProject2BPM.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ComplaintsController : ControllerBase
    {
        private readonly ComplaintsService _complaintsService;

        public ComplaintsController(ComplaintsService complaintsService)
        {
            _complaintsService = complaintsService; 
        }

        [HttpPost]
        public bool Post(Complaint complaint)
        {

            return _complaintsService.ProcessComplaint(complaint);
        }
    }
}