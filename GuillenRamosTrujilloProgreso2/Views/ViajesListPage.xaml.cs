using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuillenRamosTrujilloProgreso2.Data;
using GuillenRamosTrujilloProgreso2.Models;

namespace GuillenRamosTrujilloProgreso2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViajesListPage : ContentPage
    {
        public ViajesListPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            VIajesDatabase database = await VIajesDatabase.Instance;
            listView.ItemsSource = await database.GetItemsAsync();
        }

        async void AgregarItem(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ViajesItemPage
            {
                BindingContext = new ViajesCRUD()
            });
        }

        async void SeleccionarItem(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new ViajesItemPage
                {
                    BindingContext = e.SelectedItem as ViajesCRUD
                });
            }
        }
    }
}