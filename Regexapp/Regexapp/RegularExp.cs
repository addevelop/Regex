using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Regexapp
{
    class RegularExp
    {
        string rgx;
        string str;
        
        public RegularExp(string rgx, string str)
        {
            this.rgx = rgx;
            this.str = str;
        }

        public bool Mregex()
        {
            Match mt = Regex.Match(this.str, this.rgx);
            if (mt.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
           
        
        
        

    }
}
