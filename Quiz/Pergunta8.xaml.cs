namespace Quiz;

public partial class Pergunta8 : ContentPage
{
	public Pergunta8()
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