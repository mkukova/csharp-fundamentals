# String Manipulator

Create a program that executes **changes**** over **a** string **. First, you** start **with an** empty string **, then you** receive ****commands**.

You will be receiving **commands** until the &quot; **End**&quot; command. There are **five** possible commands:

- **&quot;Add {string}&quot;**
  - **Concatenate**  **{string}**  **to the string**.
- &quot; **Upgrade {char}&quot;**
  - Find **all occurences** of **{char}** and **replace** it with **its ASCII code plus one**.
- &quot; **Print&quot;**
  - **Print** the **string**.
- &quot; **Index {char}&quot;**
  - Find the **all indeces where**  **{char}** occurs, then **print** them separated by a space. If no occurences - print &quot; **None**&quot;.
- &quot; **Remove {string}&quot;**
  - **Remove all occurrences** of **{string}** from the string.

## Input

- On each **line** , until the **&quot;**** End ****&quot;** command is received, you will be receiving commands.
- All commands are case **sensitive**.
- The **input** will **always** be **valid**.

## Output

- **Print** the **output** of every **command** in the **format**** described ****above**.

## Examples

| **Input** | **Output** |
| --- | --- |
| Add abracadabra
Print
Upgrade a
Print
Index b
Remove bbrb
Print
End | abracadabra
bbrbcbdbbrb
0 1 3 5 7 8 10
cbd |