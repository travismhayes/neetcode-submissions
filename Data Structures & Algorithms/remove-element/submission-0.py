class Solution:
    def removeElement(self, nums: List[int], val: int) -> int:
        nextPosition = 0

        for currentIndex in range(len(nums)):
            if nums[currentIndex] != val:
                nums[nextPosition] = nums[currentIndex]
                nextPosition += 1
        
        return nextPosition
