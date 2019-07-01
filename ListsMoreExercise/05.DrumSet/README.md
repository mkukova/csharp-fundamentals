# 1.More Exercises: Lists

Problems for exercise and homework for the [&quot;C#  Fundamentals&quot; course @ SoftUni](https://softuni.bg/modules/57/tech-module-4-0)
You can check your solutions here: [Ju](https://judge.softuni.bg/Contests/1300)[dge](https://judge.softuni.bg/Contests/1300)

1. 5.\*Drum Set

Gabsy is Orgolt&#39;s Final Revenge charming drummer. She has a drum set but the different drums have different origins – some she bought, some are gifts, so they are all with **different quality**. Every day she practices on each of them, so she does damage and reduces the drum`s quality. Sometimes a drum brakes, so she needs to buy new one. Help her keep her drum set organized.

You will receive Gabsy&#39;s **savings** , the money she can spend on new drums. Next you will receive a **sequence**** of integers ****,** which represents the **initial quality** of each drumin Gabsy&#39;s drum set.

Until you receive the command **&quot;Hit it again, Gabsy!&quot;** ,you will be receiving an integer: the **hit power** Gabsy applies **on each drum**** , **while practicing. When the power is applied, you should** decrease **the value of the drum&#39;s quality with the** current ****power**.

When a certain drum **reaches 0 quality** , it breaks. Then Gabsy should buy a replacement.She needs to buy the exact same model. Therefore, its quality will be **the same as the initial quality** of the broken drum. The price is calculated by the formula: {initialQuality} \* 3. Gabsy will always replace her broken drums **until the moment she can no longer afford it**. If she doesn&#39;t have enough money for a replacement, the broken drum is **removed** from the drum set.

When you receive the command **&quot;Hit it again, Gabsy!&quot;** ,the program ends and you should print the current state of the drum set. On the second line you should print the **remaining money** in Gabsy&#39;s savings account.

### Input

- On the **first line** you will receive the **savings** – a floating-point number.
- On the **second line** you will recieve the **drum set** : a **sequence** of **integers** , **separated** by **spaces**.
- Until you receive the command **&quot;Hit it again, Gabsy!&quot;**** , **you will be receiving** integers** – the hit power Gabsy applies on each drum.

### Output

- On the first line you should print **each drum** in the drum set, **separated** by **space**.
- Then you must print the **money** that are left on the **second line** in the format **&quot;Gabsy has {money left}lv.&quot;** , formatted with two digits after the decimal point.

### Constraints

- The **savings –**  **a** **floating-point number in the range [0.00, 10000.00]**
- The **quality**  **of each drum in the drum set** – an integer in the range **[1, 1000]**.
- The **hit**** power **will be in the** range [0, 1000]**

- Allowed working **time** / **memory** : **100ms** / **16MB**.

### Examples

| **Input** | **Output** | **Comment** |
| --- | --- | --- |
| 1000.0058 65 3311121810Hit it again, Gabsy! | 7 14 23Gabsy has 901.00lv. | DrumSet – 58 65 33.Day 1: hit power applied = 11 =\&gt; 47 54 22;Day 2: hit power applied = 12 =\&gt; 35 42 10;Day 3: hit power applied = 18 =\&gt; 17 24 -8;The third drum breaks. But Gabsy has enough savings, so she replaces it =\&gt; 17 24 33;Day 4: hit power applied = 10 =\&gt; 7 14 23;We print the current state of the drum set and what&#39;s left in Gabsy&#39;s bank account. |
| 154.0055 111 3 5 8 502508231Hit it again, Gabsy! | 27 2 4 7Gabsy has 10.00lv. |   |