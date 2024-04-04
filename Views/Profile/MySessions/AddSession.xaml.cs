namespace SiaScoreApp.Maui.Views.Profile.MySessions;

public partial class AddSession : ContentPage
{
	public AddSession()
	{
		InitializeComponent();
	}

    private void ReturnBtn_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }

    private void AddSessionBtn_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Add Appraisal Session", "Added new Appraisal Session", "OK");
    }
}