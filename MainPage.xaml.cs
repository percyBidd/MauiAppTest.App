namespace MauiAppTest;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
	private void OnResetClicked(object sender, EventArgs e)
	{
        var rand = new Random();
        //Thread.Sleep(1000);
		Int32 col1 = count * 3 - 100 / 3;
		Int32 col2 = rand.Next(255);
		Int32 col3 = rand.Next(255);
		CounterBtnReset.BackgroundColor = Color.FromRgb(col1,col2,col3);
		count =0;

			CounterBtn.Text = $"Clicked {count} time";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

