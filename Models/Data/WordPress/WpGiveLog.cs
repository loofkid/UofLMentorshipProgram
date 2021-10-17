using System;
using System.Collections.Generic;

#nullable disable

namespace UofLMentorshipProgram.Models.Data.WordPress
{
    public partial class WpGiveLog
    {
        public ulong Id { get; set; }
        public string LogType { get; set; }
        public string Data { get; set; }
        public string Category { get; set; }
        public string Source { get; set; }
        public DateTime Date { get; set; }
    }
}
