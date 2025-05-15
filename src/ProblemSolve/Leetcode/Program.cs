using CodeExamples;
using Leetcode;

var strs = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
var result = GroupAnargrams.GroupAnagrams(strs);

foreach (var group in result)
{
    Console.WriteLine(string.Join(", ", group));
}