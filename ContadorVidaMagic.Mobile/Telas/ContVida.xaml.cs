using ContadorVidaMagic.Mobile.Enum;
using ContadorVidaMagic.Mobile.Telas.Popups;
using Mopups.Services;

namespace ContadorVidaMagic.Mobile.Telas;

public partial class ContVida : ContentPage
{
    #region Propriedades

    #region Jogador1
    private TipoContador tipoContador1 = TipoContador.Vida;
    private TipoElemento tipoElemento1 = TipoElemento.Preto;
    private int ContadorVida1 { get; set; } = 20;
    private int ContadorVeneno1 { get; set; } = 0;
    private int ContadorEnergy1 { get; set; } = 0;
    private int ContadorCommander1 { get; set; } = 0;
    private int ContadorPlanesWalker1 { get; set; } = 0;
    #endregion

    #region Jogador2
    private TipoContador tipoContador2 = TipoContador.Vida;
    private TipoElemento tipoElemento2 = TipoElemento.Branco;
    private int ContadorVida2 { get; set; } = 20;
    private int ContadorVeneno2 { get; set; } = 0;
    private int ContadorEnergy2 { get; set; } = 0;
    private int ContadorCommander2 { get; set; } = 0;
    private int ContadorPlanesWalker2 { get; set; } = 0;
    #endregion

    #endregion

    public ContVida()
    {
        InitializeComponent();

        tipoContador1 = TipoContador.Vida;
        tipoContador2 = TipoContador.Vida;

        Contador1.Text = ContadorVida1.ToString();
        Contador2.Text = ContadorVida2.ToString();
    }

    #region Jogador1
    private void BtnAdicionar1(object sender, EventArgs e)
    {
        switch (tipoContador1)
        {
            case TipoContador.Vida:
                ContadorVida1 += 1;
                Contador1.Text = ContadorVida1.ToString();
                if (ContadorVida1 <= 0)
                    MensagemRIP1.IsVisible = true;
                else
                    MensagemRIP1.IsVisible = false;
                break;
            case TipoContador.Veneno:
                ContadorVeneno1 += 1;
                Contador1.Text = ContadorVeneno1.ToString();
                if (ContadorVeneno1 >= 10)
                    MensagemRIP1.IsVisible = true;
                else
                    MensagemRIP1.IsVisible = false;
                break;
            case TipoContador.Energy:
                ContadorEnergy1 += 1;
                Contador1.Text = ContadorEnergy1.ToString();
                break;
            case TipoContador.Commander:
                ContadorCommander1 += 1;
                Contador1.Text = ContadorCommander1.ToString();
                break;
            case TipoContador.PlanesWalker:
                ContadorPlanesWalker1 += 1;
                Contador1.Text = ContadorPlanesWalker1.ToString();
                break;
            default:
                break;
        }
    }

    private void BtnRemover1(object sender, EventArgs e)
    {
        switch (tipoContador1)
        {
            case TipoContador.Vida:
                ContadorVida1 -= 1;
                Contador1.Text = ContadorVida1.ToString();
                if (ContadorVida1 <= 0)
                    MensagemRIP1.IsVisible = true;
                else
                    MensagemRIP1.IsVisible = false;
                break;
            case TipoContador.Veneno:
                if (ContadorVeneno1 != 0)
                {
                    ContadorVeneno1 -= 1;
                    Contador1.Text = ContadorVeneno1.ToString();
                    if (ContadorVeneno1 >= 10)
                        MensagemRIP1.IsVisible = true;
                    else
                        MensagemRIP1.IsVisible = false;
                }
                break;
            case TipoContador.Energy:
                if (ContadorEnergy1 != 0)
                {
                    ContadorEnergy1 -= 1;
                    Contador1.Text = ContadorEnergy1.ToString();
                }
                break;
            case TipoContador.Commander:
                ContadorCommander1 -= 1;
                Contador1.Text = ContadorCommander1.ToString();
                break;
            case TipoContador.PlanesWalker:
                ContadorPlanesWalker1 -= 1;
                Contador1.Text = ContadorPlanesWalker1.ToString();
                break;
            default:
                break;
        }
    }

