using BeeDraw.Core.Services.Interfaces.User;
using BeeDraw.Database.Contexts;
using BeeDraw.Database.Models.User;
using Project.Application.Core.Services.SeedWorks.Base.Implement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeDraw.Core.Services.Implementers.User
{
    public class UserService(ApplicationDbContext _context) : Service<UserTbl>(_context) , IUserService
    {
    }
}
