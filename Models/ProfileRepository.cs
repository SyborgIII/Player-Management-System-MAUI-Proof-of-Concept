using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SiaScoreApp.Maui.Models
{
   public static class ProfileRepository
    {
        public static List<Profile> Profiles = new List<Profile>()
        {
            new Profile{ProfileId = 1, FirstName = "Simon", LastName = "Codrington III", Email = "Simon.CodringtonIII@outlook.com", Password = "1234", Username = "SyborgIII"}
        };

        public static List<Profile> GetProfiles() {  return Profiles; }
        public static Profile GetProfileById(int profileId) 
        {
            var Profile = Profiles.FirstOrDefault(x => x.ProfileId == profileId);
            if(Profile != null)
            {
                return new Profile
                {
                    ProfileId = profileId,
                    FirstName = Profile.FirstName,
                    LastName = Profile.LastName,
                    Email = Profile.Email,
                    Password = Profile.Password,
                    Username = Profile.Username,
                };
            }
            return null;
        }

        public static void UpdateProfile(int profileId, Profile profile)
        {
            if(profileId != profile.ProfileId)
            {
                return;
            }

            var ProfileToUpdate = Profiles.FirstOrDefault(x => x.ProfileId == profileId);
            if (ProfileToUpdate != null)
            {
                ProfileToUpdate.FirstName = profile.FirstName;
                ProfileToUpdate.LastName = profile.LastName;
                ProfileToUpdate.Email = profile.Email;
                ProfileToUpdate.Password = profile.Password;
                ProfileToUpdate.Username = profile.Username;
            }
        }




    }
}
