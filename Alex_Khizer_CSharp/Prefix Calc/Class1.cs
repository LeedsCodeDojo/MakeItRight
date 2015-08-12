using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prefix_Calc
{
 
    public class PrefixCalculator
    {

        public static Int32 Evaluate(String Input)
        {
            var parts = Input.Split(' ');
            var operation = parts[0];

            var result = Int32.Parse(parts[1]);

            for (int i = 2; i < parts.Length; i++) {
                var nextPart = Int32.Parse(parts[i]);
                switch (operation) {
                    case "+":
                        result = result + nextPart;
                        break;
                    case "-":
                        result = result - nextPart;
                        break;
                    case "*":
                        result = result * nextPart;
                        break;
                    case "/":
                        result = result / nextPart;
                        break;
                    default:
                        break;
                }
            }

            return result;

        }
    }

}
