using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.NET.Array
{
    internal class MedianOfTwoSortedArrays
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var result = new int[nums1.Length+nums2.Length];
            int i = 0, j = 0, k = 0;

            while(i< nums1.Length && j< nums2.Length)
            {
                if (nums1[i] < nums2[j])
                    result[k++] = nums1[i++];

                else if (nums2[j] < nums1[i])
                    result[k++] = nums2[j++];
                else
                {
                    result[k++] = nums1[i++];
                    result[k++] = nums2[j++];
                }                
            }

            for (; i < nums1.Length; i++) result[k++] = nums1[i];
            for (; j < nums2.Length; j++) result[k++] = nums1[j];

            var m = result.Length / 2;
            if (result.Length % 2 == 1) return result[m];

            return (result[m - 1] + result[m]) / 2.0;
        }

        public static double MedianSecondWay(int[] nums1, int[] nums2)
        {
            List<int> nums = new List<int>();
            nums.AddRange(nums1);
            nums.AddRange(nums2);
            nums.Sort();
            double find = nums.Count() / 2.0;

            if (find < 1)
                return nums[0];

            else if (find % 1 == 0)
                return (nums[(int)find - 1] + nums[(int)find]) / 2.0;

            else return nums[(int)find];
        }
    }
}
