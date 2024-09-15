using LoginSection.Core;
using LoginSection.MVVM.Models;
using LoginSection.MVVM.ViewModels;
using LoginSection.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSection.Commands
{
    public class LoginCommand : RelayCommand
    {
        private readonly AccountStore _accountStore;
        private readonly NavigationStore _navigationStore;
        private readonly LoginViewModel _loginViewModel;

        public LoginCommand(AccountStore accountStore, NavigationStore navigationStore, LoginViewModel loginViewModel)
        {
            _accountStore = accountStore;
            _navigationStore = navigationStore;
            _loginViewModel = loginViewModel;
        }

        public override void Execute(object parameter)
        {
            Account account = new Account()
            {
                Name = _loginViewModel.Name,
                Password = _loginViewModel.Password,
            };

            _accountStore.CurrentAccount = account;

            _navigationStore.CurrentViewModel = new AccountViewModel(_accountStore, _navigationStore);
        }
    }
}
