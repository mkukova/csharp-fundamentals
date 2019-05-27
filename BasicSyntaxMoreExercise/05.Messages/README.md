## 1.More Exercise: C# Intro and Basic Syntax

1. 5.Messages

Write a program, which emulates **typing an SMS** , following this guide:

| **1** | **2** abc | **3** def |
| --- | --- | --- |
| **4** ghi | **5** jkl | **6** mno |
| **7** pqrs | **8** tuv | **9** wxyz |
|   | **0** space |   |

Following the guide, **2** becomes &quot; **a**&quot;, **22** becomes &quot; **b**&quot; and so on.

### Examples

| **Input** | **Output** |   | **Input** | **Output** |   | **Input** | **Output** |
| --- | --- | --- | --- | --- | --- | --- | --- |
| 54433555555666 | hello | 9443399908443377733 | hey there | 76333380633 | meet me |

### Hints

- A native approach would be to just put all the possible combinations of digits in a giant **switch** statement.
- A cleverer approach would be to come up with a **mathematical formula** , which **converts** a **number** to its **alphabet** representation:

| **Digit** | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- |
|
- **Index**
 |
- 0 1 2
 |
- 3 4 5
 |
- 6 7 8
 |
- 9 11 12
 |
- 13 14 15
 |
- 16 17 18 19
 |
- 20 21 22
 |
- 23 24 25 26
 |
|
- **Letter**
 |
- a b c
 |
- d e f
 |
- g h i
 |
- j  k  l
 |
- m  n  o
 |
- p  q  r  s
 |
- t u v
 |
- w  x  y  z
 |

- Let&#39;s take the number **222** ( **c** ) for example. Our algorithm would look like this:
  - Find the **number of digits** the number has &quot;e.g. **222**** 3 digits**&quot;
  - Find the **main digit** of the number &quot;e.g.   **222**** 2**&quot;
  - Find the **offset** of the number. To do that, you can use the formula: **(main digit - 2) \* 3**
  - If the main digit is **8 or 9** , we need to **add 1** to the **offset** , since the digits **7** and **9** have **4 letters each**
  - Finally, find the **letter index** (a 0, c 2, etc.). To do that, we can use the following formula: **(offset + digit length - 1)**.
  - After we&#39;ve found the **letter index** , we can just add that to **the ASCII code** of the lowercase letter &quot; **a**&quot; (97)