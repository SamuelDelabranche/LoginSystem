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
    public class HomeViewModel : ViewModelBase
    {   
        public RelayCommand LoginCommand { get; }

        public HomeViewModel(NavigationStore navigationStore, AccountStore accountStore)
        {
            LoginCommand = new NavigateService<LoginViewModel>(navigationStore, () => new LoginViewModel(navigationStore, accountStore));
        }
    }
}
