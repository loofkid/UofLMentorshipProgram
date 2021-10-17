using System.ComponentModel.DataAnnotations;
using UofLMentorshipProgram.Models.Data.Users;

namespace Models.Data.Users.Attributes
{
    public abstract class UserAttribute
    {
        public User User { get; set; }
        public int UserId { get; set; }
        public string Value { get; set; }
    }
}