    private void BtnAcionarVeneno1(object sender, EventArgs e)
    {
        Contador1.Text = ContadorVeneno1.ToString();
        tipoContador1 = TipoContador.Veneno;
        FrameInvisivel1();
        if (tipoElemento1 == TipoElemento.Branco)
        {
            Contador1.TextColor = Color.FromArgb("#000000");
            FrameVeneno1.BorderColor = Color.FromArgb("#000000");
        }
        else
        {
            Contador1.TextColor = Color.FromArgb("#FFFFFF");
            FrameVeneno1.BorderColor = Color.FromArgb("#FFFFFF");
        }
        if (ContadorVeneno1 >= 10)
            MensagemRIP1.IsVisible = true;
        else
            MensagemRIP1.IsVisible = false;
    }

    private void BtnAcionarVida1(object sender, EventArgs e)
    {
        Contador1.Text = ContadorVida1.ToString();
        tipoContador1 = TipoContador.Vida;
        FrameInvisivel1();
        if (tipoElemento1 == TipoElemento.Branco)
        {
            Contador1.TextColor = Color.FromArgb("#000000");
            FrameCoracao1.BorderColor = Color.FromArgb("#000000");
        }
        else
        {
            Contador1.TextColor = Color.FromArgb("#FFFFFF");
            FrameCoracao1.BorderColor = Color.FromArgb("#FFFFFF");
        }
        if (ContadorVida1 <= 0)
            MensagemRIP1.IsVisible = true;
        else
            MensagemRIP1.IsVisible = false;
    }

    private void BtnacionarEnergy1(object sender, EventArgs e)
    {
        Contador1.Text = ContadorEnergy1.ToString();
        tipoContador1 = TipoContador.Energy;
        FrameInvisivel1();
        if (tipoElemento1 == TipoElemento.Branco)
        {
            Contador1.TextColor = Color.FromArgb("#000000");
            FrameRaio1.BorderColor = Color.FromArgb("#000000");
        }
        else
        {
            Contador1.TextColor = Color.FromArgb("#FFFFFF");
            FrameRaio1.BorderColor = Color.FromArgb("#FFFFFF");
        }
    }

    private void BtnAcionarCommander1(object sender, EventArgs e)
    {
        Contador1.Text = ContadorCommander1.ToString();
        tipoContador1 = TipoContador.Commander;
        FrameInvisivel1();
        if (tipoElemento1 == TipoElemento.Branco)
        {
            Contador1.TextColor = Color.FromArgb("#000000");
            FrameCommander1.BorderColor = Color.FromArgb("#000000");
        }
        else
        {
            Contador1.TextColor = Color.FromArgb("#FFFFFF");
            FrameCommander1.BorderColor = Color.FromArgb("#FFFFFF");
        }
    }

    private void BtnAcionarPlanesWalker1(object sender, EventArgs e)
    {
        Contador1.Text = ContadorPlanesWalker1.ToString();
        tipoContador1 = TipoContador.PlanesWalker;
        FrameInvisivel1();
        if (tipoElemento1 == TipoElemento.Branco)
        {
            Contador1.TextColor = Color.FromArgb("#000000");
            FramePlanesWalker1.BorderColor = Color.FromArgb("#000000");
        }
        else
        {
            Contador1.TextColor = Color.FromArgb("#FFFFFF");
            FramePlanesWalker1.BorderColor = Color.FromArgb("#FFFFFF");
        }
    }

