﻿using Microsoft.Extensions.Logging;
using ProsperDaily.MVVM.Models;
using ProsperDailyTests.Repositories;
using Syncfusion.Maui.Core.Hosting;

namespace ProsperDaily
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            SQLitePCL.Batteries_V2.Init();

            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureSyncfusionCore()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Roboto-Black.ttf", "Strong");
                    fonts.AddFont("LibreFranklin-Regular.ttf", "Regular");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<BaseRepository<Transaction>>();
            return builder.Build();
        }
    }
}
