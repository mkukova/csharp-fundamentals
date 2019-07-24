# 1.More Exercise: Regular Expressions

Problems for exercise and homework for the [&quot;C#  Fundamentals&quot; course @ SoftUni](https://softuni.bg/trainings/2363/csharp-fundamentals-may-2019)
You can check your solutions in [Judge](https://judge.softuni.bg/Contests/1754/)

1. 2.Rage Quit

Every gamer knows what rage-quitting means. It&#39;s basically when you&#39;re just not good enough and you blame everybody else for losing a game. You press the CAPS LOCK key on the keyboard and flood the chat with gibberish to show your frustration.

Chochko is a gamer, and a bad one at that. He asks for your help; he wants to be the most annoying kid in his team, so when he rage-quits he wants something truly spectacular. He&#39;ll give you **a series of strings followed by non-negative numbers** , e.g. &quot;a3&quot;; you need to print on the console **each string repeated N times** ; **convert the letters to uppercase beforehand**. In the example, you need to write back &quot;AAA&quot;.

On the output, print first a statistic of the **number of unique symbols** used (the casing of letters is irrelevant, meaning that &#39; **a**&#39; and &#39; **A**&#39; are the same); the format shoud be **&quot;Unique symbols used {0}&quot;**. Then, **print the rage message** itself.

The **strings and numbers will not be separated by anything**. The input will always start with a string and for each string there will be a corresponding number. The entire input will be given on a **single line** ; Chochko is too lazy to make your job easier.

### Input

- The input data should be read from the console.
- It consists of a single line holding a series of **string-number sequences**.
- The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

- The output should be printed on the console. It should consist of **exactly two lines**.
- On the first line, print the **number of unique symbols used** in the message.
- On the second line, print the **resulting rage message** itself.

### Constraints

- The count of **string-number pairs** will be in the range [1 … 20 000].
- Each string will contain any character **except digits**. The **length** of each string will be in the range [1 … 20].
- The **repeat count** for each string will be an integer in the range [0 … 20].
- Allowed working time for your program: 0.3 seconds. Allowed memory: 64 MB.

### Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| a3 | Unique symbols used: 1AAA | We have just one string-number pair. The symbol is &#39;a&#39;, convert it to uppercase and repeat 3 times: AAA.Only one symbol is used (&#39;A&#39;). |
| aSd2&amp;5s@1 | Unique symbols used: 5ASDASD&amp;&amp;&amp;&amp;&amp;S@ | &quot;aSd&quot; is converted to &quot;ASD&quot; and repeated twice; &quot;&amp;&quot; is repeated 5 times; &quot;s@&quot; is converted to &quot;S@&quot; and repeated once.5 symbols are used: &#39;A&#39;, &#39;S&#39;, &#39;D&#39;, &#39;&amp;&#39; and &#39;@&#39;. |

