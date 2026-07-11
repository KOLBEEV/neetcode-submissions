public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> numWithCount = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            if (numWithCount.ContainsKey(num))
            {
                numWithCount[num]++;
                continue;
            }

            numWithCount[num] = 1;
        }

        numWithCount = numWithCount.OrderByDescending(x => x.Value).ToDictionary();
        int[] result = new int[k];

        for (int i = 0; i < k; i++)
        {
            result[i] = numWithCount.ElementAt(i).Key; 
        }

        return result;
    }
}
