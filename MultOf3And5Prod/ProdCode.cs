using System;

namespace MultOf3And5Prod
{
    public class ProdCode
    {   
        public static int MultOf3And5(int loopVal)
        {
            var sumOfOdd = new int();

         for (int i = 1; i <= loopVal; i+= 1)
            {
                if (i % 5 == 0 || i % 3 == 0)
                {
                    sumOfOdd += i;
                }
            }
            return sumOfOdd;
        }
    }
}
