# 1.More Exercises: Objects and Classes

1. 3.Speed Racing

Your task is to implement a program that keeps track of cars and their fuel and supports methods for moving the cars. Define a class **Car** that keeps a track of a car&#39;s **model, fuel amount, fuel consumption**** per kilometer **and** traveled distance **. A Car&#39;s model is** unique** - there will never be 2 cars with the same model.

 On the first line of the input, you will receive a number **N** – the number of cars you need to track. On each of the next **N** lines you will receive information about cars in the following format **&quot;\&lt;Model\&gt; \&lt;FuelAmount\&gt; \&lt;FuelConsumptionFor1km\&gt;**&quot;. All **cars start at 0 kilometers traveled**.

After the **N** lines, until the command **&quot;End&quot;** is received, you will receive commands in the following format **&quot;Drive \&lt;CarModel\&gt; \&lt;amountOfKm\&gt;&quot;.** Implement a method in the **Car** class to calculate whether or not a car can move that distance. If it can, the car&#39;s **fuel amount** should be **reduced** by the amount of **used**** fuel **and its** traveled ****distance** should be increased by the number of the **traveled kilometers**. Otherwise, the car should not move (its fuel amount and the traveled distance should stay the same) and you should print on the console &quot; **Insufficient fuel for the drive**&quot;. After the **&quot;End&quot;** command is received, print **each car** , its **current**  **fuel amount** and the **traveled**** distance **in the format**&quot;\&lt;Model\&gt; \&lt;fuelAmount\&gt; \&lt;distanceTraveled\&gt;&quot; **. Print the fuel amount rounded to** two digits** after the decimal separator.

### Examples

| **Input** | **Output** |
| --- | --- |
| 2AudiA4 23 0.3BMW-M2 45 0.42Drive BMW-M2 56Drive AudiA4 5Drive AudiA4 13End | AudiA4 17.60 18BMW-M2 21.48 56 |
| 3AudiA4 18 0.34BMW-M2 33 0.41Ferrari-488Spider 50 0.47Drive Ferrari-488Spider 97Drive Ferrari-488Spider 35Drive AudiA4 85Drive AudiA4 50End | Insufficient fuel for the driveInsufficient fuel for the driveAudiA4 1.00 50BMW-M2 33.00 0Ferrari-488Spider 4.41 97 |

