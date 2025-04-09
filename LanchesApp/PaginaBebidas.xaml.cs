using LanchesApp.Models;

namespace LanchesApp;

public partial class PaginaBebidas : ContentPage
{
	public List<Bebida> Bebidas { get; set; }
	public PaginaBebidas()
	{
		InitializeComponent();
		Bebidas = BebidaService.ObterBebida();
		BindingContext = this;
	}
}