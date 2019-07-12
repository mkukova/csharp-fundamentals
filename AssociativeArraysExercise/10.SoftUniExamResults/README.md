# 1.Exercise: Associative Arrays

1. 10.\*SoftUni Exam Results

Judge statistics on the last Programing Fundamentals exam was not working correctly, so you have the task to take all the submissions and analyze them properly. You should collect all the submissions and print the final results and statistics about each language that the participants submitted their solutions in.

You will be receiving lines in the following format: **&quot;{username}-{language}-{points}&quot;**  **until you receive**  **&quot;exam finished&quot;**.You should store each username and his submissions and points.
You can receive a **command to ban** a user for cheating in the following format: **&quot;{username}-banned&quot;.** In that case, you should **remove** the user from the contest, but **preserve his submissions in the total count of submissions for each language**.

After receiving **&quot;exam finished&quot;** print each of the participants, ordered descending by their max points, then by username, in the following format:

Results:

{username} | {points}

…

After that print each language, used in the exam, ordered descending by total submission count and then by language name, in the following format:

Submissions:

{language} – {submissionsCount}

…

### Input / Constraints

Until you receive &quot;exam finished&quot; you will be receiving participant submissions in the following format: **&quot;{username}-{language}-{points}&quot;**.

You can receive a ban command -\&gt; **&quot;{username}-banned&quot;**

The points of the participant will always be a **valid integer in the range [0-100];**

### Output

- Print the exam results for each participant, ordered descending by max points and then by username, in the following format:

Results:

{username} | {points}

…

- After that print each language, ordered descending by total submissions and then by language name, in the following format:

Submissions:

{language} – {submissionsCount}

…

- Allowed working **time** / **memory** : **100ms** / **16MB**.

### Examples

| **Input** | **Output** | **Comment** |
| --- | --- | --- |
| Pesho-Java-84Gosho-C#-84Gosho-C#-70Kiro-C#-94exam finished | Results:Kiro | 94Gosho | 84Pesho | 84Submissions:C# - 3Java - 1 | We order the participant descending by max points and then by name, printing only the username and the max points.After that we print each language along with the count of submissions, ordered descending by submissions count, and then by language name. |
| Pesho-Java-91Gosho-C#-84Kiro-Java-90Kiro-C#-50Kiro-bannedexam finished | Results:Pesho | 91Gosho | 84Submissions:C# - 2Java - 2 | Kiro is banned so he is removed from the contest, but he`s submissions are still preserved in the languages submissions count. So althou there are only 2 participants in the results, there are 4 submissions in total. |