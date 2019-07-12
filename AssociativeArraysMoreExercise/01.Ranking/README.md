## Problem 1.More Exercise: Associative Arrays

Problems for exercise and homework for the [&quot;C#  Fundamentals&quot; course @ SoftUni](https://softuni.bg/trainings/2363/csharp-fundamentals-may-2019)
You can check your solutions in [Judge](https://judge.softuni.bg/Contests/1302)

1. 1.Ranking

Here comes the final and the most interesting part – the Final ranking of the candidate-interns. The final ranking is determined by the points of the interview tasks and from the exams in SoftUni. Here is your final task. You will receive some lines of input in the format **&quot;{contest}:{password for contest}&quot;** until you receive **&quot;end of contests&quot;**. Save that data because **you will need it later**. After that you will receive other type of inputs in format **&quot;{contest}=\&gt;{password}=\&gt;{username}=\&gt;{points}&quot;** until you receive **&quot;end of submissions&quot;**. Here is what you need to do.

- Check if the **contest is valid (if you received it in the first type of input)**
- Check if the **password is correct for the given contest**
- Save the user with the contest they take part in **(a user can take part in many contests)** and the points the user has in the given contest. If you receive the **same contest and the same user update the points only if the new ones are more than the older ones.**

At the end you have to print the info for the user with the **most points** in the format **&quot;Best candidate is {user} with total {total points} points.&quot;**. After that print **all students ordered by their names**. **For each user print each contest with the points in descending order**. See the examples.

### Input

- strings in format **&quot;{contest}:{password for contest}&quot;** until the **&quot;end of contests&quot;** There will be no case with two equal contests
- strings in format **&quot;{contest}=\&gt;{password}=\&gt;{username}=\&gt;{points}&quot;** until the **&quot;end of submissions&quot;**
- **There will be no case with 2 or more users with same total points!**

### Output

- On the first line print the best user in format **&quot;Best candidate is {user} with total {total points} points.&quot;.**
- Then print all students ordered as mentioned above in format:

**{user1 name}**

**#  {contest1} -\&gt; {points}**

**#  {contest2} -\&gt; {points}**

### Constraints

- the strings may contain any ASCII character except from **(:, =, \&gt;)**
- the numbers will be in range **[0 - 10000]**
- second input is always valid

### Examples

| **Input** | **Output** |
| --- | --- |
| Part One Interview:successJs Fundamentals:PeshoC# Fundamentals:fundPassAlgorithms:funend of contestsC# Fundamentals=\&gt;fundPass=\&gt;Tanya=\&gt;350Algorithms=\&gt;fun=\&gt;Tanya=\&gt;380Part One Interview=\&gt;success=\&gt;Nikola=\&gt;120Java Basics Exam=\&gt;pesho=\&gt;Petkan=\&gt;400Part One Interview=\&gt;success=\&gt;Tanya=\&gt;220OOP Advanced=\&gt;password123=\&gt;BaiIvan=\&gt;231C# Fundamentals=\&gt;fundPass=\&gt;Tanya=\&gt;250C# Fundamentals=\&gt;fundPass=\&gt;Nikola=\&gt;200Js Fundamentals=\&gt;Pesho=\&gt;Tanya=\&gt;400end of submissions | Best candidate is Tanya with total 1350 points.Ranking: Nikola#  C# Fundamentals -\&gt; 200#  Part One Interview -\&gt; 120Tanya#  Js Fundamentals -\&gt; 400#  Algorithms -\&gt; 380#  C# Fundamentals -\&gt; 350#  Part One Interview -\&gt; 220 |
| Java Advanced:funpassPart Two Interview:successMath Concept:asdasdJava Web Basics:forrFend of contestsMath Concept=\&gt;ispass=\&gt;Monika=\&gt;290Java Advanced=\&gt;funpass=\&gt;Simona=\&gt;400Part Two Interview=\&gt;success=\&gt;Drago=\&gt;120Java Advanced=\&gt;funpass=\&gt;Petyr=\&gt;90Java Web Basics=\&gt;forrF=\&gt;Simona=\&gt;280Part Two Interview=\&gt;success=\&gt;Petyr=\&gt;0Math Concept=\&gt;asdasd=\&gt;Drago=\&gt;250Part Two Interview=\&gt;success=\&gt;Simona=\&gt;200end of submissions | Best candidate is Simona with total 880 points.Ranking: Drago#  Math Concept -\&gt; 250#  Part Two Interview -\&gt; 120Petyr#  Java Advanced -\&gt; 90#  Part Two Interview -\&gt; 0Simona#  Java Advanced -\&gt; 400#  Java Web Basics -\&gt; 280#  Part Two Interview -\&gt; 200 |

