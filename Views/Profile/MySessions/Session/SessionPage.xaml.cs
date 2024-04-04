using SiaScoreApp.Maui.Models;
using SiaScoreApp.Maui.Views.Profile.MySessions.Session;
using System.Collections.ObjectModel;

namespace SiaScoreApp.Maui.Views;
[QueryProperty(nameof(SessionId),"SessionId")]
public partial class SessionPage : ContentPage
{
    private Session SessionPageSession;

    public string SessionId
    {
        set 
        {
            SessionPageSession = SessionRepository.GetSessionById(int.Parse(value));
            SessionPageSessionNameLabel.Text = $"Session: {SessionPageSession.Name}";
            SessionPageSessionDateLabel.Text = $"{SessionPageSession.Date}";
            SessionPageSessionTypeLabel.Text = $"Session Type: {SessionPageSession.Type}";
            // VerticalStackLayout.Text = $"Session Type: {SessionPageSession.Type} | {SessionPageSession.Name} | {SessionPageSession.Date}";
        }
    }
	public SessionPage()
	{
		InitializeComponent();

    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        var AllAppraisalsList = new ObservableCollection<Appraisal>(AppraisalRepository.GetAllAppraisalsList());
        SessionPageListView.ItemsSource = AllAppraisalsList;
    }

    private void AddNewAppraisalBtn_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(AddAppraisal));
    }
    


    private void ReturnBtn_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }

    private void SessionPageListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        SessionPageListView.SelectedItem = null;
    }

    private void SessionPageListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if(SessionPageListView.SelectedItem != null) 
        {
            Shell.Current.GoToAsync(nameof(AppraisalPage));
        }
    }

    private void EditSessionBtn_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync($"{nameof(EditSession)}?SessionId={SessionPageSession.SessionId}");
    }
}