    private async void BtnSelecionarTipo1(object sender, TappedEventArgs e)
    {
        if (MopupService.Instance.PopupStack.Count <= 0)
        {
            await MopupService.Instance.PushAsync(new SelecionarTipoPopup());

            MessagingCenter.Subscribe<string, TipoElemento>(string.Empty, "SelecionarTipoElemento1", (sender, args) =>
            {
                FrameInvisivel1();
                switch (args)
                {
                    case TipoElemento.Azul:
                        tipoElemento1 = TipoElemento.Azul;
                        Player1Color1.Color = Color.FromArgb("#5aa7d6");
                        Player1Color2.Color = Color.FromArgb("#1085cc");
                        Player1Color3.Color = Color.FromArgb("#000080");
                        break;
                    case TipoElemento.Branco:
                        tipoElemento1 = TipoElemento.Branco;
                        Player1Color1.Color = Color.FromArgb("#f3f5f2");
                        Player1Color2.Color = Color.FromArgb("#e3d1b3");
                        Player1Color3.Color = Color.FromArgb("#dbb177");
                        break;
                    case TipoElemento.Preto:
                        tipoElemento1 = TipoElemento.Preto;
                        Player1Color1.Color = Color.FromArgb("#716974");
                        Player1Color2.Color = Color.FromArgb("#1c1b21");
                        Player1Color3.Color = Color.FromArgb("#090a0c");
                        break;
                    case TipoElemento.Verde:
                        tipoElemento1 = TipoElemento.Verde;
                        Player1Color1.Color = Color.FromArgb("#afd214");
                        Player1Color2.Color = Color.FromArgb("#7fba08");
                        Player1Color3.Color = Color.FromArgb("#3d630a");
                        break;
                    case TipoElemento.Vermelho:
                        tipoElemento1 = TipoElemento.Vermelho;
                        Player1Color1.Color = Color.FromArgb("#cd7744");
                        Player1Color2.Color = Color.FromArgb("#b62c19");
                        Player1Color3.Color = Color.FromArgb("#791b19");
                        break;
                    default:
                        break;
                }
                if (tipoElemento1 == TipoElemento.Branco)
                {
                    Contador1.TextColor = Color.FromArgb("#000000");
                    MensagemRIP1.TextColor = Color.FromArgb("#000000");
                    FrameCoracao1.BorderColor = Color.FromArgb("#000000");
                    SelecionarTipoImg1.Source = "selecionar_tipo_black";
                    btnAdicionar1.Source = "icone_adicionar_black";
                    btnDiminuir1.Source = "icone_reduzir_black";
                    Coracao1.Source = "heart_black";
                    Raio1.Source = "lightning_black";
                    veneno1.Source = "veneno_black";
                    Commander1.Source = "commander_black";
                    PlanesWalker1.Source = "planeswalker_black";
                }
                else
                {
                    Contador1.TextColor = Color.FromArgb("#FFFFFF");
                    MensagemRIP1.TextColor = Color.FromArgb("#FFFFFF");
                    FrameCoracao1.BorderColor = Color.FromArgb("#FFFFFF");
                    btnAdicionar1.Source = "icone_adicionar_white";
                    btnDiminuir1.Source = "icone_reduzir_white";
                    SelecionarTipoImg1.Source = "selecionar_tipo_white";
                    Coracao1.Source = "heart_white";
                    Raio1.Source = "lightning_white";
                    veneno1.Source = "veneno_white";
                    Commander1.Source = "commander_white";
                    PlanesWalker1.Source = "planeswalker_white";
                }

                Contador1.Text = ContadorVida1.ToString();
                tipoContador1 = TipoContador.Vida;

                MessagingCenter.Unsubscribe<string, TipoElemento>(string.Empty, "SelecionarTipoElemento1");
            });
        }
    }

    private void FrameInvisivel1()
    {
        FrameCoracao1.BorderColor = Color.FromArgb("#00FFFFFF");
        FrameVeneno1.BorderColor = Color.FromArgb("#00FFFFFF");
        FrameRaio1.BorderColor = Color.FromArgb("#00FFFFFF");
        FrameCommander1.BorderColor = Color.FromArgb("#00FFFFFF");
        FramePlanesWalker1.BorderColor = Color.FromArgb("#00FFFFFF");
    }
    #endregion

    #region Jogador2
    private void BtnAdicionar2(object sender, EventArgs e)
    {
        switch (tipoContador2)
        {
            case TipoContador.Vida:
                ContadorVida2 += 1;
                Contador2.Text = ContadorVida2.ToString();
                if (ContadorVida2 <= 0)
                    MensagemRIP2.IsVisible = true;
                else
                    MensagemRIP2.IsVisible = false;
                break;
            case TipoContador.Veneno:
                ContadorVeneno2 += 1;
                Contador2.Text = ContadorVeneno2.ToString();
                if (ContadorVeneno2 >= 10)
                    MensagemRIP2.IsVisible = true;
                else
                    MensagemRIP2.IsVisible = false;
                break;
            case TipoContador.Energy:
                ContadorEnergy2 += 1;
                Contador2.Text = ContadorEnergy2.ToString();
                break;
            case TipoContador.Commander:
                ContadorCommander2 += 1;
                Contador2.Text = ContadorCommander2.ToString();
                break;
            case TipoContador.PlanesWalker:
                ContadorPlanesWalker2 += 1;
                Contador2.Text = ContadorPlanesWalker2.ToString();
                break;
            default:
                break;
        }
    }

