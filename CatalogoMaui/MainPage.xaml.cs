
using CatalogoMaui.Models;
using CatalogoMaui.ViewModels;

namespace CatalogoMaui;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        BindingContext = new CatalogoViewModel();
    }

    private bool abriendoDetalle;

    private async void AlSeleccionarProducto(object? sender,
        SelectionChangedEventArgs e)
    {
        if (abriendoDetalle || e.CurrentSelection.Count == 0)
            return;

        if (sender is not CollectionView lista ||
            e.CurrentSelection[0] is not Producto producto)
            return;

        abriendoDetalle = true;

        try
        {
            lista.SelectedItem = null;

            var datos = new ShellNavigationQueryParameters
            {
                { "producto", producto }
            };

            await Shell.Current.GoToAsync("producto-detalle", datos);
        }
        finally
        {
            abriendoDetalle = false;
        }
    }
}
