## Problem 1.More Exercise: Associative Arrays

Problems for exercise and homework for the [&quot;C#  Fundamentals&quot; course @ SoftUni](https://softuni.bg/trainings/2363/csharp-fundamentals-may-2019)
You can check your solutions in [Judge](https://judge.softuni.bg/Contests/1302)

1. 3.MOBA Challenger

Pesho is a pro MOBA player, he is struggling to become а master of the Challenger tier. So he watches carefully the statistics in the tier.

You will receive **several input lines** in one of the following formats:

&quot;{player} -\&gt; {position} -\&gt; {skill}&quot;

&quot;{player} vs {player}&quot;

The **player and position** are strings, the given **skill** will be an integer number. You need to keep track of **every player**.

When you receive a **player and his position and skill** , add him to the player pool, if he isn`t present, **else add** his position and skill **or update** his skill, only if the current position skill is lower than the new value.

If you receive **&quot;{player} vs {player}&quot;** and **both players exist** in the tier, **they duel** with the following rules:

Compare their positions, **if they got at least one in common** , the player with better **total skill points** wins and the other is **demoted** from the tier -\&gt; remove him. If they have same total skill points, **the duel is tie** and they both continue in the Season.

If they don`t have positions in common, **the duel isn`t happening** and both continue in the Season.

You should end your program when you receive the command **&quot;Season end&quot;**. At that point you should print the players, **ordered by total skill in desecending order, then ordered by player name in ascending order**. **Foreach** player print their position and skill, **ordered desecending by skill, then ordered by position name in ascending order.**

### Input / Constraints

- The input comes in the form of commands in one of the formats specified above.
- Player and position **will always be one word string, containing no whitespaces**.
- Skill will be an **integer** in the **range [0, 1000]**.
- There will be **no invalid** input lines.
- The programm ends when you receive the command **&quot;Season end&quot;**.

### Output

- The output format for each player is:

&quot;{player}: {totalSkill} skill&quot;

&quot;- {position} \&lt;::\&gt; {skill}&quot;

### Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| Pesho -\&gt; Adc -\&gt; 400Gosho -\&gt; Jungle -\&gt; 300Stamat -\&gt; Mid -\&gt; 200Stamat -\&gt; Support -\&gt; 250Season end | Stamat: 450 skill- Support \&lt;::\&gt; 250- Mid \&lt;::\&gt; 200Pesho: 400 skill- Adc \&lt;::\&gt; 400Gosho: 300 skill- Jungle \&lt;::\&gt; 300 | We order the players by total skill points descending, then by name. We print every position along its skill ordered descending by skill, then by position name. |
| Pesho -\&gt; Adc -\&gt; 400Bush -\&gt; Tank -\&gt; 150Faker -\&gt; Mid -\&gt; 200Faker -\&gt; Support -\&gt; 250Faker -\&gt; Tank -\&gt; 250Pesho vs FakerFaker vs BushFaker vs HideSeason end | Faker: 700 skill- Support \&lt;::\&gt; 250- Tank \&lt;::\&gt; 250- Mid \&lt;::\&gt; 200Pesho: 400 skill- Adc \&lt;::\&gt; 400 | Faker and Pesho don`t have common position, so the duel isn`t valid.Faker wins vs Bush /common position: &quot;Tank&quot;. Bush is demoted.Hide doesn`t exist so the duel isn`t valid.We print every player left in the tier. |

