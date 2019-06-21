﻿# 1.Exercise: Lists

Problems for exercise and homework for the [&quot;C#  Fundamentals&quot; course @ SoftUni](https://softuni.bg/modules/57/tech-module-4-0)
You can check your solutions here: [Judge](https://judge.softuni.bg/Contests/1211)

1. 8.\*Anonymous Threat

_The Anonymous have created a cyber hypervirus, which steals data from the CIA. You, as the lead security developer in CIA, have been tasked to analyze the software of the virus and observe its actions on the data. The virus is known for his innovative and unbeleivably clever technique of merging and dividing data into partitions._

You will receive a **single input line,** containing **strings,** separated by **spaces**. The strings may contain **any ASCII** character except **whitespace**.Then you will begin receiving commands in one of the following formats:

- merge {startIndex} {endIndex}
- divide {index} {partitions}

Every time you receive the **merge command** , you must merge all elements from the **startIndex** , till the **endIndex**. In other words, you should concatenate them.
**Example** : **{abc, def, ghi} -\&gt; merge 0 1 -\&gt; {abcdef, ghi}**

If **any** of the **given indexes** is **out of the array** , you must take **only** the **range** that is **inside** the **array** and **merge** it.

Every time you receive the **divide command** , you must **divide** the **element** at the **given index** , into **several small substrings** with **equal length**. The **count** of the **substrings** should be **equal** to the **given partitions**.

**Example** : **{**** abcdef ****, ghi, jkl} -\&gt; divide**  **0**** 3 **** -\&gt; { ****ab**** , **** cd ****,**  **ef**** , ghi, jkl}**

If the string **cannot** be **exactly**** divided **into the** given partitions **,** make all partitions ****except** the **last** with **equal lengths** , and make the **last one** – **the**** longest**.

**Example** : **{abcd, efgh, ijkl} -\&gt; divide 0 3 -\&gt; {a, b, cd, efgh, ijkl}**

The **input ends** when you receive the command &quot; **3:1**&quot;. At that point you must print the **resulting elements** , **joined** by a **space**.

### Input

- The **first input line** will contain the **array** of **data**.
- On the **next several input** lines you will **receive commands** in the **format specified above**.
- The **input ends** when you receive the command &quot; **3:1****&quot;**.

### Output

- As output you must print a single line containing the elements of the array, **joined** by a **space**.

### Constrains

- The **strings** in the **array** may contain any **ASCII character** except **whitespace**.
- The **startIndex** and the **endIndex** will be in **range [-1000, 1000]**.
- The **endIndex** will **always** be **greater** than the **startIndex**.
- The **index** in the **divide command** will **always** be **inside** the array.
- The **partitions** will be in **range [0, 100]**.
- Allowed working **time/memory** : **100ms / 16MB**.

### Examples

| **Input** | **Output** |
| --- | --- |
| Ivo Johny Tony Bony Monymerge 0 3merge 3 4merge 0 33:1 | IvoJohnyTonyBonyMony |
| abcd efgh ijkl mnop qrst uvwx yzmerge 4 10divide 4 53:1 | abcd efgh ijkl mnop qr st uv wx yz |

