## 1.The Hunting Games

_A group of friends have decided to participate in a game called &quot;The Hunting Games&quot;. The first stage of the game is to gather some supplies. They have a list and your job is to help them follow it and make the needed calculations._

Write a program that calculates the needed provisions for a quest in the woods.

First you will receive **the days of the adventure** , **the count of the players** and the **group&#39;s energy**. Afterwards, you will receive the following **provisions per day**  **for one person** :

- **Water**
- **Food**

The group calculates how many supplies they&#39;d need for the adventure and take that much water and food.

**Every day** they chop wood and **lose**** a certain amount of energy **. For each of the days, you are going to receive the energy loss from chopping wood. The program should** end **If the energy reaches** 0 **or** less**.

**Every second day** they **drink water** , which **boosts** their **energy** with **5% of their**  **current energy** and at the same **time drops their water**** supplies **by** 30% of their **** current water ****.**

**Every**** third **day they** eat **, which** reduces their food supplies by the following amount:**

**{currentFood} / {countOfPeople}** and at the same time **raises** their group&#39;s **energy** by **10%**.

The chopping of wood, the drinking of water, and the eating happen in the order above.

If they have **enough**** energy** to finish the quest, print the following message:

&quot;You are ready for the quest. You will be left with - {energyLevel} energy!&quot;

If they **run out of energy** print the following message and the **food** and **water** they were left with **before** they ran out of energy:

&quot;You will run out of energy. You will be left with {food} food and {water} water.&quot;

# 2.Input / Constraints

- **On the 1**
# st
 **line** , you are going to receive a number **N** - the days of the adventure – **an integer** in the range **[1…100]**
- **On the 2**
# nd
 **line** – the count of players – **an integer** in the range **[0 – 1000]**
- **On the 3**
# rd
 **line** - the group&#39;s energy – **a real number** in the range **[1 - 50000]**
- **On the 4**
# th
 **line** – water per day for one person – **a real number**** [0.00 – 1000.00]**
- **On the 5**
# th
 **line** – food per day for one person – **a real number**** [0.00 – 1000.00]**
- On the next **N** lines – one for each of the days – the amount of **energy loss** – **a real number** in the range **[0.00 - 1000]**
- You will **always** have **enough**** food **and** water**.

# 3.Output

- **&quot;You are ready for the quest. You will be left with - {energyLevel} energy!&quot;** –
if they have enough energy

&quot;You will run out of energy. You will be left with {food} food and {water} water.&quot;

- All of the real numbers should be **formatted** to the **second**** digit** after the decimal separator

# 4.Examples

| **Input** | **Output** |
| --- | --- |
| 1075035.511.37.2942.3500.57520.68540.87505.99630.3784.20321.21456.8330 | You are ready for the quest. You will be left with - 658.72 energy! |
| **Comments** |
| The **days** are **10** and the **players** are **7**. The **energy** of the whole **group** is **5035.5**. We receive the **water** and **food** and we can **calculate** the needed amount of both for the whole quest: **10 \* 7 \* 11.3 – total water = 791**** 10 \* 7 \* 7.2 – total food = 504 **Afterwards, for** each **of the** days **you have to calculate the energy loss. On each day you receive energy loss and you have to** subtract **it. On the first day it is:** 5035.5 – 942.3 = 4093.2 **On** every second day **we** add **the** energy boost **from the drank water, which is** 5% of the current energy **and** subtract **the amount** from the total water **. The first time we reach a second day, the energy will become** 3772.26 **and the water will become** 553.7 **. The first time we reach a** third ****day** , we have to **boost the energy with 10%** and **reduce** the food supplies and the energy will become - **3576.74** and the food **432**. Make all of the calculations and in the end, you must have **658.77** energy left and **132.94** water and **317.39** food left. |

| **Input** | **Output** |
| --- | --- |
| 12644309.85.5620.3840.2960.1220340674365345.5212412.12258496 | You will run out of energy. You will be left with 229.17 food and 118.59 water. |