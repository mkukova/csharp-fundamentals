## 1.Seize the Fire

_The group of adventurists have gone on their first task. Now they have to walk through fire - literally. They have to use all of the water they have left. Your task is to help them survive._

Create a program that calculates the water that is needed to put out a &quot;fire cell&quot;, based on the given information about its &quot;fire level&quot; and how much it gets affected by water.

First, you will be given **the level of fire** inside the cell with the **integer**** value **of the** cell**, which represents the needed water to put out the fire.  They will be given in the following format:

**&quot;{typeOfFire} = {valueOfCell}#{typeOfFire} = {valueOfCell}#{typeOfFire} = {valueOfCell}……**&quot;

Afterwards you will receive the **amount of water** you have for putting out the fires. There is a **range** of fire for each of the fire types, and if a cell&#39;s value is below or exceeds it, it is invalid and you don&#39;t need to put it out.

| **Type of Fire** | **Range** |
| --- | --- |
| High | 81 - 125 |
| Medium | 51 - 80 |
| Low | 1 - 50 |

If a cell is valid, you have to put it out by reducing the water with its value. Putting out fire also takes **effort** and you need to **calculate it**. Its value is equal to **25% of the cell&#39;s value**. In the end you will have to print the **total effort**. Keep putting out cells until you run out of water. If you **don&#39;t have enough**** water **to put out a given cell –** skip it **and** try the next one **. In the end,** print the cells you have put out** in the following format:

**&quot;Cells:**

** - {cell1}**

** - {cell2}**

** - {cell3}**

**……**

** - {cellN}&quot;**

**&quot;Effort: {effort}&quot;**

In the end, print the total fire you have put out from all of the cells in the following format: &quot;Total Fire: {totalFire}&quot;

# 2.Input / Constraints

- **On the 1**
# st
 **line** you are going to receive the **fires with their cells** in the format described above **– integer numbers in the range [1…500]**
- **On the 2**
# nd
 **line** , you are going to be given the **water** – **an integer number** in the range **[0….100000]**

# 3.Output

- Print the cells, which you have put out in the following format:

&quot;Cells:

 - {cell}

 - {cell2}

 - {cell3}

 - {cell5}

……

 - {cellN}&quot;

- Print the effort, rounded 2 digits after the decimal separator in the following format:

&quot;Effort: {effort}&quot;

- Print the total fire put out

&quot;Total Fire: {totalFire}&quot;

# 4.Examples

| **Input** | **Output** |
| --- | --- |
| High = 89#Low = 28#Medium = 77#Low = 231250 | Cells: - 89 - 28 - 77 - 23Effort: 54.25Total Fire: 217 |
| **Comments** |
| After reading the output, we start **checking** the **level of the fire** and its validity. The first is valid, so we **subtract the 89** from the amount of **water** – 1250, and the water becomes 1161. We need to calculate the **effort** , which is **25%** of 89. We will **add 89 to the total fire** we have put out. In the end the effort is 54.22 and the total fire: 217 |

| **Input** | **Output** |
| --- | --- |
| High = 150#Low = 55#Medium = 86#Low = 40#High = 110#Medium = 77220 | Cells: - 40 - 110Effort: 37.50Total Fire: 150 |