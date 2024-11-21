using TabbedPageSample.Platforms.Android;

namespace TabbedPageSample;

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
                fonts.AddFont("fa_solid.ttf", "FontAwesome");
            })
            .ConfigureMauiHandlers(handlers => {
#if ANDROID
                // Add a handler
                handlers.AddHandler(typeof(TabbedPage), typeof(CustomTabbedPageHandler));
#endif
            });

        return builder.Build();
	}
}
