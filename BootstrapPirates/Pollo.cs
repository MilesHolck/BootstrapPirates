using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootstrapPirates
{
    public class Pollo
    {
        public Pollo() { }
        private string _testField; 
        public string TestProperty
        {
            get { return _testField; }
            set { _testField = value; }
        }
    }
}
