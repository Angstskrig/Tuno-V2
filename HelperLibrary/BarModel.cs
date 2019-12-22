using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperLibrary
{
    public class BarModel
    {
        public string barnavn { get; set; }

        public override string ToString()
        {
            return this.barnavn;
        }
    }
}
