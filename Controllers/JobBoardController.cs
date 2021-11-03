using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UofLMentorshipProgram.Data;
using UofLMentorshipProgram.Models.Data.Users;

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

        [HttpGet("jobposting")]
        public async Task<IActionResult> GetJobPostings()
        {
            return Ok(await mentorshipContext.JobPostings.Select(p => p).ToListAsync());
        }

        [HttpPost("jobposting")]
        public async Task<IActionResult> CreateJobPosting(JobPosting jobPosting) 
        { 
            var jobPostingEntity = (await mentorshipContext.JobPostings.AddAsync(jobPosting)).Entity;
            await mentorshipContext.SaveChangesAsync();

            return CreatedAtAction(Url.Action($"jobposting/{jobPostingEntity.Id}"), jobPostingEntity);
        }

        [HttpGet("jobposting/{id}")]
        public async Task<IActionResult> GetJobPostingbyID(int id) 
        {
            return Ok(await mentorshipContext.JobPostings.FindAsync(id));
        }

        [HttpPatch("jobposting")]
        public async Task<IActionResult> UpdateJobPosting(JobPosting jobPosting)
        {
            var jobPostingEntity = mentorshipContext.JobPostings.Update(jobPosting).Entity;
            await mentorshipContext.SaveChangesAsync();

            return CreatedAtAction(Url.Action($"jobposting/{jobPostingEntity.Id}"), jobPostingEntity);
        }
    }
}