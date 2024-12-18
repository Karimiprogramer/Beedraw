﻿using BeeDraw.Core.Services.Interfaces.Wallet;
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
    public class CurrencyService(ApplicationDbContext _context) : Service<CurrencyTbl>(_context) , ICurrencyService
    {
    }
}
