using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class User
    { 
        [Key]
        public string Username { get; set; }
        public string Password { get; set; }
        public virtual List<Account> Accounts { get; set; }
    }
}
