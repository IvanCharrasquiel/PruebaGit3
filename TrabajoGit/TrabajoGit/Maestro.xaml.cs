using Android.Telecom;
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

    private void GoToPaisesPage(object sender, EventArgs e)
    {

        NavigationToPage(new Paises());

        OcultarDetalles();
    }


}