    private void BtnRemover2(object sender, EventArgs e)
    {
        switch (tipoContador2)
        {
            case TipoContador.Vida:
                ContadorVida2 -= 1;
                Contador2.Text = ContadorVida2.ToString();
                if (ContadorVida2 <= 0)
                    MensagemRIP2.IsVisible = true;
                else
                    MensagemRIP2.IsVisible = false;
                break;
            case TipoContador.Veneno:
                if (ContadorVeneno2 != 0)
                {
                    ContadorVeneno2 -= 1;
                    Contador2.Text = ContadorVeneno2.ToString();
                    if (ContadorVeneno2 >= 10)
                        MensagemRIP2.IsVisible = true;
                    else
                        MensagemRIP2.IsVisible = false;
                }
                break;
            case TipoContador.Energy:
                if (ContadorEnergy2 != 0)
                {
                    ContadorEnergy2 -= 1;
                    Contador2.Text = ContadorEnergy2.ToString();
                }
                break;
            case TipoContador.Commander:
                ContadorCommander2 -= 1;
                Contador2.Text = ContadorCommander2.ToString();
                break;
            case TipoContador.PlanesWalker:
                ContadorPlanesWalker2 -= 1;
                Contador2.Text = ContadorPlanesWalker2.ToString();
                break;
            default:
                break;
        }
    }

    private void BtnAcionarVeneno2(object sender, EventArgs e)
    {
        Contador2.Text = ContadorVeneno2.ToString();
        tipoContador2 = TipoContador.Veneno;
        FrameInvisivel2();
        if (tipoElemento2 == TipoElemento.Branco)
        {
            Contador2.TextColor = Color.FromArgb("#000000");
            FrameVeneno2.BorderColor = Color.FromArgb("#000000");
        }
        else
        {
            Contador2.TextColor = Color.FromArgb("#FFFFFF");
            FrameVeneno2.BorderColor = Color.FromArgb("#FFFFFF");
        }
        if (ContadorVeneno2 >= 10)
            MensagemRIP2.IsVisible = true;
        else
            MensagemRIP2.IsVisible = false;
    }

    private void BtnAcionarVida2(object sender, EventArgs e)
    {
        Contador2.Text = ContadorVida2.ToString();
        tipoContador2 = TipoContador.Vida;
        FrameInvisivel2();
        if (tipoElemento2 == TipoElemento.Branco)
        {
            Contador2.TextColor = Color.FromArgb("#000000");
            FrameCoracao2.BorderColor = Color.FromArgb("#000000");
        }
        else
            Contador2.TextColor = Color.FromArgb("#FFFFFF");
        if (ContadorVida2 <= 0)
            MensagemRIP2.IsVisible = true;
        else
            MensagemRIP2.IsVisible = false;
    }

    private void BtnacionarEnergy2(object sender, EventArgs e)
    {
        Contador2.Text = ContadorEnergy2.ToString();
        tipoContador2 = TipoContador.Energy;
        FrameInvisivel2();
        if (tipoElemento2 == TipoElemento.Branco)
        {
            Contador2.TextColor = Color.FromArgb("#000000");
            FrameRaio2.BorderColor = Color.FromArgb("#000000");
        }
        else
        {
            Contador2.TextColor = Color.FromArgb("#FFFFFF");
            FrameRaio2.BorderColor = Color.FromArgb("#FFFFFF");
        }
    }

    private void BtnAcionarCommander2(object sender, EventArgs e)
    {
        Contador2.Text = ContadorCommander2.ToString();
        tipoContador2 = TipoContador.Commander;
        FrameInvisivel2();
        if (tipoElemento2 == TipoElemento.Branco)
        {
            Contador2.TextColor = Color.FromArgb("#000000");
            FrameCommander2.BorderColor = Color.FromArgb("#000000");
        }
        else
        {
            Contador2.TextColor = Color.FromArgb("#FFFFFF");
            FrameCommander2.BorderColor = Color.FromArgb("#FFFFFF");
        }
    }

