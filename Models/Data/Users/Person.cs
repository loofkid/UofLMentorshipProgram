using System;
using Models.Data.Users.Attributes;

namespace UofLMentorshipProgram.Models.Data.Users
{
    public class Person : User
    {
        public Person()
        {
            Ethnicity = Array.Empty<Ethnicity>();
            Pronouns = Array.Empty<Pronoun>();
        }
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public string EmailAddress { get; set; }

        public DateTime BirthDate { get; set; }
        
        public Ethnicity[] Ethnicity { get; set; }
        
        public string Gender { get; set; }
        
        public Pronoun[] Pronouns { get; set; }
    }
}