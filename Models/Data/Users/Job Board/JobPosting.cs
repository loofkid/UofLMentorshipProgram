using System;

namespace UofLMentorshipProgram.Models.Data.Users
{
    public class JobPosting
    {
        public JobPosting()
        {
            Open = true;
        }
        public int Id { get; set; }
        public Business Business { get; set; }
        public int BusinessId { get; set; }
        public string JobTitle { get; set; }
        
        public string JobDescription { get; set; }
        
        public string JobType { get; set; }
        public decimal Pay { get; set; }
        
        
        
        public string Industry { get; set; }
        
        public string Function { get; set; }
        
        public string City { get; set; }
        
        public string State { get; set; }
        
        public DateTime OpenDate { get; set; }
        public DateTime? CloseDate { get; set; }
        public DateTime? StartDate { get; set; }
        public bool Open { get; set; }
    }
}