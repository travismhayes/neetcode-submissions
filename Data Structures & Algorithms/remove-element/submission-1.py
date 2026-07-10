class Solution:
    def removeElement(self, nums: List[int], val: int) -> int:
        nextPosition = 0;

        for current in range(len(nums)):
            if nums[current] != val:
                nums[nextPosition] = nums[current]
                nextPosition += 1
            
        return nextPosition