using System;
using System.Collections.Generic;

#nullable disable

namespace UofLMentorshipProgram.Models.Data.WordPress
{
    public partial class WpUsermetum
    {
        public ulong UmetaId { get; set; }
        public ulong UserId { get; set; }
        public string MetaKey { get; set; }
        public string MetaValue { get; set; }
    }
}
