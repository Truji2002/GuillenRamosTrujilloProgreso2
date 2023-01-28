using GuillenRamosTrujilloProgreso2.Data;
using GuillenRamosTrujilloProgreso2.Models;


namespace GuillenRamosTrujilloProgreso2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViajesItemPage : ContentPage
    {
        public ViajesItemPage()
        {
            InitializeComponent();
        }

        async void OnSaveClicked(object sender, EventArgs e)
        {
            var viajesItem = (ViajesCRUD)BindingContext;
            VIajesDatabase database = await VIajesDatabase.Instance;
            
            await database.SaveItemAsync(viajesItem);

            await Navigation.PopAsync();
        }

        async void OnDeleteClicked(object sender, EventArgs e)
        {
            var viajesItem = (ViajesCRUD)BindingContext;
            VIajesDatabase database = await VIajesDatabase.Instance;
            await database.DeleteItemAsync(viajesItem);
            await Navigation.PopAsync();
        }

        async void OnCancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
        
}