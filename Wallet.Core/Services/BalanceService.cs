using System;
using System.Collections.Generic;
using System.Text;
using Wallet.Core.Interfaces;
using Wallet.Domain.Interfaces;
using Wallet.Domain.Models;

namespace Wallet.Core.Services
{
    public class BalanceService : IBalanceService
    {

        IBalanceRepository _balanceRepository;

        public BalanceService(IBalanceRepository balanceRepository)
        {
            _balanceRepository = balanceRepository;
        }

       

        public Balance GetBalance(long pan)
        {
            return _balanceRepository.GetBalanceByPan(pan);
        }
    }
}
