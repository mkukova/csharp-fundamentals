﻿# 1.Lab: Strings and Text Processing


1. 4.Text Filter

Write a program that takes a **text** and a **string of banned words**. All words included in the ban list should be replaced with **asterisks**&quot; **\***&quot;, equal to the word&#39;s length. The entries in the ban list will be separated by a **comma** and **space**&quot; **,**&quot;.

The ban list should be entered on the first input line and the text on the second input line.

### Examples

| **Input** | **Output** |
| --- | --- |
| Linux, WindowsIt is not **Linux** , it is GNU/ **Linux**. **Linux** is merely the kernel, while GNU adds the functionality. Therefore we owe it to them by calling the OS GNU/ **Linux**! Sincerely, a **Windows** client | It is not \*\*\*\*\*, it is GNU/\*\*\*\*\*. \*\*\*\*\* is merely the kernel, while GNU adds the functionality. Therefore we owe it to them by calling the OS GNU/\*\*\*\*\*! Sincerely, a \*\*\*\*\*\*\* client |

### Hints

- Read the input.
- Replace all ban words in the text with asterisk (\*).
  - Use the built-in method **Replace** (banWord, replacement).
  - Use **new string(**char ch, int repeatCount**)** to create the replacement

