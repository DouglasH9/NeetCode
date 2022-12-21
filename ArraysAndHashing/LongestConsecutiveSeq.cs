using System;
namespace ArraysAndHashing
{
    public static class LongestConsecutiveSeq
    {
        public static int Calc(int[] nums)
        {
            HashSet<int> numSet = new HashSet<int>();
            int longestConsec = 0;

            foreach (int num in nums)
                numSet.Add(num);

            for (int i = 0; i < nums.Length; i++)
            {
                int lengthOfCurrRun = 0;

                if (!numSet.Contains(nums[i] - 1))
                {
                    lengthOfCurrRun = 0;
                    while (numSet.Contains(nums[i] + lengthOfCurrRun))
                        lengthOfCurrRun += 1;
                    longestConsec = Math.Max(lengthOfCurrRun, longestConsec);
                }
            }

            return longestConsec;
        }
    }
}

