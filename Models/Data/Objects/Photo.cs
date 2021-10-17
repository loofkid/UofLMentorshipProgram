namespace UofLMentorshipProgram.Models.Data.Users
{
    public class Photo
    {
        public int Id { get; set; }
        
        public User User { get; set; }
        public int UserId { get; set; }
        
        public byte[] Data { get; set; }
        
        public string Url { get; set; }
    }
}