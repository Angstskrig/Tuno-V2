using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperLibrary
{
    public class TypeModel
    {
        public string type { get; set; }

        public override string ToString()
        {
            return this.type;
        }
    }
}
