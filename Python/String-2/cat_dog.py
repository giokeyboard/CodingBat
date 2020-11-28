def cat_dog(str):
    """
    Return True if the string "cat" and "dog" appear the same number of times in the given string.

    cat_dog('catdog') → True
    cat_dog('catcat') → False
    cat_dog('1cat1cadodog') → True
    """
    cat = 0
    dog = 0
    for i in range(len(str) - 2):
        if str[i:i + 3] == "cat":
            cat += 1
        if str[i:i + 3] == "dog":
            dog += 1
    return cat == dog


print(cat_dog('catdog'))
print(cat_dog('catcat'))
print(cat_dog('1cat1cadodog'))
