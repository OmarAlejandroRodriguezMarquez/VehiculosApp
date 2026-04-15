using VehiculosMAUI.Views.Catalogos;

namespace VehiculosMAUI.Views;

public partial class CatalogosPage : ContentPage
{
	public CatalogosPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(CatMarcaPage));
    }
}