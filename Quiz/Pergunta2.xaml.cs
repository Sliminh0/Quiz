namespace Quiz;

public partial class Pergunta2 : ContentPage
{
	public Pergunta2()
	{
		InitializeComponent();
	}

    private async void OnClicked(object sender, EventArgs e)
    {
        if (But3.IsChecked)
        {
            ScoreStore.Add(1);

        }

        await Navigation.PushAsync(new Pergunta3());
    }
}
