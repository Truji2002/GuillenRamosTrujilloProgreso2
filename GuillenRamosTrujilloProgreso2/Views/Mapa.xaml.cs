using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;

namespace GuillenRamosTrujilloProgreso2.Views;

public partial class Mapa : ContentPage
{


    public Mapa()
	{
        InitializeComponent();
    }

    void OnButtonClicked(object sender, EventArgs e)
    {
        Button button = sender as Button;
        switch (button.Text)
        {
            case "Street":
                map.MapType = MapType.Street;
                break;
            case "Satellite":
                map.MapType = MapType.Satellite;
                break;
            case "Hybrid":
                map.MapType = MapType.Hybrid;
                break;
        }
    }

    void AgregarPin(object sender, EventArgs e)
    {
        double latitud = Double.Parse(Latitude.Text);
        double longitud = Double.Parse(Longitude.Text);
        //string direccion = Address.Text;

        Pin boardwalkPin = new Pin
        {
            Location = new Location(latitud, longitud),
            Label = "",
            Address = "",
            Type = PinType.Place
        };
        boardwalkPin.MarkerClicked += OnMarkerClickedAsync;

        Pin wharfPin = new Pin
        {
            Location = new Location(36.9571571, -122.0173544),
            Label = "Wharf",
            Address = "Santa Cruz",
            Type = PinType.Place
        };
        wharfPin.InfoWindowClicked += OnInfoWindowClickedAsync;

        map.Pins.Add(boardwalkPin);
        map.Pins.Add(wharfPin);
    }

    async void OnMarkerClickedAsync(object sender, PinClickedEventArgs e)
    {
        e.HideInfoWindow = true;
        string pinName = ((Pin)sender).Label;
        await DisplayAlert("Pin Clicked", $"{pinName} was clicked.", "Ok");
    }

    async void OnInfoWindowClickedAsync(object sender, PinClickedEventArgs e)
    {
        string pinName = ((Pin)sender).Label;
        await DisplayAlert("Info Window Clicked", $"The info window was clicked for {pinName}.", "Ok");
    }
}