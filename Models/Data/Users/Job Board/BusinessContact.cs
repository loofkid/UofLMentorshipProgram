namespace UofLMentorshipProgram.Models.Data.Users
{
    public class BusinessContact : Person
    {
        public Business Business { get; set; }
        public int BusinessId { get; set; }
        public string JobTitle { get; set; }
    }
}