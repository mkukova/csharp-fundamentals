# Emoji Sumator

Create a program, that finds all of the **emojis** in **a given message** and makes some calculations. You will receive a few lines of input **.** On the **first**** line **, you will receive a single** line of text (ASCII symbols). **On the** next ****line** , you will receive an **emoji code** in the following format:

&quot;**number:number:number:(…)**&quot;

**Each number is the value of an ASCII symbol** and if you decrypt **all of the symbols** , you will receive a name of an emoji.

An emoji is **valid** when:

- --It is surrounded by **colons**** and consists of ****at least 4 lowercase letters** from the English alphabet.
- -- **Before** the emoji there is a **white space** and **after it** there isa **white space or any of the following punctuation marks:**&#39; **,**&#39;, &#39; **.**&#39;,&#39; **!**&#39;,&#39; **?**&#39;.

**Example for valid emojis**** :**

I hope you have a **:sunny:** day **:smiley:**** :smiley:**.

You must find all of the emojis and after that, calculate their total power. It is calculated **by summing the ASCII value of all letters between the colons**.

**Check** if any of the valid **emoji names is equal to the name** received form **the emoji code** and **if it is – multiply the total emoji power by 2**.

In the end print on the console all valid emojis, **separated by а comma and a white space in order of finding** and the total emoji power, each on a separate line.

**Example:**
**Emojis found: :sunny:, :smiley:, :smiley:
Total Emoji Power: {sum}**

## Input / Constraints

- On the first line – the message. **There can be any ASCII character inside the input.**
- Punctuation marks used will be only &#39; **,**&#39;, &#39; **.**&#39;,&#39; **!**&#39;,&#39; **?**&#39;.
- A valid emoji consists of at least **4 lowercase letters surrounded by colons**.

## Output

- **Print all**  **found emojis**** , **** separated by a comma and whitespace ****.**
- **Print**  **the sum of all emojis&#39; power****.**

## Examples

| **Input** | **Output** | **Comment** |
| --- | --- | --- |
| Hello I am Mark from :England: and I am :one::seven: years old, I have a :hamster: as pet.115:101:118:101:110 | Emojis found: :seven:, :hamster:Total Emoji Power: 2602 | The only valid emojis here are :seven: and :hamster: because they are longer than 3 symbols and consist only of lowercase letters.
:England: is not a valid emoji because of the upper case &#39;E&#39;.
:one: is not a valid emoji because it is shorter than 4 symbols.
Then we sum all letters&#39; ASCII value:
&#39;h&#39; = 104, &#39;a&#39; = 97, &#39;m&#39; = 109, &#39;s&#39; = 115, &#39;t&#39; = 116, &#39;e&#39; = 101, &#39;r&#39; = 114. Total for :hamster: is 756.
Total for :seven: is 545. The total power is 1301.
After that we check if the emoji code corresponds to any emoji, and in this case it does correspond to :seven:, so we multiply the total emoji power and in the end it is 2602. |
| In the Sofia Zoo there are many animals, such as :ti ger:, :elephan:t, :monk3y:, :goriLLa:, :fox:.97:101:117:114 | Total Emoji Power: 0 | |