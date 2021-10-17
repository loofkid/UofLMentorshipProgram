using System;
using System.Collections.Generic;

#nullable disable

namespace UofLMentorshipProgram.Models.Data.WordPress
{
    public partial class WpOption
    {
        public ulong OptionId { get; set; }
        public string OptionName { get; set; }
        public string OptionValue { get; set; }
        public string Autoload { get; set; }
    }
}
