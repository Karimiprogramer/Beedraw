using BeeDraw.Core.Services.Implementers.Lottery;
using BeeDraw.Core.Services.Implementers.User;
using BeeDraw.Core.Services.Implementers.Wallet;
using BeeDraw.Core.Services.Interfaces.Lottery;
using BeeDraw.Core.Services.Interfaces.User;
using BeeDraw.Core.Services.Interfaces.Wallet;
using Microsoft.Extensions.DependencyInjection;

namespace BeeDraw.Core.Services.SeedWorks.Installer;

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
            .AddScoped<IFriendshipService, FriendshipService>()

            /*Add Wallet Services*/

            .AddScoped<ICurrencyService, CurrencyService>()
            .AddScoped<IWalletBalanceService, WalletBalanceService>()
            .AddScoped<IWalletService, WalletService>();


    }
}
