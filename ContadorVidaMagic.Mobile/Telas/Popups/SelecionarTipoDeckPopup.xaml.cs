using Mopups.Pages;
using Mopups.Services;

namespace ContadorVidaMagic.Mobile.Telas.Popups;

public partial class SelecionarTipoDeckPopup : PopupPage
{
	public SelecionarTipoDeckPopup()
	{
		InitializeComponent();
	}

    private async void FecharPopupClicked(object sender, EventArgs e)
    {
        await MopupService.Instance.PopAsync();
    }

    private async void SelecionarUmClicked(object sender, EventArgs e)
    {
        await MopupService.Instance.PopAsync();
        await MopupService.Instance.PushAsync(new SelecionarTipoPopup());
    }

    private async void SelecionarDoisClicked(object sender, EventArgs e)
    {
        await MopupService.Instance.PopAsync();
        await MopupService.Instance.PushAsync(new SelecionarTipo2Popup());
    }

    private void SelecionarMaisDeTresClicked(object sender, EventArgs e)
    {
        //Passar no messaging center a cor dourada
    }
}