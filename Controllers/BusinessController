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
    public class BusinessController : ControllerBase
    {
        private readonly MentorshipContext mentorshipContext;

        public BusinessController(MentorshipContext mentorshipContext)
        {
            this.mentorshipContext = mentorshipContext;
        }

        [HttpGet("business")]
        public async Task<IActionResult> GetBusiness()
        {
            return Ok(await mentorshipContext.Businesses.Select(p => p).ToListAsync());
        }

        [HttpPost("business")]
        public async Task<IActionResult> CreateBusiness(Business business)
        {
            var businessEntity = (await mentorshipContext.Businesses.AddAsync(business)).Entity;
            await mentorshipContext.SaveChangesAsync();

            return CreatedAtAction(Url.Action($"business/{businessEntity.Id}"), businessEntity);
        }

        [HttpGet("business/{id}")]
        public async Task<IActionResult> GetBusinessbyID(int id)
        {
            return Ok(await mentorshipContext.Businesses.FindAsync(id));
        }

        [HttpPatch("business")]
        public async Task<IActionResult> UpdateBusiness(Business business)
        {
            var businessEntity = mentorshipContext.Businesses.Update(business).Entity;
            await mentorshipContext.SaveChangesAsync();

            return CreatedAtAction(Url.Action($"business/{businessEntity.Id}"), businessEntity);
        }
    }
}
