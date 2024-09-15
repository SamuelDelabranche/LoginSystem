using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSection.Core
{
    public class ViewModelBase : Observable
    {
        public virtual void Dispose() { }
    }
}
