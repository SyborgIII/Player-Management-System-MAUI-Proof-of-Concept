namespace SiaScoreApp.Maui.Views.Profile.MyAppraisalSessions.AppraisalSession.Appraisal;

public partial class EditAppraisal : ContentPage
{
	public EditAppraisal()
	{
		InitializeComponent();
	}

    private void returnBtn_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync("..");
    }

    private void SaveChangesBtn_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Save Changes", "Cahnges to appraisal have been saved", "OK");
    }
}