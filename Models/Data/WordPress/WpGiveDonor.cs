using System;
using System.Collections.Generic;

#nullable disable

namespace UofLMentorshipProgram.Models.Data.WordPress
{
    public partial class WpGiveDonor
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string PurchaseValue { get; set; }
        public long PurchaseCount { get; set; }
        public string PaymentIds { get; set; }
        public DateTime DateCreated { get; set; }
        public string Token { get; set; }
        public string VerifyKey { get; set; }
        public DateTime VerifyThrottle { get; set; }
    }
}
