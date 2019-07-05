## 1.Exercise: Objects and Classes

1. 6.Vehicle Catalogue

You have to create a vehicle catalogue. You will store only two types of vehicles – a **car** and a **truck**. Until you receive the &quot; **End**&quot; command you will be receiving **lines** of **input** in the following format:

| {typeOfVehicle} {model} {color} {horsepower} |
| --- |

After the &quot; **End**&quot;command, you will start receiving **models** of **vehicles**. Print the **data** for every received vehicle in the following format:

| Type: {typeOfVehicle}Model: {modelOfVehicle}Color: {colorOfVehicle}Horsepower: {horsepowerOfVehicle}
 |
| --- |

When you receive the command &quot; **Close the Catalogue**&quot;, print the **average**** horsepower **for the** cars **and for the** trucks** in the following format:

{typeOfVehicles} have average horsepower of {averageHorsepower}.

The **average**** horsepower **is calculated by** dividing **the** sum **of the** horsepower **of** all **vehicles from the certain type by the** total ****count** of **vehicles** from the **same**** type **. Round the answer to the** 2**

# nd
 **digit after the decimal separator**.
### Constraints

- The type of vehicle will always be either a **car** or a **truck**.
- You will not receive the **same**** model ****twice**.
- The received horsepower will be an integer in the range **[1…1000]**
- You will receive at most **50** vehicles.
- The separator will always be a single **whitespace**.

### Examples

| **Input** | **Output** |
| --- | --- |
| truck Man red 200truck Mercedes blue 300car Ford green 120car Ferrari red 550car Lamborghini orange 570EndFerrariFordManClose the Catalogue | Type: CarModel: FerrariColor: redHorsepower: 550Type: CarModel: FordColor: greenHorsepower: 120Type: TruckModel: ManColor: redHorsepower: 200Cars have average horsepower of: 413.33.Trucks have average horsepower of: 250.00. |
