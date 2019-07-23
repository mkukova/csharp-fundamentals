# 1.More Exercise: Strings and Text Processing

Problems for exercise and homework for the [&quot;C#  Fundamentals&quot; course @ SoftUni](https://softuni.bg/trainings/2363/csharp-fundamentals-may-2019)
You can check your solutions here: [Judge](https://judge.softuni.bg/Contests/1338)


1. 3.Treasure Finder

Write a program that **decrypts a message** by a given **key** and gathers information about hidden **treasure type** and its **coordinates.** On the **first line** you will receive a **key (sequence of numbers).** On the **next few lines until you receive &quot;find&quot;** you will get lines of **strings**. You have to **loop through every string** and **decrease the ascii code of each character** with a **corresponding number of the key** sequence. The way you choose a key number from the sequence is just **looping through it**. If the **length of the key** sequence is **less than the string** sequence, you start **looping from the beginning of the key.** For more clarification see the example below. **After decrypting** the message you will **get a type of treasure and its coordinates.** The **type** will be **between** the symbol **&#39;&amp;&#39;** and the coordinates will be between the symbols **&#39;\&lt;&#39;** and **&#39;\&gt;&#39;**. For each line **print the type and the coordinates** in format **&quot;Found {type} at {coordinates}&quot;.**

### Example

| **Input** | **Output** | **Comment** |
| --- | --- | --- |
| 1 2 1 3ikegfp&#39;jpne)bv=41P83X@ujfufKt)Tkmyft&#39;duEprsfjqbvfv=53V55XAfind | Found gold at 10N70WFound Silver at 32S43W | We start looping through the first string and the key. When we reach the end of the key we start looping from the beginning of the key, but we continue looping through the string. (until the string is over) The first message is: **&quot;hidden&amp;gold&amp;at\&lt;10N70W\&gt;&quot;** so we print we found gold at the given coordinates We do the same for the second string **&quot;thereIs&amp;Silver&amp;atCoordinates\&lt;32S43W\&gt;&quot;** (starting from the beginning of the key and the beginning of the string) |

