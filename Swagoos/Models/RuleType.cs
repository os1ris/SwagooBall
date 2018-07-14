using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Swagoos.Models
{
    public class RuleType
    {
        public bool EasyRule { get; set; }
        public bool MediumRule { get; set; }
        public bool HardRule { get; set; }
        public bool GroupDrink { get; set; }
        public bool TeamBased { get; set; }
        public bool OkAtBar { get; set; }
        public bool OkInPublic { get; set; }
        public bool PropBased { get; set; }
        public bool SoloDrink { get; set; }
    }
}
