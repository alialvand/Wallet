using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Wallet.Core.Interfaces;
using Wallet.Core.Services;
using Wallet.Domain.Interfaces;
using Wallet.Infra.Data.Repository;

namespace Wallet.Infra.Ioc
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection service)
        {
            //Application Layer
            service.AddScoped<IBalanceService, BalanceService>();


            //Infra
            service.AddScoped<IBalanceRepository, BalanceRepository>();

        }

    }
}