    private void BtnAcionarPlanesWalker2(object sender, EventArgs e)
    {
        Contador2.Text = ContadorPlanesWalker2.ToString();
        tipoContador2 = TipoContador.PlanesWalker;
        FrameInvisivel2();
        if (tipoElemento2 == TipoElemento.Branco)
        {
            Contador2.TextColor = Color.FromArgb("#000000");
            FramePlanesWalker2.BorderColor = Color.FromArgb("#000000");
        }
        else
        {
            Contador2.TextColor = Color.FromArgb("#FFFFFF");
            FramePlanesWalker2.BorderColor = Color.FromArgb("#FFFFFF");
        }
    }

    private async void BtnSelecionarTipo2(object sender, TappedEventArgs e)
    {
        if (MopupService.Instance.PopupStack.Count <= 0)
        {
            await MopupService.Instance.PushAsync(new SelecionarTipoPopup(true));

            MessagingCenter.Subscribe<string, TipoElemento>(string.Empty, "SelecionarTipoElemento1", (sender, args) =>
            {
                FrameInvisivel2();
                switch (args)
                {
                    case TipoElemento.Azul:
                        tipoElemento2 = TipoElemento.Azul;
                        Player2Color1.Color = Color.FromArgb("#7ac8f8");
                        Player2Color2.Color = Color.FromArgb("#1690db");
                        Player2Color3.Color = Color.FromArgb("#000080");
                        break;
                    case TipoElemento.Branco:
                        tipoElemento2 = TipoElemento.Branco;
                        Player2Color1.Color = Color.FromArgb("#f3f5f2");
                        Player2Color2.Color = Color.FromArgb("#e3d1b3");
                        Player2Color3.Color = Color.FromArgb("#dbb177");
                        break;
                    case TipoElemento.Preto:
                        tipoElemento2 = TipoElemento.Preto;
                        Player2Color1.Color = Color.FromArgb("#716974");
                        Player2Color2.Color = Color.FromArgb("#1c1b21");
                        Player2Color3.Color = Color.FromArgb("#090a0c");
                        break;
                    case TipoElemento.Verde:
                        tipoElemento2 = TipoElemento.Verde;
                        Player2Color1.Color = Color.FromArgb("#afd214");
                        Player2Color2.Color = Color.FromArgb("#7fba08");
                        Player2Color3.Color = Color.FromArgb("#3d630a");
                        break;
                    case TipoElemento.Vermelho:
                        tipoElemento2 = TipoElemento.Vermelho;
                        Player2Color1.Color = Color.FromArgb("#cd7744");
                        Player2Color2.Color = Color.FromArgb("#b62c19");
                        Player2Color3.Color = Color.FromArgb("#791b19");
                        break;
                    default:
                        break;
                }
                if (tipoElemento2 == TipoElemento.Branco)
                {
                    Contador2.TextColor = Color.FromArgb("#000000");
                    FrameCoracao2.BorderColor = Color.FromArgb("#000000");
                    SelecionarTipoImg2.Source = "selecionar_tipo_black";
                    btnAdicionar2.Source = "icone_adicionar_black";
                    btnDiminuir2.Source = "icone_reduzir_black";
                    Coracao2.Source = "heart_black";
                    Raio2.Source = "lightning_black";
                    veneno2.Source = "veneno_black";
                    Commander2.Source = "commander_black";
                    PlanesWalker2.Source = "planeswalker_black";
                    MensagemRIP2.TextColor = Color.FromArgb("#000000");
                }
                else
                {
                    Contador2.TextColor = Color.FromArgb("#FFFFFF");
                    FrameCoracao2.BorderColor = Color.FromArgb("#FFFFFF");
                    SelecionarTipoImg2.Source = "selecionar_tipo_white";
                    btnAdicionar2.Source = "icone_adicionar_white";
                    btnDiminuir2.Source = "icone_reduzir_white";
                    Coracao2.Source = "heart_white";
                    Raio2.Source = "lightning_white";
                    veneno2.Source = "veneno_white";
                    Commander2.Source = "commander_white";
                    PlanesWalker2.Source = "planeswalker_white";
                    MensagemRIP2.TextColor = Color.FromArgb("#FFFFFF");
                }

                Contador2.Text = ContadorVida2.ToString();
                tipoContador2 = TipoContador.Vida;

                MessagingCenter.Unsubscribe<string, TipoElemento>(string.Empty, "SelecionarTipoElemento1");
            });
        }
    }

