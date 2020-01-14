using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyInsurance.Models
{
    public class Event
    {
        public string Description { get; set; }
        public decimal Stake { get; set; }
        public decimal Payout { get; set; }
        public DateTime Date { get; set; }
        public long InsuredId { get; set; }
    }
}
