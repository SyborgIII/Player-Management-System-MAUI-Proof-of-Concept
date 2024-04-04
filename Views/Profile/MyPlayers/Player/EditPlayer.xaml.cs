using SiaScoreApp.Maui.Models;

namespace SiaScoreApp.Maui.Views.Profile.MyPlayers.Player;
[QueryProperty(nameof(PlayerId), "PlayerId")]
public partial class EditPlayer : ContentPage
{
    private Models.Player EditPagePlayer;

    public string PlayerId
    {
        set
        {
            EditPagePlayer = PlayerRepository.GetPlayerById(int.Parse(value));
            FirstNameEntry.Text = EditPagePlayer.FirstName;
            LastNameEntry.Text = EditPagePlayer.LastName;
            TeamEntry.Text = EditPagePlayer.TeamName;
        }
    }
	public EditPlayer()
	{
		InitializeComponent();
	}

    private void ReturnBtn_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }


    private void SaveChangesBtn_Clicked(object sender, EventArgs e)
    {
        EditPagePlayer.FirstName = FirstNameEntry.Text;
        EditPagePlayer.LastName = LastNameEntry.Text;
        EditPagePlayer.TeamName = TeamEntry.Text;
        PlayerRepository.UpdatePlayer(EditPagePlayer.PlayerId, EditPagePlayer);
        Shell.Current.GoToAsync("..");
        DisplayAlert("Edit Player Changes Saved", "Player changes have been saved", "OK");
    }
}