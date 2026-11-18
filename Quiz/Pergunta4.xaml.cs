namespace Quiz;

public partial class Pergunta4 : ContentPage
{
	public Pergunta4()
	{
		InitializeComponent();
	}

    private async void OnClicked(object sender, EventArgs e)
    {
        if (But1.IsChecked)
        {
            ScoreStore.Add(1);

        }

        await Navigation.PushAsync(new Pergunta5());
    }
}