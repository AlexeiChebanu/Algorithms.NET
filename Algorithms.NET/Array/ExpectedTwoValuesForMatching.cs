using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.NET.Array
{
    internal class ExpectedTwoValuesForMatching
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            var seen = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (seen.ContainsKey(complement))
                {
                    return new int[] { seen[complement], i };
                }
                seen[nums[i]] = i;
            }
            return new int[0];
        }
    }
}
