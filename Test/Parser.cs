using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Parser
    {
        public int tryToParseValueFrom1To3(string inputString)
        {
            int number;
            Int32.TryParse(inputString, out number);

            if (number >= 1 && number <= 3)
            {
                return number;
            }
          
            return 0;           
        }
    }
}
