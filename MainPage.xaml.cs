namespace DiceRoller;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		Random random= new Random();
		labelValue.Text = random.Next(1,11).ToString();
	}
}

