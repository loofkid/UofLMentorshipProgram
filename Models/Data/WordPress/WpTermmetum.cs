using System;
using System.Collections.Generic;

#nullable disable

namespace UofLMentorshipProgram.Models.Data.WordPress
{
    public partial class WpTermmetum
    {
        public ulong MetaId { get; set; }
        public ulong TermId { get; set; }
        public string MetaKey { get; set; }
        public string MetaValue { get; set; }
    }
}
