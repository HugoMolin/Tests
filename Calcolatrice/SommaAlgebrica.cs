using System;

namespace Calcolatrice
{
    public class SommaAlgebrica
    {
        public SommaAlgebrica()
        {

        }

        public int Add(int[] addendi)
        {
            if(addendi == null || addendi.Length == 0)
            {
                throw new ArgumentNullException();
            }

            int sum = 0;

            foreach(int v in addendi)
            {
                sum += v;
            }

            return sum;
        }
    }
}