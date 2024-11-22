using BeeDraw.Core.Services.Implementers.Lottery;
using BeeDraw.Core.Services.Implementers.User;
using BeeDraw.Core.Services.Interfaces.Lottery;
using BeeDraw.Core.Services.Interfaces.User;
using Microsoft.Extensions.DependencyInjection;

namespace Project.Application.Core.Services.SeedWorks.Installer;

public static class ServiceInstaller
{
    public static IServiceCollection AddBeeDrawServices(this IServiceCollection services)
    {
        return services

            /* Add Lottery Services */
            .AddScoped<ILotteryService, LotteryService>()
            .AddScoped<ILotteryTicketService, LotteryTicketService>()
            .AddScoped<ILotteryPrizeService, LotteryPrizeService>()

            /* Add User Services*/
            .AddScoped<IUserService, UserService>()
            .AddScoped<ITaskService, TaskService>()
            .AddScoped<ITaskCompletionService, TaskCompletionService>()
            .AddScoped<IFriendshipService, FriendshipService>();

            
    }
}
