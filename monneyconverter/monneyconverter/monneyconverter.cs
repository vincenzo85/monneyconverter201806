using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monneyconverter
{
  

    class ConvertToRoman
    {

        public int InputInt { get; set; }

        /*public int Firstint { get; set; }
        public string Firststring { get; set; }
        public double Firstdouble { get; set; }
        public char Firstchar { get; set; }
        */

        public string Run()
        {
            /*return method*/

            IDictionary<int, string> roman = new Dictionary<int, string>();

            roman[1000] = "M";
            roman[900] = "CM";
            roman[500] = "D";
            roman[400] = "CD";
            roman[100] = "C";
            roman[90] = "XC";
            roman[50] = "L";
            roman[40] = "XL";
            roman[10] = "X";
            roman[9] = "IX";
            roman[5] = "V";
            roman[4] = "IV";
            roman[1] = "I";



            //https://stackoverflow.com/questions/141088/what-is-the-best-way-to-iterate-over-a-dictionary
            /*foreach (IDictionary<int, string> entry in roman)
            {
                // do something with entry.Value or entry.Key
            }*/

            foreach (KeyValuePair<int, string> entry in roman)
            {

            }
            

                /*
                 * 
                          def roman_num(num):
                                for r in roman.keys():
                                    x, y = divmod(num, r)
                                    yield roman[r] * x
                                    num -= (r* x)
                                    if num > 0:
                                        roman_num(num)
                                    else:
                                        break

                            return "".join([a for a in roman_num(num)])
                */

                return "MCCLV";

        }

    }
}
