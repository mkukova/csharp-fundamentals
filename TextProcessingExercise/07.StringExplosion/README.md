## Problem 1.Exercise: Strings and Text Processing

Problems for exercise and homework for the [&quot;C#  Fundamentals&quot; course @ SoftUni](https://softuni.bg/trainings/2363/csharp-fundamentals-may-2019)
You can check your solutions here: [Judge](https://judge.softuni.bg/Contests/1217)


1. 7. String Explosion

Explosions are marked with **&#39;**** \&gt; ****&#39;**. Immediately after the mark, there will be an **integer** , which signifies the **strength** of the explosion.

You should **remove**  **x**  **characters** (where **x** is the **strength** of the explosion), **starting after** the punch **character** ( **&#39;**** \&gt; ****&#39;** ).

If you find **another** explosion mark ( **&#39;**** \&gt; ****&#39;** ) while you&#39;re deleting characters, you should **add** the **strength** to your **previous**** explosion**.

When all characters are processed, **print** the string **without** the **deleted**** characters**.

You should **not** delete the **explosion** character – **&#39;**** \&gt; ****&#39;** , but you should **delete** the **integers** , which represent the **strength**.

### Input

You will receive **single**** line** with the string.

### Output

Print what is left from the string after explosions.

### Constraints

- You will **always** receive a **strength** for the punches
- The path will consist only of letters from the **Latin**** alphabet **,** integers **and the char**&#39; ****\&gt;****&#39;**
- The strength of the punches will be in the interval [0…9]

### Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| abv\&gt;1\&gt;1\&gt;2\&gt;2asdasd | abv\&gt;\&gt;\&gt;\&gt;dasd | 1stexplosion is at index **3** and it is with **strength** of **1**. We delete **only** the **digit**** after **the explosion character. The string will look like this:** abv ****\&gt;**** \&gt;1\&gt;2\&gt;2asdasd **2nd explosion is with strength** one **and the string transforms to this:** abv ****\&gt;**** \&gt; ****\&gt;2\&gt;2asdasd** 3rd explosion is now with strength of 2. We delete the digit and we find **another** explosion. At this point the string looks like this: **abv**** \&gt; ****\&gt;**** \&gt; ****\&gt;2asdasd**. 4th explosion is with strength **2**. We have **1** strength **left** from the previous explosion, we **add** the strength of the **current** explosion to what is **left** and that adds up to a **total** strength of **3**. We **delete** the next **three**** characters **and we** receive **the** string ****abv**** \&gt; ****\&gt;**** \&gt; ****\&gt;**** dasd **We do** not **have** any more explosions **and we print the result:** abv\&gt;\&gt;\&gt;\&gt;dasd** |
| pesho\&gt;2sis\&gt;1a\&gt;2akarate\&gt;4hexmaster | pesho\&gt;is\&gt;a\&gt;karate\&gt;master |   |

