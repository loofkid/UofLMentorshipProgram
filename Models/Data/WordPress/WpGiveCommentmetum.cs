using System;
using System.Collections.Generic;

#nullable disable

namespace UofLMentorshipProgram.Models.Data.WordPress
{
    public partial class WpGiveCommentmetum
    {
        public long MetaId { get; set; }
        public long GiveCommentId { get; set; }
        public string MetaKey { get; set; }
        public string MetaValue { get; set; }
    }
}
