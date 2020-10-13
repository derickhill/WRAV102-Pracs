using System;

namespace Tut01
{
    class Program
    {
        static void Main(string[] args)
        {
            Recipients x = new Recipients("Xola");
            Recipients d = new Recipients("David");
            Recipients s = new Recipients("Sandy");

            x.setHours(75);
            d.setHours(80);
            s.setHours(60);

            Console.WriteLine("Total number of hours outstanding: {0}", x.getHours() + d.getHours() + s.getHours());
        }
    }
}
