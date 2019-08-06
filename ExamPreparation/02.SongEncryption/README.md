# 1.Problem 02. Song Encryption

_Now that you&#39;ve helped Mandy to accept the group applications it&#39;s time to assist her with a security problem. You are tasked to encrypt all songs from the set list so that if someone steals it they won&#39;t be able to leak it online._

Your task is to write a program that encrypts information about artists and their songs.

**Until** you receive the command **&quot;end&quot;** you should read lines in following format :&quot; **{artist}:{song}&quot;,** and check if it&#39;s **valid** , considering the following rules:

- **Artist** – **starts** with **capital letter** , followed by **lowercase letters.**
  -  It can also **contains apostrophe ( &#39; ),** and **whitespace &quot; &quot;;**

**Valid group name:** Red hot chili peppers, Eminem, Guns n&#39; roses

**Invalid group name** : ReD Hot CiLly PePers, sLipKnot, guns n&#39;roses

- **Song – contains only capital letters, and whitespaces.**

**Valid songs:** BACK IN BLACK, BLEED IT OUT, KILLSHOT

**Invalid songs:** #BaCk IN black, BLEED $IT$ OUTt, &amp;KILLSHoT

After you validate the lines of an input, you should encrypt the information. In order to do that, you have to follow the rules below:

- **First you need to find a key for encryption.**
  - Your key is the **length** of the **artist (e.g. &quot;Eminem&quot; –  key: 6)**
- You have to **increment** the **ASCII value** of each symbol of the input, with the **key length**

**(**e.g. &quot;char&quot; **&#39;a&#39;** -\&gt; **&#39;g&#39;)**

-
  - Be careful if your key length is **bigger** than the ASCII value of a letter **&#39;z&#39;** or **&#39;Z&#39;**. In this case you should start from a letter **&#39;a&#39;. (**e.g. key:6 letter – &#39; **x**&#39;, encrypted letter – &#39; **d**&#39;**)**

- You should **NOT ENCRYPT** the following characters: **whitespaces** , and **apostrophes**
- You also should **replace****&#39;:&#39; **with the sign**&#39;@&#39;**

# 2.Input / Constraints

Until you receive **&quot;end&quot;** command you should read from the console.

- **Line of input** – Artist name and song, **separated** by **&quot;:&quot;** , containing only **ASCII symbols.**
- Allowed working time for your program: 0.1 seconds.
- Allowed memory: 16 MB.

# 3.Output

After every line of input, you should print:

- **If** line is valid – **encrypted information** in following format:

**&quot;**** Successful encryption: ****{encryptedArtist}@{encryptedSong}&quot;.**

- **If** line is not valid – print the following message: **&quot;Invalid input!&quot;**

# 4.Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| Eminem:VENOMLinkin park:NUMBDrake:NONSTOPAdele:HELLOend | Successful encryption: Ksotks@BKTUSSuccessful encryption: Wtyvty alcv@YFXMSuccessful encryption: Iwfpj@STSXYTUSuccessful encryption: Fijqj@MJQQT | All lines of input **are valid** , so weencrypt the information, change the charracter &quot;:&quot; with the sign **&quot;@&quot;** , and print the output of encription._Example_: **Eminem-\&gt; key 6** , adding a key to the ASCII value of each charracter except the **whitespace** , **apostrophe** , and our **delimiter** (&quot;:&quot;) and receive an encrypted name – **Ksotks@BKTUS** , then we do the same with the song. |
| **Input** | **Output** | **Comments** |
| Michael Jackson:ANOTHER PART OF MEAdele:ONE AND ONLYGuns n&#39;roses:NOVEMBER RAINChristina Aguilera: HuRtend   | Invalid input!Successful encryption: Fijqj@TSJ FSI TSQDSuccessful encryption: Sgze z&#39;daeqe@ZAHQYNQD DMUZInvalid input! | First line in not valid, because in the name of Michael Jackson we have more than one capital letter. Next two are valid, and the last is not valid, because the song does not  contain only capital letters. |