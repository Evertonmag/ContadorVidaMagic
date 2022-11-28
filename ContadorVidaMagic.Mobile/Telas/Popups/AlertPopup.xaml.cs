using Mopups.Pages;
using Mopups.Services;

namespace ContadorVidaMagic.Mobile.Telas.Popups;

public partial class AlertPopup : PopupPage
{
	public AlertPopup()
	{
		InitializeComponent();
	}

    public AlertPopup(string tituloMensagem, string corpoMensagem)
    {
        InitializeComponent();
        labelTituloMensagem.Text = tituloMensagem;
        labelCorpoMensagem.Text = corpoMensagem;
    }

    private async void FecharPopupClicked(object sender, System.EventArgs e)
    {
        await MopupService.Instance.PopAsync();
    }
}