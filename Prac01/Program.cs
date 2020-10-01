using System;

namespace Prac01
{
    class Program
    {
        static void Main(string[] args)
        {
            Member J = new Member("John");
            Member S = new Member("Susan");

            J.setPoints(23);
            S.setPoints(4);

            if (J.getPoints() > S.getPoints())
                Console.WriteLine(J.getName());
            else
                Console.WriteLine(S.getName());
        }
    }
}
