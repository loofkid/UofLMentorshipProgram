using System;
using System.Collections.Generic;

#nullable disable

namespace UofLMentorshipProgram.Models.Data.WordPress
{
    public partial class WpGiveDonationmetum
    {
        public long MetaId { get; set; }
        public long DonationId { get; set; }
        public string MetaKey { get; set; }
        public string MetaValue { get; set; }
    }
}
