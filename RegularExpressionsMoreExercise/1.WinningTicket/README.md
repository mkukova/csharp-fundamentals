# 1.More Exercise: Regular Expressions

Problems for exercise and homework for the [&quot;C#  Fundamentals&quot; course @ SoftUni](https://softuni.bg/trainings/2363/csharp-fundamentals-may-2019)
You can check your solutions in [Judge](https://judge.softuni.bg/Contests/1754/)

1. 1.Winning Ticket

Lottery is exciting. What is not, is checking a million tickets for winnings only by hand. So, you are given the task to create a program which automatically checks if a ticket is a winner.

You are given a **collection of tickets separated by commas and spaces**. You need to check every one of them if it has a winning combination of symbols.

**A valid ticket should have exactly 20 characters**. The winning symbols are &#39; **@**&#39;, &#39; **#**&#39;, &#39; **$**&#39; and &#39; **^**&#39;. But in order for a ticket to be a winner the symbol should uninterruptedly repeat for at least **6 times** in both the **tickets left half** and the **tickets right half**.

For example, a valid winning ticket should be something like this:

&quot; **Cash$$$$$$Ca$$$$$$sh**&quot;

The left half &quot; **Cash$$$$$$**&quot; contains &quot; **$$$$$$**&quot;, which is also contained in the tickets right half &quot; **Ca$$$$$$sh**&quot;. A winning ticket should contain symbols repeating up to 10 times in both halves, which is considered a Jackpot (for example: &quot; **$$$$$$$$$$$$$$$$$$$$**&quot;).

### **Input**

The input will be read from the console. The input consists of a **single line** containing all tickets **separated by commas and one or more white spaces** in the format:

- **&quot;{ticket}, {ticket}, … {ticket}&quot;**

### **Output**

Print the result for every ticket in the order of their appearance, each on a separate line in the format:

- **Invalid ticket - &quot;invalid ticket&quot;**
- **No match - &quot;ticket &quot;{ticket}&quot; - no match&quot;**
- **Match with length 6 to 9 - &quot;ticket &quot;{ticket}&quot; - {match length}{match symbol}&quot;**
- **Match with length 10 - &quot;ticket &quot;{ticket}&quot; - {match length}{match symbol} Jackpot!&quot;**

### **Constrains**

- Number of tickets will be in range [0 … 100]

### **Examples**

| **Input** | **Output** |
| --- | --- |
| Cash$$$$$$Ca$$$$$$sh | ticket &quot;Cash$$$$$$Ca$$$$$$sh&quot; - 6$ |
| $$$$$$$$$$$$$$$$$$$$, aabb  , th@@@@@@eemo@@@@@@ey | ticket &quot;$$$$$$$$$$$$$$$$$$$$&quot; - 10$ Jackpot!invalid ticketticket &quot;th@@@@@@eemo@@@@@@ey&quot; - 6@ |
| validticketnomatch:( | ticket &quot;validticketnomatch:(&quot; - no match |

