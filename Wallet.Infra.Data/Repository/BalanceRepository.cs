using System;
using System.Collections.Generic;
using System.Text;
using Wallet.Domain.Interfaces;
using Wallet.Domain.Models;
using Wallet.Infra.Data.Context;
using System.Linq;

namespace Wallet.Infra.Data.Repository
{
    public class BalanceRepository : IBalanceRepository
    {

        WalletDBContext _ctx;
        public BalanceRepository(WalletDBContext ctx)
        {
            _ctx = ctx;
        }

        public Balance GetBalanceByPan(long pan)
        {
            return _ctx.BalanceLog.Where(c=>c.Pan==pan).FirstOrDefault();        
        
        }

      
    }
}
