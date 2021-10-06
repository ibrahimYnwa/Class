using System;
using System.Collections.Generic;
using System.Text;

namespace Ierarxiya
{
    class Country
    {
        public string capital;
        public string language;
        public int population;

        public string Detail()
        {
            return ($"{capital} {language} {population}"); 

        }
    }
    
}
