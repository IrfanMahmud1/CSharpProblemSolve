using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeExamples
{
    public class TwoSumProblem
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            int len = nums.Length;
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < len; i++)
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement] , i };
                }
                if(!map.ContainsKey(nums[i]))
                {
                    map[nums[i]] = i;
                }
            }
            return new int[0];
        }
    }
}
