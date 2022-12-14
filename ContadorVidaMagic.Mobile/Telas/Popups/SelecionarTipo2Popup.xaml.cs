using ContadorVidaMagic.Mobile.Enum;
using Mopups.Pages;
using Mopups.Services;
using System;

namespace ContadorVidaMagic.Mobile.Telas.Popups;

public partial class SelecionarTipo2Popup : PopupPage
{
    private TipoElemento tipoElemento1 = TipoElemento.Nenhum;

    public SelecionarTipo2Popup()
    {
        InitializeComponent();
    }

    public SelecionarTipo2Popup(bool isPlayer2)
    {
        InitializeComponent();

        if (isPlayer2)
        {
            selecionarCores.Rotation = 180;
        }
    }

    private void CorBrancoSelecionado(object sender, EventArgs e)
    {
        if (tipoElemento1 == TipoElemento.Nenhum)
        {
            tipoElemento1 = TipoElemento.Branco;
            Cor1Slecionada.BackgroundColor = Color.FromArgb("#ffffd4");
            Imagem1Slecionada.Source = "icone_terreno_branco";
        }
        else
        {
            switch (tipoElemento1)
            {
                case TipoElemento.Branco:
                    MessagingCenter.Send(string.Empty, "SelecionarTipoElemento1", TipoElemento.Branco);
                    MopupService.Instance.PopAsync();
                    break;
                case TipoElemento.Azul:
                    MessagingCenter.Send(string.Empty, "SelecionarTipoElemento1", TipoElemento.Azorius);
                    MopupService.Instance.PopAsync();
                    break;
                case TipoElemento.Preto:
                    MessagingCenter.Send(string.Empty, "SelecionarTipoElemento1", TipoElemento.Orzhov);
                    MopupService.Instance.PopAsync();
                    break;
                case TipoElemento.Vermelho:
                    MessagingCenter.Send(string.Empty, "SelecionarTipoElemento1", TipoElemento.Boros);
                    MopupService.Instance.PopAsync();
                    break;
                case TipoElemento.Verde:
                    MessagingCenter.Send(string.Empty, "SelecionarTipoElemento1", TipoElemento.Selesnya);
                    MopupService.Instance.PopAsync();
                    break;
            }
        }
    }

    private void CorPretoSelecionado(object sender, EventArgs e)
    {
        if (tipoElemento1 == TipoElemento.Nenhum)
        {
            tipoElemento1 = TipoElemento.Preto;
            Cor1Slecionada.BackgroundColor = Color.FromArgb("#848484");
            Imagem1Slecionada.Source = "icone_terreno_preto";
        }
        else
        {
            switch (tipoElemento1)
            {
                case TipoElemento.Branco:
                    MessagingCenter.Send(string.Empty, "SelecionarTipoElemento1", TipoElemento.Orzhov);
                    MopupService.Instance.PopAsync();
                    break;
                case TipoElemento.Azul:
                    MessagingCenter.Send(string.Empty, "SelecionarTipoElemento1", TipoElemento.Dimir);
                    MopupService.Instance.PopAsync();
                    break;
                case TipoElemento.Preto:
                    MessagingCenter.Send(string.Empty, "SelecionarTipoElemento1", TipoElemento.Preto);
                    MopupService.Instance.PopAsync();
                    break;
                case TipoElemento.Vermelho:
                    MessagingCenter.Send(string.Empty, "SelecionarTipoElemento1", TipoElemento.Rakdos);
                    MopupService.Instance.PopAsync();
                    break;
                case TipoElemento.Verde:
                    MessagingCenter.Send(string.Empty, "SelecionarTipoElemento1", TipoElemento.Golgari);
                    MopupService.Instance.PopAsync();
                    break;
            }
        }
    }

