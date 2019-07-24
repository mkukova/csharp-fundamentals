# 1.Lab: Regular Expressions C#


1. 2.Match Phone Number

Write a regular expression to match a **valid phone number** from **Sofia**. After you find all **valid phones** , **print** them on the console, separated by a **comma and a space**&quot; **,**&quot;.

### Compose the Regular Expression

A valid number has the following characteristics:

- It starts with &quot; **+359**&quot;
- Then, it is followed by the area code (always **2** )
- After that, it&#39;s followed by the **number** itself:
  - The number consists of **7 digits** (separated in **two**** groups **of** 3 **and** 4 ****digits** respectively).
- The different **parts** are **separated** by **either a space or a hyphen** (&#39; **-**&#39;).

You can use the following RegEx properties to **help** with the matching:

- Use **quantifiers** to match a **specific number** of **digits**
- Use a **capturing group** to make sure the delimiter is **only one of the allowed characters**** (space or hyphen) **and** not **a** combination**of both (e.g.**+359 ****2**** - ****111**** 111 **has** mixed delimiters **, it is** invalid**). Use a**group backreference** to achieve this.
- Add a **word boundary** at the **end** of the match to avoid **partial matches** (the last example on the right-hand side).
- Ensure that before the **&#39;+&#39;** sign there is either a **space** or the **beginning of the string**.

You can use the following table of values to test your RegEx against:

| **Match ALL of these** | **Match NONE of these** |
| --- | --- |
| +359 2 222 2222+359-2-222-2222 | 359-2-222-2222, +359/2/222/2222, +359-2 222 2222+359 2-222-2222, +359-2-222-222, +359-2-222-22222 |

### Implement the Solution in C#

Now it&#39;s time to write the solution, so let&#39;s start writing!

First, just like in the previous problem, put your RegEx in a variable:

After that, let&#39;s make a **MatchCollection** for our matches:

Let&#39;s try to print **all the matches** , using only a **single line**** of code **. Since** MatchCollection **is, as its name suggests, a** collection **, we can use** LINQ** methods on it.

In order to get all of the matches and put them into a string array, we need to perform several manipulations on the **MatchCollection** :

1. Cast every single element of the **MatchCollection** to the **Match** type using **Cast\&lt;Match\&gt;()**.
2. Since every element is a **Match** now, we can extract just the **Value** property of the match itself, which holds the **match value** as a **string** , using **Select()**. We can also **Trim()**  **the value** , to get rid of any **leading** or **trailing spaces**.
3. After getting the match value, we can use **ToArray()** to **convert** the collection to an **array**.

Here&#39;s what that looks like as a **LINQ** query:

After that, just print the valid phone number array, using **string.Join()**:

### Examples

| **Input** |
| --- |
| +359 2 222 2222,359-2-222-2222, +359/2/222/2222, +359-2 222 2222 +359 2-222-2222, +359-2-222-222, +359-2-222-22222 +359-2-222-2222 |
| **Output** |
| +359 2 222 2222, +359-2-222-2222 |

