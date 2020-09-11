using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wallet.Core.Interfaces;
using Wallet.Domain.Models;

namespace ApiContainer.Wallet.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BalanceController : ControllerBase
    {
        IBalanceService _balanceService;
        public BalanceController(IBalanceService balanceService)
        {
            _balanceService = balanceService;
        }
        [HttpGet]
        [Route("GetBalanceByPan/{pan}")]
        public Balance GetBalanceByPan(long pan)
        {
            return _balanceService.GetBalance(pan);
        }
    }
}
