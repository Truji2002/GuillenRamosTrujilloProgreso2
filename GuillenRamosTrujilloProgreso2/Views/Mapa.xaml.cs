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
    Pin boardwalkPin;
    Pin wharfPin;

    void AgregarPin(object sender, EventArgs e)
    {
        double latitud = Double.Parse(Latitude.Text);
        double longitud = Double.Parse(Longitude.Text);
        

        boardwalkPin = new Pin
        {
            Location = new Location(latitud, longitud),
            Label = Label.Text,
            Address = Address.Text,
            Type = PinType.Place
        };
        boardwalkPin.MarkerClicked += OnMarkerClickedAsync;

        wharfPin = new Pin
        {
            Location = new Location(latitud, longitud),
            Label = Label.Text,
            Address = Address.Text,
            Type = PinType.Place
        };
        wharfPin.InfoWindowClicked += OnInfoWindowClickedAsync;

        map.Pins.Add(boardwalkPin);
        map.Pins.Add(wharfPin);
    }

    void EliminarPin(object sender, EventArgs e)
    {
        map.Pins.Remove(boardwalkPin);
        map.Pins.Remove(wharfPin);
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