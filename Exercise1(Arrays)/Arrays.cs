using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1_Arrays_
{
   public static class Arrays
    {
        public static int[] Accumulate(int[] inputArray)
        {
            var result = new int[inputArray.Length];
            for(var i = 0; i < inputArray.Length; i++)
            {
                var j = i + 1;
                var k = i;
                while(k<j)
                {
                    result[i] += inputArray[k];
                    k++;
                    
                }
               
            }
            return result; 
        }

    }
}
