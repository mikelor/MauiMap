
using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;
using static System.Net.WebRequestMethods;

namespace MauiMap.Views;

public partial class EmbeddedMap : ContentPage
{
	public EmbeddedMap(MapViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);

        Location location = new Location(36.159535496797865, -115.15282159070674);
        TheMap.MoveToRegion(new MapSpan(location, location.Latitude, location.Longitude));
        TheMap.Pins.Add(new Pin
        {
            Label = $"Tech Alley",
            Address = $"Tech Alley 3rd Saturday",
            Type = PinType.Place,
            Location = location
        });
    }
}
