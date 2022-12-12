namespace GuillenRamosTrujilloProgreso2.Views;

public partial class AllViajes : ContentPage
{
	public AllViajes()
	{
		InitializeComponent();

        BindingContext = new Models.AllViajes();
    }

    protected override void OnAppearing()
    {
        ((Models.AllViajes)BindingContext).LoadViajes();
    }

    private async void Add_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Views.Viaje));
    }

    private async void viajesCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.Count != 0)
        {
            // Get the note model
            var viaje = (Models.Viaje)e.CurrentSelection[0];

            // Should navigate to "NotePage?ItemId=path\on\device\XYZ.notes.txt"
            await Shell.Current.GoToAsync($"{nameof(Viaje)}?{nameof(Viaje.ItemId)}={viaje.Filename}");

            // Unselect the UI
            viajesCollection.SelectedItem = null;
        }
    }
}