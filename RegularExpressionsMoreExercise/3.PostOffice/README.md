# 1.More Exercise: Regular Expressions

Problems for exercise and homework for the [&quot;C#  Fundamentals&quot; course @ SoftUni](https://softuni.bg/trainings/2363/csharp-fundamentals-may-2019)
You can check your solutions in [Judge](https://judge.softuni.bg/Contests/1754/)

1. 3.Post Office

**You read a single line of ASCII symbols** , and the message is somewhere inside it, you must find it.

 The input consists of three parts separated with **&quot;|&quot;** like this:

**&quot;{firstPart}|{secondPart}|{thirdPart}&quot;**

Each word **starts with capital letter** and **has a fixed length** , you can find those in each different part of the input.

The **first part** carries the capital letters for each word inside the message. You need to find those capital letters **1 or more**** from A to Z **. The capital letters should be surrounded from the both sides with any of the following symbols –**&quot;#, $, %, \*, &amp;&quot;. **And those symbols** should match on the both sides. **This means that** $AOTP$ - is a valid **pattern for the capital letters.** $AKTP% - is invalid since the symbols do not match.**

The **second part** of the data contains the **starting letter ASCII code and words**** length **/** between 1 – 20 charactes/ **, in the following format:**&quot;{asciiCode}:{length}&quot; **.For example,&quot;** 67:05 **&quot; – means that &#39;67&#39; -** ascii code ****equal to the capital letter****&quot;C&quot;, **represents a word starting with &quot;C&quot; with following 5 characters: like**&quot;Carrot&quot;. **The** ascii code **should be a** capital letter equal to a letter from the first part **. Word&#39;s length** should be exactly 2 digits **. Length** less than ****10 will always have a padding zero** , **you don&#39;t need to check that.**

The **third part of the message** are **words separated by spaces.** Those **words have to start with Capital letter [A…Z] equal to the ascii code and have exactly the length for each capital letter you have found in the second part. Those words can contain any ASCII symbol without spaces.**

When you find **valid word** , you have to **print it on a new line**.

### Input / Constraints

- On the first line – the text in form of three different parts separated by **&quot;|&quot;. There can be any ASCII character inside the input, except &#39;|&#39;.**
- Input will always be valid - you don&#39;t need to check it
- The input will always have three different parts, that will always be separated by &quot;|&quot;.

### Output

- **Print all extracted words, each on a new line.**
- Allowed working **time** / **memory** : **100ms** / **16MB**

### Examples

| **Input** | **Output** | **Comment** |
| --- | --- | --- |
| sdsGGasAOTPWEEEdas$AOTP$|a65:1.2s65:03d79:01ds84:02! -80:07++ABs90:1.1|adsaArmyd Gara So La Arm Armyw21 Argo O daOfa Or Ti Sar saTheww TheParahaos | ArgoOrTheParahaos | The capital letters are &quot;AOTP&quot;Then we look for the addition length of the words for each capital letter. For A(65) -\&gt; it&#39;s 4. For O(79) -\&gt; it&#39;s 2 For T(84) -\&gt; it&#39;s 3 For P(80) -\&gt; it&#39;s 8.Then we search in the last part for the words.First, start with letter &#39;A&#39; and we find &quot;Argo&quot;. With letter &#39;O&#39; we find  &quot;Or&quot;. With letter &#39;T&#39; we find &quot;The&quot; and with letter &#39;P&#39; we find &quot;Parahaos&quot;. |
| Urgent&quot;Message.TO$#POAML#|readData79:05:79:0!2reme80:03--23:11{79:05}tak{65:11ar}!77:!23--)77:05ACCSS76:05ad|Remedy Por Ostream :Istream Post sOffices Office Of Ankh-Morpork MR.LIPWIG MisterLipwig  | PostOfficeAnkh-MorporkMisterLipwig | The first capital letters are &quot;POAML&quot;Then we look for the addition length of the words for each capital letter. P(80) -\&gt; it&#39;s 4.O(79) -\&gt; it&#39;s 6A(65) -\&gt; it&#39;s 12M(77) -\&gt; it&#39;s 6L(76) -\&gt; it&#39;s 6.Then we search the last part for the words. First, start with the letter &#39;P&#39; and we find &quot;Post&quot;. With letter &#39;O&#39; we find &quot;Office&quot;. With letter &#39;A&#39; we find &quot;Ankh-Morpork&quot;. With letter &#39;M&#39; we find &quot;Mister&quot; and with letter &#39;L&#39; we find &quot;Lipwig&quot;. |

