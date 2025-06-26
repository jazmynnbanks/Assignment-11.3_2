int[] nums = { 2, 2, 1, 1, 1, 2, 2 };
Dictionary<int, int> counts = new Dictionary<int, int>();
int majorityCount = nums.Length / 2;
int majorityElement = 0;

for (int i = 0; i < nums.Length; i++)
{
    if (counts.ContainsKey(nums[i]))
    {
        counts[nums[i]]++;
    }
    else
    {
        counts[nums[i]] = 1;
    }
    if (counts[nums[i]] > majorityCount)
    {
        majorityElement = nums[i];
        break;
    }
}

Console.WriteLine(majorityElement);
Console.ReadKey();