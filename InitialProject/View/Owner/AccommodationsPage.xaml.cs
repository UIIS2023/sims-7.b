using InitialProject.Model;
using InitialProject.ViewModel.Owner;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace InitialProject.View.Owner
{
    public partial class AccommodationsPage : Page
    {
        public AccommodationsPageViewModel _viewModel { get; set; }
        public OwnerMainWindow MainWindow { get; set; }
        public User LoggedInUser { get; set; }
        public NavigationService navigationService { get; set; }

        public AccommodationsPage(NavigationService navService, OwnerMainWindow window, User user)
        {
            InitializeComponent();
            LoggedInUser = user;
            navigationService = navService;
            MainWindow = window;
            _viewModel = new AccommodationsPageViewModel(navigationService, window, user);
            DataContext = _viewModel;
        }
    }
}
