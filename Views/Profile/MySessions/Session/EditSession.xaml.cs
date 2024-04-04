using SiaScoreApp.Maui.Models;

namespace SiaScoreApp.Maui.Views.Profile.MySessions.Session;
[QueryProperty(nameof(SessionId), "SessionId")]
public partial class EditSession : ContentPage
{
	private Models.Session EditSessionSession;

	public string SessionId
	{
		set
		{
			EditSessionSession = SessionRepository.GetSessionById(int.Parse(value));
			SessionNameEntry.Text = EditSessionSession.Name;
			SessionTypeEntry.Text = EditSessionSession.Type;

        }
	}
	public EditSession()
	{
		InitializeComponent();
	}

    private void SaveChangesBtn_Clicked(object sender, EventArgs e)
    {
		EditSessionSession.Name  = SessionNameEntry.Text;
		EditSessionSession.Type = SessionTypeEntry.Text;
		SessionRepository.UpdateSession(EditSessionSession.SessionId, EditSessionSession);
        Shell.Current.GoToAsync("..");
        DisplayAlert("Session Changes Saved", "Session changes have been saved", "OK");
    }

    private void ReturnBtn_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");

    }
}