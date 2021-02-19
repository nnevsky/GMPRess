using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMPress.DataProvider.Helpers
{
    public abstract class BaseDbHelper
    {
        protected readonly string connectionstiong;

        public BaseDbHelper(string connectionstiong)
        {
            this.connectionstiong = connectionstiong;
        }
    }
}
