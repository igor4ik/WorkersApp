using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WorkerApp
{
    class Worker //: IDataErrorInfo
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;

            }
        }
        public string Remove
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }
    }
}
