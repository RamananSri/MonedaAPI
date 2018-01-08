using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class CashFlow
    {
        public int Id { get; set; }
        public double Amount { get; set; }
        public string Description { get; set; }

        //[ForeignKey("Frequency")]
        //public int FrequencyId { get; set; }
        public virtual Frequency Frequency { get; set; }

        //[ForeignKey("User")]
        //public int UserId { get; set; }
        public virtual User User { get; set; }

        //[ForeignKey("Account")]
        //public int AccountId { get; set; }
        public virtual Account Account { get; set; }
    }

}
