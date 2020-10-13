using System;

namespace Prac02
{
    class Program
    {
        static void addMember(Member[] List, ref int nrEl)
        {
            Console.WriteLine("Name of member:");
            List[nrEl] = new Member(Console.ReadLine());
            nrEl++;
        }
        static void Main(string[] args)
        {
            Member[] List = new Member[10];
            int nrEl = 0;

            for(int i = 0; i < 3; i++)
            {
                addMember(List, ref nrEl);
            }

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(List[i].getName());
            }

            for(int i = 0; i < 3; i++)
            {
                List[i].setPoints(30);
            }
        }
    }
}
