using TrabajoGit.Pages;
namespace TrabajoGit;

public partial class Maestro : ContentPage
{
	public Maestro()
	{
		InitializeComponent();
	}
    public static void NavigationToPage(ContentPage nuevaPagina)
    {
        App.FlyoutPage.Detail.Navigation.PushAsync(nuevaPagina);
    }


    public static void OcultarDetalles()
    {
        App.FlyoutPage.IsPresented = false;
    }
    private void Programacion_Clicked(object sender, EventArgs e)
    {
        NavigationToPage(new ProgramacionPage());
        OcultarDetalles();
    }
    private void Futbol_Clicked(object sender, EventArgs e)
    {
        NavigationToPage(new Futbol());
        OcultarDetalles();
    }
}