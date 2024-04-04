using Microsoft.VisualBasic;
using SiaScoreApp.Maui.Models;

namespace SiaScoreApp.Maui.Views.Profile;
[QueryProperty(nameof(ProfileId) , "ProfileId")]
public partial class EditProfile : ContentPage
{
    private Models.Profile ProfileToEdit;
	public EditProfile()
	{
		InitializeComponent();
	}

    public string ProfileId
    {
        set 
        {
            ProfileToEdit = ProfileRepository.GetProfileById(int.Parse(value));
            if(ProfileToEdit != null)
            {
                EditProfilePageLabel.Text = $"Edit {ProfileToEdit.FirstName}'s Profile";
                EntryFirstName.Text = ProfileToEdit.FirstName;
                EntryLastName.Text = ProfileToEdit.LastName;
                EntryEmail.Text = ProfileToEdit.Email;
                EntryUsername.Text = ProfileToEdit.Username;
                EntryPassword.Text = ProfileToEdit.Password;
            }
        }
    }

    private void ReturnBtn_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }

    private void SaveChangesBtn_Clicked(object sender, EventArgs e)
    {

        if (FirstNameEntryValidator.IsNotValid || LastNameEntryValidator.IsNotValid || EmailEntryMultiValidator.IsNotValid
            || UsernameEntryValidator.IsNotValid || PasswordEntryValidator.IsNotValid)
        {
            DisplayAlert("Warning", "All field must be valid to proceed", "OK");
            return;
        }
        ProfileToEdit.FirstName = EntryFirstName.Text;
        ProfileToEdit.LastName = EntryLastName.Text;
        ProfileToEdit.Email = EntryEmail.Text;
        ProfileToEdit.Username = EntryUsername.Text;
        ProfileToEdit.Password = EntryPassword.Text;
        ProfileRepository.UpdateProfile(ProfileToEdit.ProfileId, ProfileToEdit);
        Shell.Current.GoToAsync("..");
        DisplayAlert("Save Changes", "Profile Changes Saved", "OK");
        Shell.Current.GoToAsync("..");
    }
}