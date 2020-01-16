using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyInsurance.Models.Relationships
{
    public class IndividualLife
    {
        public string Razlog { get; set; }
        public string Pusac { get; set; }
        public decimal Uplata { get; set; }
        public decimal OsiguravajucaSuma { get; set; }
    }
}
