namespace SiaScoreApp.Maui.Views;

public partial class AddAppraisal : ContentPage
{
	public AddAppraisal()
	{
		InitializeComponent();
	}

    private void ReturnBtn_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }

    private void AddAppraisalBtn_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Appraisal Added", "Appraisal has been added to the session", "Ok");
    }
}