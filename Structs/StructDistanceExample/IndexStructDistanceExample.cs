using Structs.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs.StructDistanceExample
{
    internal class IndexStructDistanceExample
    {
        public IndexStructDistanceExample()
        {
            InduxStructExampleMethod();
        }

        private void InduxStructExampleMethod()
        {

            Point p1 = new Point(10, 20);
            Point p2 = new Point(20, 30);
            //p2.Display();

            double distance = p1.DistanceTo(p2);

            Console.WriteLine($"Distance between points: {distance:F6}m");

        }
    }
}

/*
Its a common practice to make structs immutable 
by declaring all fields as readonly and providing only 
get accessors for pproerties.
 */
