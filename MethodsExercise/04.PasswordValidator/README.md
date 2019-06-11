## 1.Exercise: Methods

1. 4.Password Validator

Write a program that checks if a given password is valid. Password rules are:

- **6 – 10 characters (inclusive)**
- **Consists only of letters and digits**
- **Have at least 2 digits**

If a password is valid print &quot;Password is valid&quot;. If it is not valid, for every unfulfilled rule print a message:

- **&quot;Password must be between 6 and 10 characters&quot;**
- **&quot;Password must consist only of letters and digits&quot;**
- **&quot;Password must have at least 2 digits&quot;**

### Examples

| **Input** | **Output** |
| --- | --- |
| logIn | Password must be between 6 and 10 charactersPassword must have at least 2 digits |
| MyPass123 | Password is valid |
| Pa$s$s | Password must consist only of letters and digitsPassword must have at least 2 digits |

### Hints

Write a method for each rule.

