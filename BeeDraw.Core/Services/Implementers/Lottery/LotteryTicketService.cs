using BeeDraw.Core.Services.Interfaces.Lottery;
using BeeDraw.Core.Services.SeedWorks.Base.Implement;
using BeeDraw.Database.Contexts;
using BeeDraw.Database.Models.Lottery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeDraw.Core.Services.Implementers.Lottery
{
    public class LotteryTicketService : Service<LotteryTicketTbl> , ILotteryTicketService
    {
        public LotteryTicketService(ApplicationDbContext _context) : base(_context)
        {
        }
    }
}
