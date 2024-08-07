// https://leetcode.com/problems/two-sum/submissions/1216198600

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for(int i = 0; i < nums.Length; i++)
        {
            for(int o = 0; o < nums.Length; o++)
            {
                if(i != o)
                {
                    int sum = nums[i] + nums[o];
                    if(sum == target)
                    {
                        int[] answer = new int[2] {i, o};
                        return answer;
                    }
                }
            }
        }
        int[] noanswer = new int[0];
        return noanswer;
    }
}