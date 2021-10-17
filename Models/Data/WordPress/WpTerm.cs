using System;
using System.Collections.Generic;

#nullable disable

namespace UofLMentorshipProgram.Models.Data.WordPress
{
    public partial class WpTerm
    {
        public ulong TermId { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public long TermGroup { get; set; }
    }
}
