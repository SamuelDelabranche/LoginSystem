using LoginSection.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSection.Stores
{
    public class AccountStore
    {
        public event Action CurrentAccountChanged;

        private Account _currentAccount;
		public Account CurrentAccount
		{
			get => _currentAccount;
			set
			{
				_currentAccount = value;
				CurrentAccountChanged?.Invoke();

			}
		}

		public bool isLoggedIn => _currentAccount != null;
		public void LogOut() => _currentAccount = null;


	}
}
