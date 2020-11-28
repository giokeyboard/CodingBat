def double_char(str):
    """
    Given a string, return a string where for every char in the original, there are two chars.


    double_char('The') → 'TThhee'
    double_char('AAbb') → 'AAAAbbbb'
    double_char('Hi-There') → 'HHii--TThheerree'
    """
    out = ""
    for char in str:
        out += char * 2
    return out


print(double_char('The'))
print(double_char('AAbb'))
print(double_char('Hi-There'))
