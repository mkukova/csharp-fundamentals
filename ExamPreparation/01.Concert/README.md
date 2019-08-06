## 1.Problem 1 – Concert

_Mandy was hired_ _to_ _accept the group applications for the upcoming concert. She thought that it would be easy but now she is in trouble. She needs a programmer to make an application that will help her to safe the concert. She needs you._

You will read commands until you receive **&quot;start of concert&quot;** command.

There are **two types** of commands:

- &quot; **Add;**** {bandName}; {member 1}, {member 2}, {member 3}&quot; **- applies a band and a** list of members **to the concert. All members must be** unique **so don&#39;t add duplicates. If you receive the** same band **twice add only those members that** aren&#39;t present** in the list.
- **&quot;Play; {bandName}; {time}&quot;** – the band with the given name plays an **amount of time** on the stage.  If you receive a **band** that has **already**** applied **in the concert, just** increase **the band** time.**

If in both commands the band **does not exist** , add it.

At the end you have to print the **total time** and the bands ordered by the **time** on stage in **descending** order, then by **band name** in **ascending** order.

Also the **final input line** will be &quot; **{bandName}**&quot; and you have to print **all members** for this band in **insertion order**.

# 2.Input / Constraints

- The **time** of the bands – **integer** in range **[0 –**  **2**
# 31
 **- 1**** ]**
- There will always be at least one **member** in the group
- The bands will always have **time** on stage
- The final input line will always contain an **existing** band name
- Input will always be valid and in the range specified. You don&#39;t need to check it

# 3.Output

**Total time: {totalTime}**

**{firstBandName} -\&gt; {firstBandTime}**

**{secondBandName} -\&gt; {secondBandTime}**

**{thirdBandName} -\&gt; {thirdBandTime}**

**…**

**{bandName}**

**=\&gt;**** {firstMemberName}**

**=\&gt;**** {secondMemberName}**

**=\&gt;**** {thirdMemberName}**

**…**

# 4.Examples

| **Input** | **Output** |
| --- | --- |
| Play; The Beatles; 2584Add; The Beatles; John Lennon, Paul McCartney, George Harrison, Ringo StarrAdd; Eagles; Glenn Frey, Don Henley, Bernie Leadon, Randy MeisnerPlay; Eagles; 1869Add; The Rolling Stones; Brian Jones, Mick Jagger, Keith RichardsAdd; The Rolling Stones; Brian Jones, Mick Jagger, Keith Richards, Bill Wyman, Charlie Watts, Ian StewartPlay; The Rolling Stones; 4239start of concertThe Rolling Stones  | Total time: 8692The Rolling Stones -\&gt; 4239The Beatles -\&gt; 2584Eagles -\&gt; 1869The Rolling Stones=\&gt; Brian Jones=\&gt; Mick Jagger=\&gt; Keith Richards=\&gt; Bill Wyman=\&gt; Charlie Watts=\&gt; Ian Stewart |
| Add; The Beatles; John Lennon, Paul McCartneyAdd; The Beatles; Paul McCartney, George HarrisonAdd;The Beatles; George Harrison, Ringo StarrPlay; The Beatles; 3698Play; The Beatles; 3828start of concertThe Beatles | Total time: 7526The Beatles -\&gt; 7526The Beatles=\&gt; John Lennon=\&gt; Paul McCartney=\&gt; George Harrison=\&gt; Ringo Starr |