using LoginSection.Commands;
using LoginSection.Core;
using LoginSection.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSection.MVVM.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
		private string _name;
		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				_name = value;
				OnPropertyChanged(nameof(Name));
			}
		}

		private string _password;
		public string Password
		{
			get
			{
				return _password;
			}
			set
			{
				_password = value;
				OnPropertyChanged(nameof(Password));
			}
		}

		public RelayCommand ValidCommand { get; }
        public RelayCommand CancelCommand { get; }
        public LoginViewModel(NavigationStore navigationStore, AccountStore accountStore) 
        {
			ValidCommand = new LoginCommand(accountStore, navigationStore, this);
            CancelCommand = new NavigateService<HomeViewModel>(navigationStore, () => new HomeViewModel(navigationStore, accountStore));
        }
    }
}
