## 1.Exercise: Objects and Classes

1. 5.Teamwork projects

It&#39;s time for the teamwork projects and you are responsible for gathering the teams. First you will receive an integer - the **count** of the **teams** you will have to **register**. You will be given a **user** and a **team** , separated with &quot; **-**&quot;.  The user is the **creator** of **the team**. For every newly created team you should **print** a message:

&quot; **Team {teamName} has been created by {user}!**&quot;.

Next, you will receive an user with a team, separated with &quot;_-\&gt;_&quot;, which means that the user wants to **join** that **team**. Upon receiving the command: &quot; **end of assignment**&quot;, you should print **every team** , **ordered** by the **count** of its **members** ( **descending** ) and then by **name** ( **ascending** ). For each team, you have to print its members **sorted** by name ( **ascending** ). However, there are several **rules** :

- If an user tries to **create** a team more than once, a message should be displayed:
  - --&quot; **Team {teamName} was already created!** _&quot;_
- A creator of a team **cannot**** create** another team – the following message should be thrown:
  - --&quot; **{user} cannot create another team!**&quot;
- If an user tries to **join** a non-existent team, a message should be displayed:
  - --&quot; **Team {teamName} does not exist!** _&quot;_
- A member of a team **cannot**** join** another team – the following message should be thrown:
  - --&quot; **Member {user} cannot join team {team Name}!**&quot;
- In the end,teams with **zero** members (with **only a creator** ) should **disband** and you have toprint them **ordered by name in ascending order**.
-  Every **valid** team should be printed ordered by **name** (ascending) in the following format:

| &quot;{teamName}:- {creator}-- {member}…&quot; |
| --- |

### Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| 2Didi-PowerPuffsCodersToni-Toni is the bestPetq-\&gt;PowerPuffsCodersToni-\&gt;Toni is the bestend of assignment | Team PowerPuffsCoders has been created by Didi!Team Toni is the best has been created by Toni!Member Toni cannot join team Toni is the best!PowerPuffsCoders- Didi-- PetqTeams to disband:Toni is the best | Toni created a team, which he attempted to join later and this action resulted in throwing a certain message. Since nobody else tried to join his team, the team had to **disband**. |
| 3Tatyana-CloneClubHelena-CloneClubTrifon-AiNaBiraPesho-\&gt;aiNaBiraPesho-\&gt;AiNaBiraTatyana-\&gt;LedaPeshO-\&gt;AiNaBiraCossima-\&gt;CloneClubend of assignment | Team CloneClub has been created by Tatyana!Team CloneClub was already created!Team AiNaBira has been created by Trifon!Team aiNaBira does not exist!Team Leda does not exist!AiNaBira- Trifon-- Pesho-- PeshOCloneClub- Tatyana-- CossimaTeams to disband: | Note that when a user joins a team, you should **first** check if the team exists and **then** check if the user is already in a team: Tatyana has created CloneClub, then she tried to join a non-existent team and the concrete message was displayed. |
