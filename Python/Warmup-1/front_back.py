def front_back(str):
    """
    Given a string, return a new string where the first and last chars have been exchanged.


    front_back('code') → 'eodc'
    front_back('a') → 'a'
    front_back('ab') → 'ba'
    """
    return str if len(str) < 2 else str[len(str) - 1] + str[1:len(str)-1] + str[0]


print(front_back('code'))
print(front_back('a'))
print(front_back('ab'))
