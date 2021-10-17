using System;
using System.Collections.Generic;

#nullable disable

namespace UofLMentorshipProgram.Models.Data.WordPress
{
    public partial class WpTermRelationship
    {
        public ulong ObjectId { get; set; }
        public ulong TermTaxonomyId { get; set; }
        public int TermOrder { get; set; }
    }
}
