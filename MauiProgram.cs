using Microsoft.Extensions.Logging;

namespace TDMPW_3P_EX
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
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("CaviarDreams.ttf", "Caviar");
                    fonts.AddFont("CaviarDreams_Bold.ttf", "CaviarBold");
                    fonts.AddFont("CaviarDreams_Italic.ttf", "CaviarItalic");
                    fonts.AddFont("CHICKEN Pie.ttf", "Pie");
                    fonts.AddFont("CHICKEN Pie Height.ttf", "PieHeight");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
