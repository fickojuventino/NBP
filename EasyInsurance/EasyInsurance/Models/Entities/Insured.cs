using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyInsurance.Models
{
    public class Insured
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long Identifier { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string CreditCard { get; set; }
        public string PhoneNumber { get; set; }
        public string MailAddress { get; set; }
    }
}
