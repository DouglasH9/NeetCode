using System;
namespace ArraysAndHashing
{
    public static class ProductExceptSelf
    {
        public static int[] Calc(int[] nums)
        {
            int length = nums.Length;
            int[] answerArr = new int[length];

            

            answerArr[0] = 1;
            for (int i = 1; i < length; i++)
            {
                answerArr[i] = answerArr[i - 1] * nums[i - 1];
            }

            int right = 1;
            for (int i = length - 1; i > -1; i--)
            {
                answerArr[i] = answerArr[i] * right;
                right *= nums[i];
            }

            return answerArr;
        }
    }
}

