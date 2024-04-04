using SiaScoreApp.Maui.Models;
using SiaScoreApp.Maui.Views.Profile.MyPlayers.Player;
using System.Xml;

namespace SiaScoreApp.Maui.Views;
[QueryProperty(nameof(PlayerId),"PlayerId")]
public partial class PlayerPage : ContentPage
{
    private Models.Player PlayerPagePlayer;

    public string PlayerId
    {
        set
        {
            PlayerPagePlayer = PlayerRepository.GetPlayerById(int.Parse(value));
            NameLabel.Text = $"{PlayerPagePlayer.FirstName} {PlayerPagePlayer.LastName}";
            PlayerTeamNameLabel.Text = $"Team: {PlayerPagePlayer.TeamName}";
        }
    }


	public PlayerPage()
	{
		InitializeComponent();
	}

    private void EditPlayerBtn_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync($"{nameof(EditPlayer)}?PlayerId={PlayerPagePlayer.PlayerId}");
    }


    private void ReturnBtn_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }
}