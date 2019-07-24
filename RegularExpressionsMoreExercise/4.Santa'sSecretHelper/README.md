# 1.More Exercise: Regular Expressions

Problems for exercise and homework for the [&quot;C#  Fundamentals&quot; course @ SoftUni](https://softuni.bg/trainings/2363/csharp-fundamentals-may-2019)
You can check your solutions in [Judge](https://judge.softuni.bg/Contests/1754/)

1. 4.Santa&#39;s Secret Helper

After the successful second Christmas, Santa needs to gather information about the behavior of children to plan the presents for next Christmas. He has a secret helper, who is sending him **encrypted** information. Your task is to **decrypt it** and create a list of the children who have been good.

You will receive an **integer** , which represents **a key** and afterwards some **messages** , which you **must decode** by **subtracting the key** from the **value** of **each**** character**. After the decryption, to be considered a valid match, a message should:

- **--** Have a name, which **starts after****&#39;@&#39; **and contains** only letters from the Latin alphabet**
- **--** Have a behaviour type - **&quot;G&quot;(good) or &quot;N&quot;(naughty)** and must be **surrounded by &quot;!&quot;** (exclamation mark).

The order in the message should be: **child&#39;s name -\&gt; child&#39;s behavior.** They can be separated from the others by **any character except: &#39;@&#39;, &#39;-&#39;, &#39;!&#39;, &#39;:&#39; and &#39;\&gt;&#39;.**

You will be receiving message until you are given the &quot; **end**&quot; command. Afterwards, print the names of the children, who will receive a present, each on a new line.

### Input / Constraints

- The **first line**** holds n **– the number which you have to subtract from the characters –** integer in range [1…100];**
- On the next lines, you will be receiving encrypted messages.

### Output

Print the **names of the children** , each on a new line

### Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| 3CNdwhamigyenumje$J$CEreelh-nmguuejn$J$CVwdq&amp;gnmjkvng$Q$end | KateBobbie | We receive three messages and to decrypt them we use the key:First message has decryption key 3. So we substract from each characters code 3 and we receive:@Kate^jfdvbkrjgb!G!@Bobbie\*kjdrrbgk!G!@Stan#dkjghskd!N! **They are all valid** and they contain a child&#39;s name and behavior – G for good and N for naughty. |
| **Input** | **Output** | **Comments** |
| 3N}eideidmk$&#39;(mnyenmCNlpamnin$J$ddddkkkkmvkvmCFrqqru-nvevek$J$nmgievngeppqmkkkmnolmnnCEhq/vkievk$Q$yyegiivoguCYdohqwlqh/kguimhk$J$end | KimConnorValentine | We receive four messages.They are with key 3:Kzbfabfajh!$%jkvbkj@Kim^jkfk!G!aaaahhhhjshsj@Connor\*ksbsbh!G!kjdfbskdbmmnjhhhjklijkk@Ben,shfbsh!N!vvbdffsldr@Valentine,hdrfjeh!G! |