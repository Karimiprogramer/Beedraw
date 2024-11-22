﻿using BeeDraw.Core.Services.Interfaces.Lottery;
using BeeDraw.Database.Contexts;
using BeeDraw.Database.Models.Lottery;
using Project.Application.Core.Services.SeedWorks.Base.Implement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeDraw.Core.Services.Implementers.Lottery
{
    public class LotteryPrizeService : Service<LotteryPrizeTbl> , ILotteryPrizeService
    {
        public LotteryPrizeService(ApplicationDbContext _context) : base(_context)
        {
        }
    }
}
