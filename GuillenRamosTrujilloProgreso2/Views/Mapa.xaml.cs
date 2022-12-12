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
}