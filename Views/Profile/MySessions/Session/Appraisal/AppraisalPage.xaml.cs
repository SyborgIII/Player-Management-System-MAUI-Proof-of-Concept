using SiaScoreApp.Maui.Views.Profile.MyAppraisalSessions.AppraisalSession.Appraisal;

namespace SiaScoreApp.Maui.Views;

public partial class AppraisalPage : ContentPage
{
	public AppraisalPage()
	{
		InitializeComponent();
	}


    private void ReturnBtn_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }

    private void EditAppraisalBtn_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(EditAppraisal));
    }
}