using System;
using System.Collections.Generic;

#nullable disable

namespace UofLMentorshipProgram.Models.Data.WordPress
{
    public partial class WpGiveComment
    {
        public long CommentId { get; set; }
        public long UserId { get; set; }
        public string CommentContent { get; set; }
        public string CommentParent { get; set; }
        public string CommentType { get; set; }
        public DateTime CommentDate { get; set; }
        public DateTime CommentDateGmt { get; set; }
    }
}
