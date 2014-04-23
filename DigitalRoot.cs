using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            DigitalRoot("36");
          

        }

        static void DigitalRoot(string rootThis)
        {
            {
                var total = 0;

                for (var i = 0; i < rootThis.Length; i++)
                {
                    var letter = rootThis[i].ToString();
                    var number = Convert.ToInt32(letter);
                    total = total + number;
                }
                Console.WriteLine(total);
            }
            Console.ReadKey();
        }
      
    }
}
