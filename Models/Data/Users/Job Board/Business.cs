using System;
using Models.Data.Users.Attributes;

namespace UofLMentorshipProgram.Models.Data.Users
{
    public class Business
    {
        public Business()
        {
            Services = Array.Empty<Service>();
            JobPostings = Array.Empty<JobPosting>();
            BusinessContacts = Array.Empty<BusinessContact>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public Service[] Services { get; set; }
        public JobPosting[] JobPostings { get; set; }
        public BusinessContact[] BusinessContacts { get; set; }
        
        
    }
}