using System;
using System.Collections.Generic;

#nullable disable

namespace UofLMentorshipProgram.Models.Data.WordPress
{
    public partial class WpGiveMigration
    {
        public string Id { get; set; }
        public string Status { get; set; }
        public string Error { get; set; }
        public DateTime LastRun { get; set; }
    }
}
