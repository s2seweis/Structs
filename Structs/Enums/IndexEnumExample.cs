using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs.Enums
{
    enum Day { Mo, Tu, We, Th, Fr, Sa, Su};
    enum Month { Jan = 01, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Okt, Nov, Dez };
    internal class IndexEnumExample
    {
        public IndexEnumExample()
        {
            IndexEnumExampleMethod();
        }
        private void IndexEnumExampleMethod()
        {
            Day fr = Day.Fr;
            Day su = Day.Su;
            Day a = Day.Fr;

            Console.WriteLine(fr == a);

            Console.WriteLine(Day.Mo);
            Console.WriteLine((int)Day.Mo);

            Console.WriteLine(Month.Feb);
            Console.WriteLine((int)Month.Feb);
        }
    }
}
