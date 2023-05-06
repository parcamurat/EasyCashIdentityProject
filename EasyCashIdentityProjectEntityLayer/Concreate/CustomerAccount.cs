using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProjectEntityLayer.Concreate
{
    public class CustomerAccount
    {
        public int CustomerAccountID { get; set; }
        public int CustomerAccountNumber { get; set; }
        public int CustomerAccountCurrency { get; set;}
        public int CustomerAccountBalance { get; set; }
        public int BankBranch { get; set; }
    }
}
