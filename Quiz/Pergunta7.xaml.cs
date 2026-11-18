namespace Quiz;

public partial class Pergunta7 : ContentPage
{
	public Pergunta7()
	{
		InitializeComponent();
	}
    private async void OnClicked(object sender, EventArgs e)
    {
        if (But2.IsChecked)
        {
            ScoreStore.Add(1);

        }

        await Navigation.PushAsync(new Pergunta8());
    }

}