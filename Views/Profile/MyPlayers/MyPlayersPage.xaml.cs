

using SiaScoreApp.Maui.Models;
using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;

namespace SiaScoreApp.Maui.Views.Profile.MyPlayers;

public partial class MyPlayersPage : ContentPage
{
	public MyPlayersPage()
	{
		InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        var MyPlayers = new ObservableCollection<Models.Player>(PlayerRepository.GetMyPlayerList());
        MyPlayersListView.ItemsSource = MyPlayers;
    }

    private void AddNewPlayerBtn_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(AddPlayer));
    }

    private void ReturnBtn_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }

    private async void MyPlayersListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if(MyPlayersListView.SelectedItem != null) 
        {
           await Shell.Current.GoToAsync($"{nameof(PlayerPage)}?PlayerId={((Models.Player)MyPlayersListView.SelectedItem).PlayerId}");       
        }
    }

    private void MyPlayersListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        MyPlayersListView.SelectedItem = null;
    }
}