using SiaScoreApp.Maui.Views;
using SiaScoreApp.Maui.Views.Profile;
using SiaScoreApp.Maui.Views.Profile.MySessions;
using SiaScoreApp.Maui.Views.Profile.MyPlayers;
using SiaScoreApp.Maui.Views.Profile.MyPlayers.Player;
using SiaScoreApp.Maui.Views.Profile.MyAppraisalSessions.AppraisalSession.Appraisal;
using SiaScoreApp.Maui.Views.Profile.MySessions.Session;

namespace SiaScoreApp.Maui
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            //View Registration for routing to pages

            Routing.RegisterRoute(nameof(AddAppraisal), typeof(AddAppraisal));
            Routing.RegisterRoute(nameof(AddSession), typeof(AddSession));
            Routing.RegisterRoute(nameof(AddPlayer), typeof(AddPlayer));
            Routing.RegisterRoute(nameof(AppraisalPage), typeof(AppraisalPage));
            Routing.RegisterRoute(nameof(SessionPage), typeof(SessionPage));
            Routing.RegisterRoute(nameof(MySessionsPage), typeof(MySessionsPage));    
            Routing.RegisterRoute(nameof(MyPlayersPage), typeof(MyPlayersPage));
            Routing.RegisterRoute(nameof(PlayerPage), typeof(PlayerPage));
            Routing.RegisterRoute(nameof(ProfilePage), typeof(ProfilePage));
            Routing.RegisterRoute(nameof(EditProfile), typeof(EditProfile));
            Routing.RegisterRoute(nameof(EditPlayer), typeof(EditPlayer));
            Routing.RegisterRoute(nameof(EditAppraisal), typeof(EditAppraisal));
            Routing.RegisterRoute(nameof(EditSession), typeof(EditSession));    
               
            
            
            
           


        }
    }
}
