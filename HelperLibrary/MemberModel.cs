using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperLibrary
{
    public class MemberModel
    {
        public string forNavn { get; set; }
        public string efterNavn { get; set; }
        public string alias { get; set; }
        public string mobil { get; set; }
        public string email { get; set; }
     
        public override string ToString()
        {
            return this.forNavn + " " + this.efterNavn + ", " + this.alias + ", " + this.mobil + ", " + this.email;
        }
        
    }
}
