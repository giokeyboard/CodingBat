def string_splosion(str):
    """

    Given a non-empty string like "Code" return a string like "CCoCodCode".


    string_splosion('Code') → 'CCoCodCode'
    string_splosion('abc') → 'aababc'
    string_splosion('ab') → 'aab'
    """
    result = ""
    for i in range(len(str) + 1):
        result += str[:i]
    return result


print(string_splosion('Code'))
print(string_splosion('abc'))
print(string_splosion('ab'))
