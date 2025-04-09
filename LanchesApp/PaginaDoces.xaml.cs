using LanchesApp.Models;

namespace LanchesApp;

public partial class PaginaDoces : ContentPage
{
	public List<Doce> Doces { get; set; }

	public PaginaDoces()
	{
		InitializeComponent();
		Doces = DoceService.ObterDoces();
		BindingContext = this;
	}
}