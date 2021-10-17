using System;
using Models.Data.Users.Attributes;

namespace UofLMentorshipProgram.Models.Data.Users
{
    public class Mentee : Participant, IUofLUser
    {

        public Mentee() : base()
        {
            CISCoursesTaken = Array.Empty<CISCourseTaken>();
            CISCoursesTaking = Array.Empty<CISCourseTaking>();
            CISTracks = Array.Empty<CISTrack>();
        }
        public CISCourseTaken[] CISCoursesTaken { get; set; }
        public CISCourseTaking[] CISCoursesTaking { get; set; }
        public CISTrack[] CISTracks { get; set; }
    }
}