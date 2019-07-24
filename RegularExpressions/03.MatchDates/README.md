# 1.Lab: Regular Expressions C#

1. 3.Match Dates

Write a program, which matches a date in the format &quot; **dd{separator}MMM{separator}yyyy**&quot;. Use **named**** capturing groups** in your regular expression.

### Compose the Regular Expression

Every valid date has the following characteristics:

- Always starts with **two digits** , followed by a **separator**
- After that, it has **one uppercase** and **two lowercase** letters (e.g. **Jan** , **Mar** ).
- After that, it has a **separator** and **exactly 4 digits** (for the year).
- The separator could be either of three things: a period (&quot; **.**&quot;), a hyphen (&quot; **-**&quot;) or a forward slash (&quot; **/**&quot;)
- The separator needs to be **the same** for the whole date (e.g. 13 **.** 03 **.** 2016 is valid, 13 **.** 03 **/** 2016 is **NOT** ). Use a **group backreference** to check for this.

You can follow the table below to help with composing your RegEx:

| **Match ALL of these** | **Match NONE of these** |
| --- | --- |
| 13/Jul/1928, 10-Nov-1934, 25.Dec.1937 | 01/Jan-1951, 23/sept/1973, 1/Feb/2016 |

Use **named capturing groups** for the **day** , **month** and **year**.

Since this problem requires more complex RegEx, which includes **named capturing groups** , we&#39;ll take a look at how to construct it:

- First off, we don&#39;t want anything at the **start** of our date, so we&#39;re going to use a **word boundary**&quot; **\b**&quot;:
- Next, we&#39;re going to match the **day** , by telling our RegEx to match **exactly two digits** ,and since we want to **extract** the day from the match later, we&#39;re going to put it in a **capturing group** :
We&#39;re also going to give our group a **name** , since it&#39;s easier to navigate by **group name** than by **group index** :
- Next comes the separator – either a **hyphen** , **period** or **forward slash**. We can use a **character class** for this:
Since we want to use the separator we matched here to match the **same separator** further into the date, we&#39;re going to put it in a **capturing group** :
- Next comes the **month** , which consists of a **capital Latin letter** and **exactly two lowercase Latin letters** :
- Next, we&#39;re going to match the **same separator**** we matched earlier **. We can use a** backreference** for that:
- Next up, we&#39;re going to match the year, which consists of **exactly 4 digits** :
- Finally, since we don&#39;t want to match the date if there&#39;s anything else **glued to it** , we&#39;re going to use another **word boundary** for the end:

Now it&#39;s time to find all the **valid dates** in the input and **print each date** in the following format: &quot; **Day: {day}, Month: {month}, Year: {year}**&quot;, each on a **new line**.

### Implement the Solution in C#

First off, we&#39;re going to put our RegEx in a variable and get a **MatchCollection** from the string:

Since RegEx works differently across different languages, before we continue, we&#39;re going to **set our backreference from**  **\2**  **to**  **\1**. This is because **C# backreferences** don&#39;t count **named capture groups for backreferences**. So, **change it before we continue**.

Next, we&#39;re going to **iterate** over every single **Match** and **extract** the **day** , **month** and **year** from the **groups**. We can use a special syntax in C# to get a match&#39;s group **value** by its **key** , the **same way** as when we access a **Dictionary**&#39;s values:

### Examples

| **Input** |
| --- |
| 13/Jul/1928, 10-Nov-1934, , 01/Jan-1951,f 25.Dec.1937 23/09/1973, 1/Feb/2016 |
| **Output** |
| Day: 13, Month: Jul, Year: 1928Day: 10, Month: Nov, Year: 1934Day: 25, Month: Dec, Year: 1937 |