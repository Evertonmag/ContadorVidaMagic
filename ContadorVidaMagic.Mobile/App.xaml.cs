using ContadorVidaMagic.Mobile.Telas;

namespace ContadorVidaMagic.Mobile;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new ContVida();
	}
}
