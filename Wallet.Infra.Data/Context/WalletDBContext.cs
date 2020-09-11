using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Text;
using Wallet.Domain.Models;

namespace Wallet.Infra.Data.Context
{
    public class WalletDBContext:DbContext
    {

        public WalletDBContext(DbContextOptions<WalletDBContext> options) : base(options)
        {

        }


        public DbSet<Balance> BalanceLog  { get; set; }

}
}
