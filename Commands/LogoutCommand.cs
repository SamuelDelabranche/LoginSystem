using LoginSection.Core;
using LoginSection.MVVM.Models;
using LoginSection.MVVM.ViewModels;
using LoginSection.MVVM.Views;
using LoginSection.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSection.Commands
{
    public class LogoutCommand : RelayCommand
    {
        private readonly AccountStore _accountStore;
        private readonly NavigationStore _navigationStore;

        public LogoutCommand(AccountStore accountStore, NavigationStore navigationStore)
        {
            _accountStore = accountStore;
            _navigationStore = navigationStore;
        }

        public override void Execute(object parameter)
        {
            _accountStore.LogOut();
            _navigationStore.CurrentViewModel = new HomeViewModel(_navigationStore, _accountStore);
            
        }
    }
}
