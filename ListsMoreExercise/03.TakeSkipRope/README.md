# 1.More Exercises: Lists

Problems for exercise and homework for the [&quot;C#  Fundamentals&quot; course @ SoftUni](https://softuni.bg/modules/57/tech-module-4-0)
You can check your solutions here: [Ju](https://judge.softuni.bg/Contests/1300)[dge](https://judge.softuni.bg/Contests/1300)

1. 3.Take/Skip Rope

Write a program, which reads a **string** and **skips** through it, extracting a **hidden message**. The algorithm you have to implement is as follows:

Let&#39;s take the string &quot; **skipTest\_String044170**&quot; as an example.

Take every **digit** from the string and **store it** somewhere. After that, **remove** all the digits from the string. After this operation, you should have **two lists of items** : the **numbers list** and the **non-numbers list** :

- Numbers list: **[0, 4, 4, 1, 7, 0]**
- Non-numbers: **[s, k, i, p, T, e, s, t, \_, S, t, r, i, n, g]**

After that, take every digit in the **numbers list** and split it up into a **take list** and a **skip list** , depending on whether the digit is in an **even** or an **odd** index:

- Numbers list: **[****0 ****,**  **4**** , **** 4 ****,**  **1**** , **** 7 ****,**  **0****]**
- Take list: **[****0 ****,**  **4**** , **** 7****]**
- Skip list: **[****4 ****,**  **1**** , **** 0****]**

Afterwards, **iterate** over both of the lists and **skip**** {skipCount} **characters from the** non-numbers list **, then** take **** {takeCount} **characters and store it in a** result string **. Note that the skipped characters are** summed up **as they go. The process would look like this on the aforementioned** non-numbers list**:

1. Take **0** characters Taken: &quot;&quot;, skip **4** characters (total **0** ) Skipped: &quot; **skipTest\_String**&quot; Result: &quot;&quot;
2. Take **4** characters Taken: &quot; **Test&quot;** , skip **1** characters (total **4** ) Skipped: &quot; **skip**&quot; Result: &quot; **Test**&quot;
3. Take **7** characters Taken: &quot; **String**&quot;, skip **0** characters (total **9** ) Skipped: &quot;&quot; Result: &quot; **TestString**&quot;

After that, just print the **result string** on the console.

### Input

- First line: The **encrypted** message as a **string**

### Output

- First line: The **decrypted** message as a **string**

### Constraints

- The count of digits in the input string will **always be even**.
- The encrypted message will contain any printable ASCII character.

### Examples

| **Input** | **Output** |
| --- | --- |
| T2exs15ti23ng1\_3cT1h3e0\_Roppe | TestingTheRope |
| O{1ne1T2021wf312o13Th111xreve!!@! | OneTwoThree!!! |
| this forbidden mess of an age rating 0127504740 | hidden message |

