# 1.Lab: Strings and Text Processing

1. 5.Digits, Letters and Other

Write a program that receives a **single**** string **and on the** first ****line** prints **all the digits** , on the **second** – **all the letters** , and on the **third** – **all the other characters**. **There will always be at least one digit, one letter and one other characters.**

### Examples

| **Input** | **Output** |
| --- | --- |
| Agd#53Dfg^&amp;4F53 | 53453AgdDfgF#^&amp; |

### Hints

- Read the input.
- Use loop to iterate through all characters in the text. If the char is digit print it, otherwise ignore it.
  - Use char. **IsDigit** (char symbol)
- Do the same for the letters and other chars
  - Find something like IsDigit method for the letters.