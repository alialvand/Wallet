using System;
using System.Collections.Generic;
using System.Text;

namespace Wallet.Domain.Models
{
    public class Balance
    {
        public int ID { get; set; }

        public string Amount { get; set; }


        public string TransactionDate { get; set; }

        public string  Desc { get; set; }

        public long  Pan { get; set; }
    }
}
