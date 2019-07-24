## 1.Exercise: Regular Expressions

Problems for exercise and homework for the [&quot;C#  Fundamentals&quot; course @ SoftUni](https://softuni.bg/trainings/2363/csharp-fundamentals-may-2019)
You can check your solutions in [Judge](https://judge.softuni.bg/Contests/1668/)

1. 2.Race

Write a program that processes information about a race. On the **first line** you will be given **list of participants**** separated by &quot;, &quot; **. On the next few lines until you receive a line**&quot;end of race&quot; **you will be given some info which will be some** alphanumeric characters **. In between them you could have some** extra characters which you should ignore **. For example:**&quot;G!32e%o7r#32g$235@!2e&quot; **. The** letters are the name **of the person and the** sum of the digits is the distance **he ran. So here we have** George **who ran** 29 km **. Store the information about the person only** if the list of racers contains the name of the person **. If you receive the** same person more than once just add the distance to his old distance **. At the end** print the top 3 racers **ordered by** distance in descending** in the format:

**&quot;1st place: {first racer}**

**2nd place: {second racer}**

**3rd place: {third racer}&quot;**

### Examples

| **Input** | **Output** | **Comment** |
| --- | --- | --- |
| George, Peter, Bill, TomG4e@55or%6g6!68e!!@R1@!3a$y4456@B5@i@#123llG@e54o$r6ge#7P%et^#e5346rT$o553m&amp;6end of race | 1st place: George2nd place: Peter3rd place: Tom | On the 3
# rd
 input line we have Ray. He is not in the list, so we do not count his result. The other ones are valid. George has total of 55 km, Peter has 25 and Tom has 19. We do not print Bill because he is on 4
# th
 place.  |

