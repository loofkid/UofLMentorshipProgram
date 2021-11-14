using System;
using Models.Data.Users.Attributes;

namespace UofLMentorshipProgram.Models.Data.Users
{
    public class Participant : Person
    {
        public Participant() : base()
        {
            NationalOrigin = Array.Empty<NationalOrigin>();
        }
        public NationalOrigin[] NationalOrigin { get; set; }
        public Hobby[] Hobbies { get; set; }
        
        
    }
}