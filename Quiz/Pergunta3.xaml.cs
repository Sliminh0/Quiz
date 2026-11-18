namespace Quiz;

public partial class Pergunta3 : ContentPage
{
	public Pergunta3()
	{
		InitializeComponent();
	}

    private async void OnClicked(object sender, EventArgs e)
    {
        if (But4.IsChecked)
        {
            ScoreStore.Add(1);

        }

        await Navigation.PushAsync(new Pergunta4());
    }
}