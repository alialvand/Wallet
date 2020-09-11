using System;
using System.Collections.Generic;
using System.Text;
using Wallet.Domain.Models;

namespace Wallet.Core.Interfaces
{
    public interface IBalanceService
    {
        Balance GetBalance(long pan);
    }
}
