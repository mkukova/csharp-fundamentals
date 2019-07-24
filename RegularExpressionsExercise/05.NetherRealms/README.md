## 1.Exercise: Regular Expressions

Problems for exercise and homework for the [&quot;C#  Fundamentals&quot; course @ SoftUni](https://softuni.bg/trainings/2363/csharp-fundamentals-may-2019)
You can check your solutions in [Judge](https://judge.softuni.bg/Contests/1668/)

1. 5.\*Nether Realms

Mighty battle is coming. In the stormy nether realms, demons are fighting against each other for supremacy in a duel from which only one will survive.

Your job, however is not so exciting. You are assigned to **sign in all the participants** in the nether realm&#39;s mighty battle&#39;s demon book, which of course is **sorted alphabetically**.

A demon&#39;s **name contains his health and his damage**.

The **sum of the asci codes** of **all characters** (excluding numbers (0-9), arithmetic symbols ( **&#39;+&#39;, &#39;-&#39;, &#39;\*&#39;, &#39;/&#39;** ) and delimiter dot ( **&#39;.&#39;** )) gives a **demon&#39;s total health**.

**The sum of all numbers** in his name forms his base damage. Note that you should consider the plus **&#39;+&#39;** and minus **&#39;-&#39;** signs (e.g. **+10 is 10** and **-10 is -10** ). However, there are some symbols ( **&#39;\*&#39;** and **&#39;/&#39;** ) that can further **alter the base damage by multiplying or dividing it by 2** (e.g. in the name &quot;m **15** \*/c **-5.0**&quot;, the base damage is **15 + (-5.0) = 10** and then you need to multiply it by 2 (e.g. 10 \* 2 = 20) and then divide it by 2 (e.g. 20 / 2 = 10)).

So, **multiplication and division** are applied **only after all numbers are included** in the calculation and **in the order they appear in the name**.

You will get all demons **on a single line** , separated by commas and zero or more blank spaces. Sort them in **alphabetical order** and print their names **along their health and damage**.

### Input

The input will be read from the console. The input consists of a **single line** containing all demon names **separated by commas and zero or more spaces** in the format: **&quot;{demon name}, {demon name}, … {demon name}&quot;**

### Output

Print all demons **sorted by their name in ascending order** , each on a separate line in the format:

- **&quot;{demon name} - {health points} health, {damage points} damage&quot;**

### Constraints

- A demon&#39;s name will contain **at least one character**
- A demon&#39;s name **cannot contain** blank spaces &#39; &#39; or commas &#39;,&#39;
- A **floating point number will always have digits before and after its decimal separator**
- **Number** in a demon&#39;s name **is considere** d everything that is a valid integer or floating point number (with dot &#39;.&#39; used as separator). For example, all these are valid numbers: &#39;4&#39;, &#39;+4&#39;, &#39;-4&#39;, &#39;3.5&#39;, &#39;+3.5&#39;, &#39;-3.5&#39;

### Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| M3ph-0.5s-0.5t0.0\*\* | M3ph-0.5s-0.5t0.0\*\* - 524 health, 8.00 damage | M3ph-0.5s-0.5t0.0\*\*:Health = &#39;M&#39; + &#39;p&#39; + &#39;h&#39; + &#39;s&#39; + &#39;t&#39; = 524 health.Damage = (3 + (-0.5) + (-0.5) + 0.0) \* 2 \* 2 = 8 damage. |
| **Input** | **Output** | **Comments** |
| M3ph1st0\*\*, Azazel | Azazel - 615 health, 0.00 damage M3ph1st0\*\* - 524 health, 16.00 damage  | Azazel: Health - &#39;A&#39; + &#39;z&#39; + &#39;a&#39; + &#39;z&#39; + &#39;e&#39; + &#39;l&#39; = 615 health. Damage - no digits = 0 damage. M3ph1st0\*\*:Health - &#39;M&#39; + &#39;p&#39; + &#39;h&#39; + &#39;s&#39; + &#39;t&#39; = 524 health.Damage - (3 + 1 + 0) \* 2 \* 2 = 16 damage. |
| Gos/ho | Gos/ho - 512 health, 0.00 damage |   |

