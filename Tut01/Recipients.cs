using System;

namespace Tut01
{
    class Recipients
    {
        string Name;
        int Hours;
        
        public Recipients(string Name)
        {
            this.Name = Name;
            Hours = 90;
        }

        public string getName()
        {
            return Name;
        }
        
        public int getHours()
        {
            return Hours;
        }

        public void setHours(int P)
        {
            Hours = P;
        }
    }
}