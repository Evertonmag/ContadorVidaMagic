using Mopups.Pages;
using Mopups.Services;

namespace ContadorVidaMagic.Mobile.Telas.Popups;

public partial class ConfiguracaoPopup : PopupPage
{
    public ConfiguracaoPopup()
    {
        InitializeComponent();
    }

    private async void FecharPopupClicked(object sender, EventArgs e)
    {
        MessagingCenter.Send<string, int>(string.Empty, "TrocarQuantiaVida", 20);

        await MopupService.Instance.PopAsync();
    }

    private async void TrocarMinimoVidaClicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(ValorVida.Text))
        {
            if (int.TryParse(ValorVida.Text, out int valorInformado))
            {
                if (valorInformado <= 0)
                {
                    await MopupService.Instance.PushAsync(new AlertPopup("Aviso", $"O valor informado não é valido."));
                    return;
                }

                MessagingCenter.Send<string, int>(string.Empty, "TrocarQuantiaVida", valorInformado);

                await MopupService.Instance.PopAsync();
            }
            else
                await MopupService.Instance.PushAsync(new AlertPopup("Aviso", $"O valor informado não é valido."));
        }
        else
            await MopupService.Instance.PushAsync(new AlertPopup("Aviso", $"Insira algum valor."));
    }
}