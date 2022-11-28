using ContadorVidaMagic.Mobile.Enum;
using Mopups.Pages;
using Mopups.Services;

namespace ContadorVidaMagic.Mobile.Telas.Popups;

public partial class SelecionarTipoPopup : PopupPage
{
	public SelecionarTipoPopup()
	{
		InitializeComponent();
	}

    public SelecionarTipoPopup(bool isPlayer2)
    {
        InitializeComponent();

        if (isPlayer2)
        {
            selecionarCores.Rotation = 180;
        }
    }

    private void CorBrancoSelecionado(object sender, EventArgs e)
    {
		MessagingCenter.Send(string.Empty, "SelecionarTipoElemento1", TipoElemento.Branco);
		MopupService.Instance.PopAsync();
    }

    private void CorPretoSelecionado(object sender, EventArgs e)
    {
        MessagingCenter.Send(string.Empty, "SelecionarTipoElemento1", TipoElemento.Preto);
        MopupService.Instance.PopAsync();
    }

    private void CorVermelhoSelecionado(object sender, EventArgs e)
    {
        MessagingCenter.Send(string.Empty, "SelecionarTipoElemento1", TipoElemento.Vermelho);
        MopupService.Instance.PopAsync();
    }

    private void CorAzulSelecionado(object sender, EventArgs e)
    {
        MessagingCenter.Send(string.Empty, "SelecionarTipoElemento1", TipoElemento.Azul);
        MopupService.Instance.PopAsync();
    }

    private void CorVerdeSelecionado(object sender, EventArgs e)
    {
        MessagingCenter.Send(string.Empty, "SelecionarTipoElemento1", TipoElemento.Verde);
        MopupService.Instance.PopAsync();
    }
}