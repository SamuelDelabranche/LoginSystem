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
        public RelayCommand ValidCommand { get; }
        public RelayCommand CancelCommand { get; }
        public LoginViewModel(NavigationStore navigationStore) 
        {
            ValidCommand = new NavigateService<AccountViewModel>(navigationStore, () => new AccountViewModel(navigationStore));
            CancelCommand = new NavigateService<HomeViewModel>(navigationStore, () => new HomeViewModel(navigationStore));
        }
    }
}
