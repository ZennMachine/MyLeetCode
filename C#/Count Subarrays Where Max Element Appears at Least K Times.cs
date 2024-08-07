// https://leetcode.com/problems/count-subarrays-where-max-element-appears-at-least-k-times/submissions/1217274612

public class Solution {
    public long CountSubarrays(int[] nums, int k) {
        int maxElement = nums.Max();
        long ans = 0;
        int start = 0;
        int maxElementsInWindow = 0;

        for(int end = 0; end < nums.Length; end++)
        {
            if(nums[end] == maxElement)
            {
                maxElementsInWindow++;
            }
            while(k == maxElementsInWindow)
            {
                if(nums[start] == maxElement)
                {
                    maxElementsInWindow--;
                }
                start++;
            }
            ans += start;
        }
        return ans;
    }
}