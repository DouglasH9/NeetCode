using System;
namespace ArraysAndHashing
{
    public class TopKFreqElements
    {
        public static int[] Calc(int[] nums, int k)
        {
            Dictionary<int, int> frequency = new();
            foreach (int num in nums)
            {
                if (!frequency.ContainsKey(num))
                {
                    frequency.Add(num, 0);
                }
                frequency[num]++;
            }

            List<int>[] bucket = new List<int>[nums.Length + 1];

            foreach (KeyValuePair<int, int> kv in frequency)
            {
                if (bucket[kv.Value] == null)
                {
                    bucket[kv.Value] = new List<int>();
                }
                bucket[kv.Value].Add(kv.Key);
            }

            int[] topK = new int[k];
            for (int i = nums.Length; i > 0; i--)
            {
                if (bucket[i] == null)
                    continue;

                foreach (int num in bucket[i])
                {
                    if (k == 0)
                        return topK;

                    topK[k - 1] = num;
                    k -= 1;
                }
            }
            return topK;
        }
    }
}

