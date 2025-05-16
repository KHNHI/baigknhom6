using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace bai2giuaki.Models
{
    internal class BankAccount
    {
        [Key]
        public int account_id { get; set; }
        [Required]
        public string owner_name { get; set; }
        [Required]
        public string owner_address { get; set; }
        [Required]
        public string owner_phone { get; set; }
        [Required]
        public double balance { get; set; }
        [Required]
        public string acount_type { get; set; }
        [Required]
        public string password { get; set; }
        public virtual ICollection<Transaction> transaction { get; set; }
    }
}
