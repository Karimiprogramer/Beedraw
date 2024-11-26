using BeeDraw.Components;
using BeeDraw.Core.Services.SeedWorks.Installer;
using BeeDraw.Database.Contexts;
using Microsoft.EntityFrameworkCore;
using Telegram.Bot;

namespace BeeDraw
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddRazorComponents();
            builder.Services.AddDbContext<ApplicationDbContext>(op => op.UseSqlServer(builder.Configuration.GetConnectionString("devel")));
            builder.Services.AddBeeDrawServices();
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
