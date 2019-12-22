using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperLibrary
{
    public class ItemModel
    {
        public string navn { get; set; }
        public string type { get; set; }
        public int antal { get; set; }
        public int startAntal { get; set; }
        public override string ToString()
        {
            return this.navn + " " + this.type + " " + this.antal + "stk.";
        }
    }
}
