def xyz_there(str):
    """
    Return True if the given string contains an appearance of "xyz" where the xyz is not directly
    preceded by a period (.).
    So "xxyz" counts but "x.xyz" does not.

    xyz_there('abcxyz') → True
    xyz_there('abc.xyz') → False
    xyz_there('xyz.abc') → True
    """
    if not "xyz" in str:
        return False

    for i in range(0, len(str) - 2):
        if str[i: i + 3] == "xyz" and (i == 0 or not str[i - 1] == "."):
            return True
    return False


print(xyz_there('abcxyz'))
print(xyz_there('abc.xyz'))
print(xyz_there('xyz.abc'))
