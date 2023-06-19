namespace MauiMap.Views;

public partial class MapSuiMap : ContentPage
{
	public MapSuiMap(MapViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;

        var mapControl = new Mapsui.UI.Maui.MapControl();
        mapControl.Map?.Layers.Add(Mapsui.Tiling.OpenStreetMap.CreateTileLayer());
        Content = mapControl;
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }
}
