using SiaScoreApp.Maui.Models;
using SiaScoreApp.Maui.Views.Profile.MyAppraisalSessions;
using SiaScoreApp.Maui.Views.Profile.MyPlayers;
using SiaScoreApp.Maui.Views.Profile.MySessions;
using System.Collections.ObjectModel;

namespace SiaScoreApp.Maui.Views.Profile;

public partial class ProfilePage : ContentPage
{
    private Models.Profile MainProfile;
	public ProfilePage()
	{
		InitializeComponent();
       
        
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        var Profiles = new ObservableCollection<Models.Profile>(ProfileRepository.GetProfiles());
        MainProfile = Profiles.FirstOrDefault(x => x.ProfileId == 1);
        ProfilePageHeaderLabel.Text = $"Welcome {MainProfile.Username}";
    }


    private void EditProfileBtn_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync($"{nameof(EditProfile)}?ProfileId={MainProfile.ProfileId}");
    }

    private void NavMyPlayersPageBtn_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(MyPlayersPage));
    }

    private void NavMySessionsBtn_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(MySessionsPage));
    }
}