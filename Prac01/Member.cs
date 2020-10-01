using System;

namespace Prac01
{
    public class Member
    {
        private string Name;
        private int Points;

        public Member(string Name)
        {
            this.Name = Name;
            Points = 0;
        }

        public string getName()
        {
            return Name;
        }

        public int getPoints()
        {
            return Points;
        }

        public void setPoints(int P)
        {
            Points = P;
        }
    }
}