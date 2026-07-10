public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
       int max = 0; int run = 0;

        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == 0) {
                run = 0;
                continue;
            }
            run++;
            max = Math.Max(max, run);
        }

        return max;
    }
}