using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class Top_K_Frequent_Elements
    {
        public static int[] TopKFrequent(int[] nums, int k)
        {
            var queue = new PriorityQueue<int, int>();
            var map = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (map.ContainsKey(num))
                {
                    map[num]++;
                }
                else
                {
                    map.Add(num, 1);
                }
            }
            foreach (var m in map)
            {
                queue.Enqueue(m.Key, m.Value);
                if (queue.Count > k)
                {
                    queue.Dequeue();
                }
            }
            var result = new int[k];
            int i = 0;
            while (queue.Count > 0)
            {
                result[i] = queue.Dequeue();
                i++;
            }            
            return result;
        }
    }
}
