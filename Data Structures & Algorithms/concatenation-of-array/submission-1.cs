public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int n = nums.Length;
        int[] output = new int [2 * n];
        for (int i = 0; i < n; i++) {
            output[i] = output[i + n] = nums[i];
        }
        return output;
    }
}