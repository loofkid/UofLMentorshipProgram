using System;
using System.Collections.Generic;

#nullable disable

namespace UofLMentorshipProgram.Models.Data.WordPress
{
    public partial class WpGiveSession
    {
        public ulong SessionId { get; set; }
        public string SessionKey { get; set; }
        public string SessionValue { get; set; }
        public ulong SessionExpiry { get; set; }
    }
}
