﻿using System;
using System.Collections.Generic;

#nullable disable

namespace UofLMentorshipProgram.Models.Data.WordPress
{
    public partial class WpCommentmetum
    {
        public ulong MetaId { get; set; }
        public ulong CommentId { get; set; }
        public string MetaKey { get; set; }
        public string MetaValue { get; set; }
    }
}
