namespace SiaScoreApp.Maui.Views.Profile.MyPlayers;

public partial class AddPlayer : ContentPage
{
	public AddPlayer()
	{
		InitializeComponent();
	}

    private void ReturnBtn_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }


    private void AddPlayerBtn_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Changes Saved", "Player has been added and saved", "OK");
    }
}