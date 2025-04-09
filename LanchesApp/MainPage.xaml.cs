using LanchesApp.Models;

namespace LanchesApp;

public partial class MainPage : ContentPage
{
    public List<Lanche> Lanches { get; set; }

    public MainPage()
    {
        InitializeComponent();
    }

    private void BtnLanches_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PaginaLanches());
    }

    private void BtnDoces_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PaginaDoces());
    }

    private void BtnBebidas_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PaginaBebidas());
    }
}
