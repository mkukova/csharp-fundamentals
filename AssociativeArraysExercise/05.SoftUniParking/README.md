# 1.Exercise: Associative Arrays

1. 5.SoftUni Parking

SoftUni just got a new **parking lot**. It&#39;s so fancy, it even has online **parking validation**. Except the online service doesn&#39;t work. It can only receive users&#39; data, but it doesn&#39;t know what to do with it. Good thing you&#39;re on the dev team and know how to fix it, right?

Write a program, which validates a parking place for an online service. Users can **register** to park and **unregister** to leave.

The program **receives 2 commands** :

- &quot; **register {username} {licensePlateNumber}**&quot;:
  - The system only supports **one car per user** at the moment, so if a user tries to register **another license plate** , using the **same username** , the system should print:
&quot; **ERROR: already registered with plate number {licensePlateNumber}**&quot;
  - If the aforementioned checks passes successfully, the plate can be registered, so the system should print:
**&quot;{**** username} registered {licensePlateNumber} successfully ****&quot;**
- &quot; **unregister {username}**&quot;:
  - If the user is **not present** in the database, the system should print:
&quot; **ERROR: user {username} not found**&quot;
  - If the aforementioned check passes successfully, the system should print:
&quot; **{username} unregistered successfully**&quot;

After you execute all of the commands, **print** all the currently **registered users** and their **license plates** in the format:

- &quot; **{username} =\&gt; {licensePlateNumber}**&quot;

### Input

- First line: **n** - **number of commands** – **integer**
- Next **n** lines: **commands** in one of the **two** possible formats:
  - Register: &quot; **register {username} {licensePlateNumber}**&quot;
  - Unregister: &quot; **unregister {username}**&quot;

The input will **always** be **valid** and you **do not need** to check it explicitly.

### Examples

| **Input** | **Output** |
| --- | --- |
| 5register John CS1234JSregister George JAVA123Sregister Andy AB4142CDregister Jesica VR1223EEunregister Andy | John registered CS1234JS successfullyGeorge registered JAVA123S successfullyAndy registered AB4142CD successfullyJesica registered VR1223EE successfullyAndy unregistered successfullyJohn =\&gt; CS1234JSGeorge =\&gt; JAVA123SJesica =\&gt; VR1223EE |
| 4register Jony AA4132BBregister Jony AA4132BBregister Linda AA9999BBunregister Jony | Jony registered AA4132BB successfullyERROR: already registered with plate number AA4132BBLinda registered AA9999BB successfullyJony unregistered successfullyLinda =\&gt; AA9999BB |
| 6register Jacob MM1111XXregister Anthony AB1111XXunregister Jacobregister Joshua DD1111XXunregister Lilyregister Samantha AA9999BB | **Jacob registered MM1111XX successfully**** Anthony registered AB1111XX successfully ****Jacob unregistered successfully**** Joshua registered DD1111XX successfully ****ERROR: user Lily not found**** Samantha registered AA9999BB successfully ****Joshua =\&gt; DD1111XX**** Anthony =\&gt; AB1111XX ****Samantha =\&gt; AA9999BB** |

