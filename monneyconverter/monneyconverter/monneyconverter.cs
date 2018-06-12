using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monneyconverter
{
  

    class ConvertToRoman
    {

        public string Run(int InputNum)
        {
            string ret = "";

            //portare fuori come rpoprietà/costante di calsse
            IDictionary<int, string> romans = new Dictionary<int, string>();

            romans[1000] = "M";
            romans[900] = "CM";
            romans[500] = "D";
            romans[400] = "CD";
            romans[100] = "C";
            romans[90] = "XC";
            romans[50] = "L";
            romans[40] = "XL";
            romans[10] = "X";
            romans[9] = "IX";
            romans[5] = "V";
            romans[4] = "IV";
            romans[1] = "I";

            //https://stackoverflow.com/questions/141088/what-is-the-best-way-to-iterate-over-a-dictionary
            foreach (KeyValuePair<int, string> roman in romans)
            {
                if (InputNum >= roman.Key)
                {
                    int x;//quoziente
                    int y;//reminder
                    x = Math.DivRem(InputNum, roman.Key, out y);

                    ret += string.Concat(Enumerable.Repeat(roman.Value, x));

                    if (y > 0)
                    {
                        ret += Run(y);
                    }

                    break;
                }
            }
            //return "MCCLV";
            return ret;
            

        }

    }
}
