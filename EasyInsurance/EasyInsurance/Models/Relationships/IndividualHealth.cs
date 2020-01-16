using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyInsurance.Models.Relationships
{
    public class IndividualHealth
    {
        public decimal Uplata { get; set; }
        public decimal Isplata { get; set; }
        public string Vanbolnicko { get; set; }
        public string Bolnicko { get; set; }
    }
}
