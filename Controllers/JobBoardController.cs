using Microsoft.AspNetCore.Mvc;
using UofLMentorshipProgram.Data;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobBoardController : ControllerBase
    {
        private readonly MentorshipContext mentorshipContext;

        public JobBoardController(MentorshipContext mentorshipContext)
        {
            this.mentorshipContext = mentorshipContext;
        }
    }
}