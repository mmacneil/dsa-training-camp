
namespace LeetCode
{
    public static class Problems
    {
       /* Remove Duplicates from Sorted Array - https://leetcode.com/problems/remove-duplicates-from-sorted-array/
          Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once. The relative order of the elements should be kept the same.
          Since it is impossible to change the length of the array in some languages, you must instead have the result be placed in the first part of the array nums. More formally, if there are k elements after removing the duplicates, then the first k elements of nums should hold the final result. It does not matter what you leave beyond the first k elements.
          Return k after placing the final result in the first k slots of nums.
          Do not allocate extra space for another array. You must do this by modifying the input array in-place with O(1) extra memory. */
        public static int RemoveDuplicates(int[] nums)
        {
            var result = 0;
            var length = nums.Length;

            if (length == 1) return 1;

            if (nums.Distinct().Count() == 1) return 1;

            for(var i=0; i < length; i++)
            {
                var value = nums[i];
                var nextIndex = i + 1;

                // Last element - compare it to the last stored unique element
                if(nextIndex == length && value != nums[result-1])
                {
                    nums[result] = value;
                    result++;
                    break;
                }

                if(value != nums[i + 1])
                {
                    nums[result] = value;
                    result++;
                }

            }
            return result;
        }

      /* Remove Element - https://leetcode.com/problems/remove-element/
         Given an integer array nums and an integer val, remove all occurrences of val in nums in-place. The relative order of the elements may be changed.
         Since it is impossible to change the length of the array in some languages, you must instead have the result be placed in the first part of the array nums.
         More formally, if there are k elements after removing the duplicates, then the first k elements of nums should hold the final result.
         It does not matter what you leave beyond the first k elements.
         Return k after placing the final result in the first k slots of nums.
         Do not allocate extra space for another array. You must do this by modifying the input array in-place with O(1) extra memory. */
        public static int RemoveElement(int[] nums, int val)
        {
            var result = 0;
            var length = nums.Length;

           if (length == 1)
            {
                if (nums[0]==val)
                {
                    return 0;
                    
                }
                return 1;
            }

            for(var i=0; i<length;i++)
            {
                if(nums[i] != val)
                {
                    nums[result] = nums[i];
                    result++;
                }
            }

            return result;
        }
    }
}
