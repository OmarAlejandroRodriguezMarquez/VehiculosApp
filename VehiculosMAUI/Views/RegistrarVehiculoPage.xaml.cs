using VehiculosMAUI.DTOs;
using VehiculosMAUI.Services.HttpServices;

namespace VehiculosMAUI.Views;

public partial class RegistrarVehiculoPage : ContentPage
{
    private readonly IApiService apiService;

    public RegistrarVehiculoPage(IApiService apiService)
	{
		InitializeComponent();
        this.apiService = apiService;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        try
        {
            var marcas = await apiService.GetAsync<List<MarcaDTO>>("catalogos/marcas");

            pickerMarca.ItemsSource = marcas;
            pickerMarca.ItemDisplayBinding = new Binding("Marca");
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", $"No se pudieron cargar las marcas: {ex.Message}", "OK");
        }
    }
}