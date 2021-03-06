def sum_double(a, b):
    """
    Given two int values, return their sum. Unless the two values are the same, then return double their sum.


    sum_double(1, 2) → 3\n
    sum_double(3, 2) → 5\n
    sum_double(2, 2) → 8\n
    """
    return 2 * (a + b) if a == b else a + b


print(sum_double(1, 2))
print(sum_double(3, 2))
print(sum_double(2, 2))
