using BeeDraw.Components;
using Telegram.Bot;

namespace BeeDraw
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var token = builder.Configuration["BotToken"]!;             // set your bot token in appsettings.json
            var webappUrl = builder.Configuration["BotWebAppUrl"]!;  
            
            // set your bot webapp public url in appsettings.json
            builder.Services.ConfigureTelegramBot<Microsoft.AspNetCore.Http.Json.JsonOptions>(opt => opt.SerializerOptions);
            builder.Services
                .AddHttpClient("tgwebhook")
                .RemoveAllLoggers()
                .AddTypedClient(httpClient => new TelegramBotClient(token, httpClient));
            // Add services to the container.
            builder.Services.AddRazorComponents();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<Routes>();

            app.Run();
        }
    }
}
