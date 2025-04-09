using LanchesApp.Models;

namespace LanchesApp;

public partial class PaginaLanches : ContentPage
{
    public List<Lanche> Lanches { get; set; }

    public PaginaLanches()
    {
        InitializeComponent();
        Lanches = LancheService.ObterLanches();
        BindingContext = this;
    }


}
