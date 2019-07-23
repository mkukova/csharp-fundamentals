# 1.Lab: Strings and Text Processing

1. 3.Substring

On the **first line** you will receive a **string**. On the **second line** you will receive a second **string**. Write a program that **removes**** all **of the** occurrences **of the** first **string** in **the** second ****until** there is **no match**. At the end **print** the **remaining string**.

### Examples

| **Input** | **Output** | **Comment** |
| --- | --- | --- |
| Icekicegiciceeb | kgb | We remove ice once and we get &quot;kgiciceeb&quot;We match &quot;ice&quot; one more time and we get &quot;kgiceb&quot;There is one more match. The finam result is &quot;kgb&quot; |

### Hints

- Read the input.
- Find the first index where the key appears.
  - Use the built-in method **IndexOf** ()
- Remove the match.
  - Use the built-in method **Remove** (index, length)
- Repeat it until the text doesn&#39;t contain the key anymore.

