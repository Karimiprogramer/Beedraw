﻿using BeeDraw.Core.Services.Interfaces.User;
using BeeDraw.Core.Services.SeedWorks.Base.Implement;
using BeeDraw.Database.Contexts;
using BeeDraw.Database.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeDraw.Core.Services.Implementers.User
{
    public class TaskService(ApplicationDbContext _context) : Service<TaskTbl>(_context) , ITaskService
    {
    }
}
