using CodeExamples;
using Leetcode;

var nums = new int[] { 1,1,1,2,2,2,3,3,3};

var res = Top_K_Frequent_Elements.TopKFrequent(nums, 3);

foreach (var item in res)
{
    Console.WriteLine(item);
}

