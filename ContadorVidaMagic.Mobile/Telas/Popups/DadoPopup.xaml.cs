using Mopups.Pages;
using Mopups.Services;

namespace ContadorVidaMagic.Mobile.Telas.Popups;

public partial class DadoPopup : PopupPage
{
    private Random randomNumberDado1 = new();
    private Random randomNumberDado2 = new();

    public DadoPopup()
    {
        InitializeComponent();

        Task.Run(async () =>
        {
            var valorDado1 = randomNumberDado1.Next(1, 6);
            var valorDado2 = randomNumberDado2.Next(1, 6);

            PopularImagensDoDado(valorDado1, valorDado2);

            PopularLabels(valorDado1, valorDado2);
            
            await Task.Delay(2000);
            await MopupService.Instance.PopAsync();
        });
    }

    #region Metodos auxiliares
    private void PopularImagensDoDado(int valorDado1, int valorDado2)
    {
        switch (valorDado1)
        {
            case 1:
                imageDado1.Source = "d1";
                break;
            case 2:
                imageDado1.Source = "d2";
                break;
            case 3:
                imageDado1.Source = "d3";
                break;
            case 4:
                imageDado1.Source = "d4";
                break;
            case 5:
                imageDado1.Source = "d5";
                break;
            case 6:
                imageDado1.Source = "d6";
                break;
        }

        switch (valorDado2)
        {
            case 1:
                imageDado2.Source = "d1";
                break;
            case 2:
                imageDado2.Source = "d2";
                break;
            case 3:
                imageDado2.Source = "d3";
                break;
            case 4:
                imageDado2.Source = "d4";
                break;
            case 5:
                imageDado2.Source = "d5";
                break;
            case 6:
                imageDado2.Source = "d6";
                break;
        }
    }

    private void PopularLabels(int valorDado1, int valorDado2)
    {
        if (valorDado1 > valorDado2)
        {
            lblValorDado1.Text = "Vencedor!";
            lblValorDado1.IsVisible = true;
        }
        else if (valorDado1 < valorDado2)
        {
            lblValorDado2.Text = "Vencedor!";
            lblValorDado2.IsVisible = true;
        }
        else
        {
            lblValorDado1.Text = "Empate";
            lblValorDado2.Text = "Empate!";
            lblValorDado1.IsVisible = true;
            lblValorDado2.IsVisible = true;
        }
    } 
    #endregion
}