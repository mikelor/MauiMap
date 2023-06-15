namespace MauiMap.Views;

public partial class BingMap : ContentPage
{
	public BingMap(MapViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
#if WINDOWS
		// Note that the map control is not supported on Windows.
		// For more details, see https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/map?view=net-maui-7.0
		// For a possible workaround, see https://github.com/CommunityToolkit/Maui/issues/605
		Content = new Label() { Text = "Windows does not have a map control. 😢" };
#endif
	}

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);

#if WINDOWS
        // Launch the Bing Maps app
        // For more information see: https://learn.microsoft.com/en-us/windows/uwp/launch-resume/launch-maps-app
        var uri = new Uri($"bingmaps:?collection=point.36.159535496797865_-115.15282159070674_https%3A%2F%2Ftavernacostera.com%2F&lvl=16");
        var launcherOptions = new Windows.System.LauncherOptions();
        launcherOptions.TargetApplicationPackageFamilyName = "Microsoft.WindowsMaps_8wekyb3d8bbwe";
        var success = Windows.System.Launcher.LaunchUriAsync(uri, launcherOptions);
#endif
    }
}
