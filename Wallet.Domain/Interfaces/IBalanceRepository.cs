using System;
using System.Collections.Generic;
using System.Text;
using Wallet.Domain.Models;

namespace Wallet.Domain.Interfaces
{
    public interface IBalanceRepository
    {
        Balance GetBalanceByPan(long pan);
    }
}
