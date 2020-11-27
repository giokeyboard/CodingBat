def max_end3(nums):
    """
    Given an array of ints length 3, figure out which is larger, the first or last element in the array,
    and set all the other elements to be that value. Return the changed array.


    max_end3([1, 2, 3]) → [3, 3, 3]
    max_end3([11, 5, 9]) → [11, 11, 11]
    max_end3([2, 11, 3]) → [3, 3, 3]
    """
    max_item = max(nums[0], nums[2])
    nums = [max_item, max_item, max_item]
    return nums


print(max_end3([1, 2, 3]))
print(max_end3([11, 5, 9]))
print(max_end3([2, 11, 3]))