    private void FrameInvisivel2()
    {
        FrameCoracao2.BorderColor = Color.FromArgb("#00FFFFFF");
        FrameVeneno2.BorderColor = Color.FromArgb("#00FFFFFF");
        FrameRaio2.BorderColor = Color.FromArgb("#00FFFFFF");
        FrameCommander2.BorderColor = Color.FromArgb("#00FFFFFF");
        FramePlanesWalker2.BorderColor = Color.FromArgb("#00FFFFFF");
    }
    #endregion

    #region Reiniciar
    private void BtnReiniciar(object sender, EventArgs e)
    {
        tipoContador1 = TipoContador.Vida;
        ContadorVida1 = 20;
        ContadorVeneno1 = 0;
        ContadorEnergy1 = 0;
        ContadorCommander1 = 0;
        ContadorPlanesWalker1 = 0;
        Contador1.Text = ContadorVida1.ToString();
        MensagemRIP1.IsVisible = false;
        if (tipoElemento1 == TipoElemento.Branco)
            Contador1.TextColor = Color.FromArgb("#000000");
        else
            Contador1.TextColor = Color.FromArgb("#FFFFFF");

        tipoContador2 = TipoContador.Vida;
        ContadorVida2 = 20;
        ContadorVeneno2 = 0;
        ContadorEnergy2 = 0;
        ContadorCommander2 = 0;
        ContadorPlanesWalker2 = 0;
        Contador2.Text = ContadorVida1.ToString();
        MensagemRIP2.IsVisible = false;
        if (tipoElemento2 == TipoElemento.Branco)
            Contador2.TextColor = Color.FromArgb("#000000");
        else
            Contador2.TextColor = Color.FromArgb("#FFFFFF");
    }


    #endregion

    #region Girar Dados
    private async void BtnGirarDado(object sender, EventArgs e)
    {
        if (MopupService.Instance.PopupStack.Count <= 0)
            await MopupService.Instance.PushAsync(new DadoPopup());
    }
    #endregion

    #region Selecionar quantia de players
    private async void BtnSelecionarPlayers(object sender, EventArgs e)
    {
        //TODO - Inserir popup para selecionar quantidade de players
        if (MopupService.Instance.PopupStack.Count <= 0)
            await MopupService.Instance.PushAsync(new AlertPopup("Funcionalidade não implementada!", "Está funcionalidade ainda não foi implementada no momento."));
    }
    #endregion

    #region Configurar Vida Inicial
    private async void BtnConfiguracoes(object sender, EventArgs e)
    {
        if (MopupService.Instance.PopupStack.Count <= 0)
        {
            await MopupService.Instance.PushAsync(new ConfiguracaoPopup());

            MessagingCenter.Subscribe<string, int>(string.Empty, "TrocarQuantiaVida", (sender, args) =>
            {
                ContadorVida1 = args;
                ContadorVida2 = args;

                tipoContador1 = TipoContador.Vida;
                tipoContador2 = TipoContador.Vida;

                Contador1.Text = ContadorVida1.ToString();
                Contador2.Text = ContadorVida2.ToString();

                FrameInvisivel1();
                FrameInvisivel2();

                if (tipoElemento1 == TipoElemento.Branco)
                    FrameCoracao1.BorderColor = Color.FromArgb("#000000");
                else
                    FrameCoracao1.BorderColor = Color.FromArgb("#FFFFFF");

                if (tipoElemento2 == TipoElemento.Branco)
                    FrameCoracao2.BorderColor = Color.FromArgb("#000000");
                else
                    FrameCoracao2.BorderColor = Color.FromArgb("#FFFFFF");

                MensagemRIP1.IsVisible = false;
                MensagemRIP2.IsVisible = false;

                MessagingCenter.Unsubscribe<string, int>(string.Empty, "TrocarQuantiaVida");
            });
        }
    }
    #endregion
}