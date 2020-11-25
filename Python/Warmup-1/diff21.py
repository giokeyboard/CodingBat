def diff21(n):
    """
    Given an int n, return the absolute difference between n and 21,
    except return double the absolute difference if n is over 21.


    diff21(19) → 2\n
    diff21(10) → 11\n
    diff21(21) → 0\n
    """
    return 2 * (abs(n - 21)) if n > 21 else abs(n - 21)


print(diff21(19))
print(diff21(10))
print(diff21(21))
