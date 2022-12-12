namespace GuillenRamosTrujilloProgreso2.Views;

public partial class ViajesSL : ContentPage
{
	public ViajesSL()
	{
		InitializeComponent();
        BindingContext = new Models.ViajesSL();
    }

    protected override void OnAppearing()
    {
        ((Models.ViajesSL)BindingContext).LoadViajes();
    }
}