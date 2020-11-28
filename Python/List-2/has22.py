def has22(nums):
    """
    Given an array of ints, return True if the array contains a 2 next to a 2 somewhere.

    has22([1, 2, 2]) → True
    has22([1, 2, 1, 2]) → False
    has22([2, 1, 2]) → False
    """
    for i in range(len(nums) - 1):
        if nums[i] == 2 and nums[i + 1] == nums[i]:
            return True
    return False


print(has22([1, 2, 2]))
print(has22([1, 2, 1, 2]))
print(has22([2, 1, 2]))
