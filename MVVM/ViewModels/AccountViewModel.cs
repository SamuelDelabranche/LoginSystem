using LoginSection.Core;
using LoginSection.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSection.MVVM.ViewModels
{
    public class AccountViewModel : ViewModelBase
    {
        private readonly AccountStore _accountStore;

        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }


        public AccountViewModel(AccountStore accountStore, NavigationStore navigateStore)
        {
            _accountStore = accountStore;
            _Name = _accountStore.CurrentAccount.Name;

            _accountStore.CurrentAccountChanged += OnCurrentAccountChanged;
        }

        private void OnCurrentAccountChanged()
        {
            OnPropertyChanged(nameof(Name));
        }

        public override void Dispose()
        {
            _accountStore.CurrentAccountChanged -= OnCurrentAccountChanged;
            base.Dispose();
        }

    }
}
