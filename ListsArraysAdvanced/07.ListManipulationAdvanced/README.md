# 1.Lab: Lists

Problems for in-class lab for the [&quot;C#  Fundamentals&quot; course @ SoftUni](https://softuni.bg/modules/57/tech-module-4-0)
You can check your solutions in [Judge](https://judge.softuni.bg/Contests/1210)

1. 7.List Manipulation Advanced

Next, we are going to implement more complicated list commands, **extending the previous task**. Again, read a list and keep reading commands until you receive **&quot;end&quot;** :

**Contains {number}** – check if the list contains the number and if so - print **&quot;Yes**&quot;, **otherwise** print **&quot;No such number&quot;**.
**PrintEven** – print **all the even numbers** , **separated by a space**.
**PrintOdd** – print **all the odd numbers, separated by a space**.
**GetSum** – print the **sum of all the numbers**.
**Filter {condition} {number}** – print all the numbers that **fulfill the given condition**. The condition will be either &#39; **\&lt;**&#39;, &#39; **\&gt;**&#39;, &quot; **\&gt;=**&quot;,&quot; **\&lt;=**&quot;.

**After** the **end**** command, **print the list** only if **you have made some** changes **to the** original list **.** Changes **are made** only **from the commands from the** previous task**.

### Example

| **Input** | **Output** |
| --- | --- |
| 2 13 43 876 342 23 543Contains 100Contains 543PrintEvenPrintOddGetSumFilter \&gt;= 43Filter \&lt; 100end | No such numberYes2 876 34213 43 23 543184243 876 342 5432 13 43 23 |