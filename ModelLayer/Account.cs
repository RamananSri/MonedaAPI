using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class Account
    {
        [Key, ForeignKey("User")]
        public string UserId { get; set; }
        public decimal Balance { get; set; }

        //[ForeignKey("User")]
        //public int UserId { get; set; }
        public User User { get; set; }
    }
}
