using Models.Data.Users.Attributes;

namespace UofLMentorshipProgram.Models.Data.Users
{
    public interface IUofLUser
    {
        public CISCourseTaken[] CISCoursesTaken { get; set; }
        public CISCourseTaking[] CISCoursesTaking { get; set; }
        public CISTrack[] CISTracks { get; set; }
    }
}