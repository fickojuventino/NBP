using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyInsurance.Models.Relationships
{
    public class IndividualTravel
    {
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        public string Destinacija { get; set; }
        public decimal OsiguravajucaSuma { get; set; }
        public string Svrha { get; set; }
        public decimal Uplata { get; set; }
    }
}
