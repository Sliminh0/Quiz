namespace Quiz;

public partial class Resultados : ContentPage
{
	public Resultados()
	{
		InitializeComponent();

        resultado.Text = "  " + ScoreStore.Points.ToString() + " pontos"; 



    }

    private async void OnClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
        ScoreStore.Reset();
    }

    private async void OnClickedReset(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new Pergunta1());
        ScoreStore.Reset();
    }
}