    private void CorVermelhoSelecionado(object sender, EventArgs e)
    {
        if (tipoElemento1 == TipoElemento.Nenhum)
        {
            tipoElemento1 = TipoElemento.Vermelho;
            Cor1Slecionada.BackgroundColor = Color.FromArgb("#fa5454");
            Imagem1Slecionada.Source = "icone_terreno_vermelho";
        }
        else
        {
            switch (tipoElemento1)
            {
                case TipoElemento.Branco:
                    MessagingCenter.Send(string.Empty, "SelecionarTipoElemento1", TipoElemento.Boros);
                    MopupService.Instance.PopAsync();
                    break;
                case TipoElemento.Azul:
                    MessagingCenter.Send(string.Empty, "SelecionarTipoElemento1", TipoElemento.Izzet);
                    MopupService.Instance.PopAsync();
                    break;
                case TipoElemento.Preto:
                    MessagingCenter.Send(string.Empty, "SelecionarTipoElemento1", TipoElemento.Rakdos);
                    MopupService.Instance.PopAsync();
                    break;
                case TipoElemento.Vermelho:
                    MessagingCenter.Send(string.Empty, "SelecionarTipoElemento1", TipoElemento.Vermelho);
                    MopupService.Instance.PopAsync();
                    break;
                case TipoElemento.Verde:
                    MessagingCenter.Send(string.Empty, "SelecionarTipoElemento1", TipoElemento.Gruul);
                    MopupService.Instance.PopAsync();
                    break;
            }
        }
    }

    private void CorAzulSelecionado(object sender, EventArgs e)
    {
        if (tipoElemento1 == TipoElemento.Nenhum)
        {
            tipoElemento1 = TipoElemento.Azul;
            Cor1Slecionada.BackgroundColor = Color.FromArgb("#66c0f4");
            Imagem1Slecionada.Source = "icone_terreno_azul";
        }
        else
        {
            switch (tipoElemento1)
            {
                case TipoElemento.Branco:
                    MessagingCenter.Send(string.Empty, "SelecionarTipoElemento1", TipoElemento.Azorius);
                    MopupService.Instance.PopAsync();
                    break;
                case TipoElemento.Azul:
                    MessagingCenter.Send(string.Empty, "SelecionarTipoElemento1", TipoElemento.Azul);
                    MopupService.Instance.PopAsync();
                    break;
                case TipoElemento.Preto:
                    MessagingCenter.Send(string.Empty, "SelecionarTipoElemento1", TipoElemento.Dimir);
                    MopupService.Instance.PopAsync();
                    break;
                case TipoElemento.Vermelho:
                    MessagingCenter.Send(string.Empty, "SelecionarTipoElemento1", TipoElemento.Izzet);
                    MopupService.Instance.PopAsync();
                    break;
                case TipoElemento.Verde:
                    MessagingCenter.Send(string.Empty, "SelecionarTipoElemento1", TipoElemento.Simic);
                    MopupService.Instance.PopAsync();
                    break;
            }
        }

    }

    private void CorVerdeSelecionado(object sender, EventArgs e)
    {
        if (tipoElemento1 == TipoElemento.Nenhum)
        {
            tipoElemento1 = TipoElemento.Verde;
            Cor1Slecionada.BackgroundColor = Color.FromArgb("#27b56b");
            Imagem1Slecionada.Source = "icone_terreno_verde";
        }
        else
        {
            switch (tipoElemento1)
            {
                case TipoElemento.Branco:
                    MessagingCenter.Send(string.Empty, "SelecionarTipoElemento1", TipoElemento.Selesnya);
                    MopupService.Instance.PopAsync();
                    break;
                case TipoElemento.Azul:
                    MessagingCenter.Send(string.Empty, "SelecionarTipoElemento1", TipoElemento.Simic);
                    MopupService.Instance.PopAsync();
                    break;
                case TipoElemento.Preto:
                    MessagingCenter.Send(string.Empty, "SelecionarTipoElemento1", TipoElemento.Golgari);
                    MopupService.Instance.PopAsync();
                    break;
                case TipoElemento.Vermelho:
                    MessagingCenter.Send(string.Empty, "SelecionarTipoElemento1", TipoElemento.Gruul);
                    MopupService.Instance.PopAsync();
                    break;
                case TipoElemento.Verde:
                    MessagingCenter.Send(string.Empty, "SelecionarTipoElemento1", TipoElemento.Verde);
                    MopupService.Instance.PopAsync();
                    break;
            }
        }

    }
}