namespace VehiculosMAUI.Views;

public partial class ListaVehiculosPage : ContentPage
{

    public ListaVehiculosPage()
	{
		InitializeComponent();;
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(RegistrarVehiculoPage));
    }
}