using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs.ValueTypeVersusReferenceType
{
    internal class IndexTypes
    {
        public IndexTypes()
        {
            InduxStructExampleMethod();
        }

        public void InduxStructExampleMethod()
        {

            Point p1 = new Point(10, 20);
            p1.Display();

            Point p2 = p1; // p2 is a copy of p1
            p2.Display();
            p2.X = 25; // Changes p2, p1 remains unchanged
            Console.WriteLine("After changing p2.X to 25");
            p1.Display();
            p2.Display();

            Console.WriteLine("Now come the class objects");
            PointClass pC1 = new PointClass(10, 20);
            PointClass pC2 = pC1; // pC2 is a reference to the same object
            pC1.Display();
            pC2.Display();

            pC2.X = 3; // Changes p1.X as well, since p1 and p2 reference the 
            Console.WriteLine("After changing pC2.X to 3");
            pC1.Display();
            pC2.Display();

            bool isEqual = pC1.Equals(pC2);
            Console.WriteLine("is it equal?" + isEqual);

        }
    }
}
