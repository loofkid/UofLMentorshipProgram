using System;
using System.Collections.Generic;

#nullable disable

namespace UofLMentorshipProgram.Models.Data.WordPress
{
    public partial class WpGiveRevenue
    {
        public ulong Id { get; set; }
        public ulong DonationId { get; set; }
        public ulong FormId { get; set; }
        public uint Amount { get; set; }
    }
}
