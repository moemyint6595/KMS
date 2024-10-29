﻿using KTVPro.Services;
using KTVPro.Shared.Services;
using Microsoft.Extensions.Logging;
using Shared.Services;
using KMS_APIAccess.Shared;

namespace KTVPro
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            // Add device-specific services used by the KTVPro.Shared project

            builder.Services.AddSingleton<IFormFactor, FormFactor>();
            builder.Services.AddScoped<GlobalVariables>();
            builder.Services.AddScoped<CommonFunctions>();
            builder.Services.AddScoped<LocalStorageService>();
            builder.Services.AddScoped<SVGService>();
            builder.Services.AddScoped<APIContext>();
            builder.Services.AddScoped<NotifierService>();

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif
            return builder.Build();
        }
    }
}
