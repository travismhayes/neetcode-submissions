public class Solution {
    public bool hasDuplicate(int[] nums) {
       // 1,2,3,3 => true assuming sorted
       // if assmuption true then just 
       // loop through check for duplicates, if found return true else false.
        Array.Sort(nums);

       for (int i = 0; i < nums.Length - 1; i++) {
        if (nums[i] == nums[i + 1]) {
            return true;
        }
       }
       return false;
    }    
}