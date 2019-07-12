## Problem 1.More Exercise: Associative Arrays

Problems for exercise and homework for the [&quot;C#  Fundamentals&quot; course @ SoftUni](https://softuni.bg/trainings/2363/csharp-fundamentals-may-2019)
You can check your solutions in [Judge](https://judge.softuni.bg/Contests/1302)

1. 2.Judge

You know the jude system, right?! Your job is to create a program similar to the Judge system.

You will receive **several input lines** in one of the following formats:

{username} -\&gt; {contest} -\&gt; {points}

The **constestName and username** are strings, the given **points** will be an integer number. You need to keep track of **every contest** and **individual statistics of every user**. You should **check if such contest already exists** , and if not, add it, otherwise **check if the current user Is participating in the contest** , if he is participating **take the higher score** , otherwise just **add it**.

Also you need to keep **individual statistics** for each **user -** the **total points of all constests**.

You should end your program when you receive the command **&quot;no more time&quot;**. At that point you should print each contest in **order of input** , for each contest print the participants **ordered by points in desecending order, than ordered by name in ascending order**.  After that, you should print **individual statistics for every participant** ordered by **total points** in **desecnding**** order **, and** then by alphabetical order**.

### Input / Constraints

- The input comes in the form of commands in one of the formats specified above.
- Username and contest name **always will be one word**.
- Points will be an integer will be an **integer** in **range [0, 1000]**.
- There will be **no invalid** input lines.
- If **all sorting criteria fail** , the order should be by **order** of **input**.
- The input ends when you receive the command **&quot;no more time&quot;**.

### Output

- The output format for the contests is:

{constestName}: {participants.Count} participants

{position}. {username} \&lt;::\&gt; {points}

- After you print all contests, print the **individual statistics for every participant.**
- The output format is:

Individual standings:

{position}. {username} -\&gt; {totalPoints}

### Examples

| **Input** | **Output** |
| --- | --- |
| Pesho -\&gt; Algo -\&gt; 400Gosho -\&gt; Algo -\&gt; 300Stamat -\&gt; Algo -\&gt; 200Pesho -\&gt; DS -\&gt; 150Mimi -\&gt; DS -\&gt; 600no more time | Algo: 3 participants1. Pesho \&lt;::\&gt; 4002. Gosho \&lt;::\&gt; 3003. Stamat \&lt;::\&gt; 200DS: 2 participants1. Mimi \&lt;::\&gt; 6002. Pesho \&lt;::\&gt; 150Individual standings:1. Mimi -\&gt; 6002. Pesho -\&gt; 5503. Gosho -\&gt; 3004. Stamat -\&gt; 200 |
| Pesho -\&gt; OOP -\&gt; 350Gosho -\&gt; OOP -\&gt; 250Stamat -\&gt; Advanced -\&gt; 600Gosho -\&gt; OOP -\&gt; 300Prakash -\&gt; OOP -\&gt; 300Prakash -\&gt; Advanced -\&gt; 250Ani -\&gt; JSCore -\&gt; 400no more time | OOP: 3 participants1. Pesho \&lt;::\&gt; 3502. Gosho \&lt;::\&gt; 3003. Prakash \&lt;::\&gt; 300Advanced: 2 participants1. Stamat \&lt;::\&gt; 6002. Prakash \&lt;::\&gt; 250JSCore: 1 participants1. Ani \&lt;::\&gt; 400Individual standings:1. Stamat -\&gt; 6002. Prakash -\&gt; 5503. Ani -\&gt; 4004. Pesho -\&gt; 3505. Gosho -\&gt; 300 |

