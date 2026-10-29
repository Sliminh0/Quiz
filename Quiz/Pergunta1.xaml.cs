namespace Quiz;

public partial class Pergunta1 : ContentPage
{
	public Pergunta1()
	{
		InitializeComponent();
	}

    private async void OnClicked(object sender, EventArgs e)
    {
        if (But2.IsChecked)
        {
            ScoreStore.Add(1);

        }

        await Navigation.PushAsync(new Pergunta2());
    }
}