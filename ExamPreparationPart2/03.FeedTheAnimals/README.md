# Feed the Animals

_The sanctuary needs to provide food for the animals and feed them, so your task is to help with the process_

Create a program that organizes the **daily feeding** of **animals**. You need to keep information about **animals** , their **daily food limit** and the **areas** of the Wildlife Refuge **they**** live ****in**. You will be receiving **lines** with commands until you receive the **&quot;Last Info&quot;** message.  There are two **possible** commands:

- **&quot;Add:{animalName}:{dailyFoodLimit}:{area}&quot;:**
  - **oo**** Add **the** animal **and** its ****daily food limit** to your records. It is guaranteed that the **names** of the animals are **unique** and there will **never** be animals with the **same** name. **If** it already **exists** , just increase the value of the **daily**** food ****limit** with the **current** one that is **given**.
- **&quot;Feed:{animalName}:{food}:{area}&quot;:**
  - **oo**** Check **if the animal** exists **and if** it does **,** reduce **its daily** food limit **with the given** food ****for**** feeding **. If its** limit **reaches** 0 **or** less **, the** animal **is considered** successfully fed **and you need to** remove **it from your** records **and** print **the following** message**:
    - **&quot;{animalName} was successfully fed&quot;**

You need to know **the count of**** hungry ****animals** there are left in **each area** in the end. If an animal has daily food **limit above 0** , it is considered **hungry**.

In the end, you have to **print each animal** with its **daily** food **limit** sorted in **descending order** by the **daily food limit** and **then by** its **name** in **ascending** order in the following format:

**Animals:**

**{animalName} -\&gt; {dailyFoodLimit}g**

**{animalName} -\&gt; {dailyFoodLimit}g**

Afterwards, **print** the **areas** with the **count of**  **animals** , which are **not**** fed **in** descending **order by the** count **of** animals. **If an** area **has** 0 ****hungry animals** in it, **don&#39;t** print it. The **output** must be in the following **format** :

**Areas**** with hungry animals:**

**{areaName} : {countOfUnfedAnimals}**

**{areaName} : {countOfUnfedAnimals}**

## Input / Constraints

- You will be receiving linesuntil you receive the **&quot;**** Last Info ****&quot;** command.
- The **food** comes in **grams** and is an **integer** number in the range [1...100000].
- The input will **always** be **valid**.
- There will never be a case, in which an animal is in two or more areas at the same time.

## Output

- Print the appropriate message after the **&quot;Feed&quot;** command, **if** an **animal** is **fed**.
- Print the animals with their **daily food limit** in the **format** described above.
- Print the **areas** with the **count of unfed**** animals **in them in the** format** described above.

## Examples

| **Input** | **Output** |
| --- | --- |
| Add:Maya:7600:WaterfallAreaAdd:Bobbie:6570:DeepWoodsAreaAdd:Adam:4500:ByTheCreekAdd:Jamie:1290:RiverAreaAdd:Gem:8730:WaterfallAreaAdd:Maya:1230:WaterfallAreaAdd:Jamie:560:RiverAreaFeed:Bobbie:6300:DeepWoodsAreaFeed:Adam:4650:ByTheCreekFeed:Jamie:2000:RiverAreaLast Info | Adam was successfully fedJamie was successfully fedAnimals:Maya -\&gt; 8830gGem -\&gt; 8730gBobbie -\&gt; 270gAreas with hungry animals:WaterfallArea : 2DeepWoodsArea : 1 |
| **Comments** |
| First, we receive the &quot; **Add**&quot; command, so we **add**&quot; **Maya**&quot; to our **records** and we keep her **daily food limit** - **7600**. We know that she is in **WaterfallArea**. We keep adding the new animals until we receive &quot; **Maya**&quot; **again** and we have to **increase** her food **limit** with **1230** , so it becomes **8830**. After that we receive &quot; **Jamie**&quot; and we need to **increase** his daily food **limit** with **560** , after which it **becomes**** 1850 **. Then we start receiving &quot;** Feed **&quot; commands. First, we must** decrease ****Bobbie&#39;s** food **limit** with **6300** , so it becomes **270**. Then, we need to decrease **Adam&#39;s** food **limit** with **4650**. It **becomes**** less than zero **and we** remove ****him** from the collection – he is **considered fed** , respectively that is **one less hungry**** animal **in the** area **that he is in –** ByTheCreek **. Then we &quot;** Feed **&quot;** Jamie **with** 2000 **and his** limit **becomes** less than zero **, so we print &quot;** Jamie was successfully fed **&quot; and we** remove **him from our records and note that there is** one ****less**** hungry animal **in his area –** RiverArea **. In the end, we** print the animals **we still have in our collection, with their daily food** limits **in** descending order **by the food** limits **. Afterwards we print only the** areas **in which there are** remaining ****hungry**** animals **and their** count **in** descending** order. |
|   |
| Add:Bonie:3490:RiverAreaAdd:Sam:5430:DeepWoodsAreaAdd:Bonie:200:RiverAreaAdd:Maya:4560:ByTheCreekFeed:Maya:2390:ByTheCreekFeed:Bonie:3500:RiverAreaFeed:Johny:3400:WaterFallFeed:Sam:5500:DeepWoodsAreaLast Info | Sam was succesfully fedAnimals:Maya -\&gt; 2170gBonie -\&gt; 190gAreas with hungry animals:RiverArea : 1ByTheCreek : 1 |