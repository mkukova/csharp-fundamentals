# 1.Exercise: Lists

Problems for exercise and homework for the [&quot;C#  Fundamentals&quot; course @ SoftUni](https://softuni.bg/modules/57/tech-module-4-0)
You can check your solutions here: [Judge](https://judge.softuni.bg/Contests/1211)

1. 10. \*SoftUni Course Planning

You are tasked to help with the planning of the next Technology Fundamentals course by keeping track of the lessons, that are going to be included in the course, as well as all the exercises for the lessons.

On the first line you will **receive the initial schedule of the lessons and the exercises** that are going to be a part of the next course, separated by **comma and space &quot;, &quot;.** But before the course starts, some changes should be made. Until you receive **&quot;course start&quot;** you will be given **some commands to modify the course schedule**. The possible commands are:

**Add:{lessonTitle}** – add the lesson to the end of the schedule, **if it does not exist**.

**Insert:{lessonTitle}:{index}** – insert the lesson to the given index, **if it does not exist.**

**Remove:{lessonTitle}** – remove the lesson, **if it exists.**

**Swap:{lessonTitle}:{lessonTitle}** – change the place of the two lessons, **if they exist.**

**Exercise:{lessonTitle}** – add Exercise in the schedule right after the lesson index **, if the lesson exists and there is no exercise already** , in the following format **&quot;{lessonTitle}-Exercise&quot;**. **If the lesson doesn`t exist** , **add the lesson** in the end of the course schedule **, followed by the Exercise**.

**Each time you Swap or Remove a lesson, you should do the same with the Exercises, if there are any, which follow the lessons.**

### Input / Constraints

- first line – the initial schedule lessons – strings, separated by comma and space **&quot;, &quot;**
- until **&quot;course start&quot;** you will receive commands in the format described above

### Output

- Print the whole course schedule, each lesson on a new line with its number(index) in the schedule:
**&quot;{lesson index}.{lessonTitle}&quot;**
- Allowed working **time** / **memory** : **100ms** / **16MB**.

### Examples

| **Input** | **Output** | **Comment** |
| --- | --- | --- |
| Data Types, Objects, ListsAdd:DatabasesInsert:Arrays:0Remove:Listscourse start | 1.Arrays2.Data Types3.Objects4.Databases  | We receive the initial schedule. Next, we add Databases lesson, because it doesn`t exist. We Insert at the given index lesson Arrays, because its not present in the schedule. After receiving the last command and removing lesson Lists, we print the whole schedule. |
| **Input** | **Output** | **Comment** |
| Arrays, Lists, MethodsSwap:Arrays:MethodsExercise:DatabasesSwap:Lists:DatabasesInsert:Arrays:0course start | 1.Methods2.Databases3.Databases-Exercise4.Arrays5.Lists | We swap the given lessons, because both exist.After receiving the Exercise command, we see that such lesson doesn`t exist, so we add the lesson at the end, followed by the exercise.We swap Lists and Databases lessons, theDatabases-Exercise is also moved after the Databases lesson.We skip the next command, because we already have such lesson in our schedule. |