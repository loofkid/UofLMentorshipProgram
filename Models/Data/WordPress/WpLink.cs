using System;
using System.Collections.Generic;

#nullable disable

namespace UofLMentorshipProgram.Models.Data.WordPress
{
    public partial class WpLink
    {
        public ulong LinkId { get; set; }
        public string LinkUrl { get; set; }
        public string LinkName { get; set; }
        public string LinkImage { get; set; }
        public string LinkTarget { get; set; }
        public string LinkDescription { get; set; }
        public string LinkVisible { get; set; }
        public ulong LinkOwner { get; set; }
        public int LinkRating { get; set; }
        public DateTime LinkUpdated { get; set; }
        public string LinkRel { get; set; }
        public string LinkNotes { get; set; }
        public string LinkRss { get; set; }
    }
}
