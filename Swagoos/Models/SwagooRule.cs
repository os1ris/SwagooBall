using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Swagoos.Models
{
    public class SwagooRule
    {
        public Guid Id { get; set;}
        public string RuleName { get; set; }
        public string RuleExplanation { get; set; }
        public RuleType RuleTypes { get; set; }
        public int Difficulty { get; set; }
        public string WinnerGets { get; set; }
        public string LoserGets { get; set; }
    }
}
