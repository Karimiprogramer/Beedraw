using BeeDraw.Core.Services.Interfaces.Wallet;
using BeeDraw.Core.Services.SeedWorks.Base.Implement;
using BeeDraw.Database.Contexts;
using BeeDraw.Database.Models.Wallet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeDraw.Core.Services.Implementers.Wallet
{
    public class WalletBalanceService(ApplicationDbContext _context) : Service<WalletBalanceTbl>(_context) , IWalletBalanceService    
    {
    }
}
