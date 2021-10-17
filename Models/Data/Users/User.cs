using System;

namespace UofLMentorshipProgram.Models.Data.Users
{
    public class User
    {
        public int Id { get; set; }
        
        public int WordPressId { get; set; }
        public Photo Photo { get; set; }
    }
}