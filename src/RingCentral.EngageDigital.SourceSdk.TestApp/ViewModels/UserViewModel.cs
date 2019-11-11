using RingCentral.Sdk.TestApp.Helpers;
using RingCentral.Sdk.TestApp.Models;
using RingCentral.Sdk.TestApp.Views;

namespace RingCentral.Sdk.TestApp.ViewModels
{
    public class UserViewModel : BaseViewModel
    {
        public MainPage MainPage { get; set; }

        #region property CurrentUser
        private User _currentUser;
        public User CurrentUser
        {
            get { return _currentUser; }
            set { SetProperty(ref _currentUser, value); }
        }
        #endregion

        #region property IsNew
        private bool _isNew;
        public bool IsNew
        {
            get { return _isNew; }
            set { SetProperty(ref _isNew, value); }
        }
        #endregion

        public UserViewModel()
        {
            CurrentUser = new User(0);
            IsNew = true;
        }
    }
}
