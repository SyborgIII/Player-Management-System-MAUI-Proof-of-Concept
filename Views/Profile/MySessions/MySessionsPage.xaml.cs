using SiaScoreApp.Maui.Models;
using System.Collections.ObjectModel;

namespace SiaScoreApp.Maui.Views.Profile.MySessions;

public partial class MySessionsPage : ContentPage
{
	public MySessionsPage()
	{
		InitializeComponent();


    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        var MySessionsList = new ObservableCollection<Models.Session>(SessionRepository.GetMySessionList());

        MySessionsListView.ItemsSource = MySessionsList;
        

    }


    private void AddNewSessionBtn_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(AddSession));
    }

    private void ReturnToProfileBtn_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }

    private void MySessionsListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        MySessionsListView.SelectedItem = null;
    }

    private void MySessionsListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if(MySessionsListView.SelectedItem != null) 
        {
            Shell.Current.GoToAsync($"{nameof(SessionPage)}?SessionId={((Models.Session)MySessionsListView.SelectedItem).SessionId}");
        }
    }
}