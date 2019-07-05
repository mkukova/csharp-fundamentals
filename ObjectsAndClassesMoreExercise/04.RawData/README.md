# 1.More Exercises: Objects and Classes

1. 4.Raw Data

You are the owner of a courier company and you want to make a system for tracking your cars and their cargo. Define a class **Car** that holds an information about **model**** , **** engine **and** cargo **. The** Engine **and** Cargo **shouldbe** separate classes **. Create a constructor that receives all of the information about the** Car**and creates and initializes its inner components (engine and cargo).

On the first line of input, you will receive a number **N** – the number of cars you have. On each of the next **N** lines, you will receive the following information about a car: **&quot;\&lt;Model\&gt; \&lt;EngineSpeed\&gt; \&lt;EnginePower\&gt; \&lt;CargoWeight\&gt; \&lt;CargoType\&gt;&quot;** ,where the **speed** , **power** and **weight** are all **integers.**

After the **N** lines you will receive a single line with one of 2 commands: **&quot;fragile&quot;** or **&quot;flamable&quot;**. If the command is **&quot;fragile&quot;** print all cars, whose **Cargo Type**** is ****&quot;fragile&quot; **with** cargo, **whose** weight ** ** \&lt; **** 1000 **. If the command is**&quot; ****flamable****&quot; **print all of the cars whose** Cargo ****Type**  **is**  **&quot;**** flamable ****&quot;** and have **Engine**** Power **** \&gt; **** 250**. The cars should be printed in order of appearing in the input.

### Examples

| **Input** | **Output** |
| --- | --- |
| 2ChevroletAstro 200 180 1000 fragileCitroen2CV 190 165 900 fragilefragile | Citroen2CV |
| 4ChevroletExpress 215 255 1200 flamableChevroletAstro 210 230 1000 flamableDaciaDokker 230 275 1400 flamableCitroen2CV 190 165 1200 fragileflamable | ChevroletExpressDaciaDokker |

