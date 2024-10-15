<<<<<<< HEAD
using Android.Telecom;
=======
>>>>>>> 17c51aa3f6b48100008978a92b0dc1bf3b9144e6
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


    private void GoToCafePage(object sender, EventArgs e)
    {

        NavigationToPage(new Cafe());

        OcultarDetalles();
    }
}