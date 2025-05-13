using CodeExamples;

var s = "anagram";
var t = "nagaram";
var result = ValidAnargram.IsAnagram(s, t);
//Console.WriteLine(result); 

var nums = new int[]{ 2, 7, 11, 15 };
var target = 9;
var result2 = TwoSumProblem.TwoSum(nums, target);
//Console.WriteLine($"[{result2[0]}, {result2[1]}]"); 

var nums2 = new int[] { 1,2,4,7,9};
var result3 = TwoSum_II.TwoSum( nums2, target);
Console.WriteLine($"[{result3[0]}, {result3[1]}]");