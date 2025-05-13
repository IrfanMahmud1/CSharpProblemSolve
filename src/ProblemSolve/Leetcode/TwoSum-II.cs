using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeExamples
{
    public class TwoSum_II
    {
        public static int[] TwoSum(int[] numbers, int target)
        {
            int len = numbers.Length;
            int i = 0, j = len - 1;
            while (i <= j) 
            {
                if (numbers[i] + numbers[j] == target)
                {
                    return new int[] { i + 1, j + 1};
                }
                else if (numbers[i] + numbers[j] < target)
                {
                    i++;
                }
                else
                {
                    j--; 
                }
            }
            return new int[0];
        }
    }
}
