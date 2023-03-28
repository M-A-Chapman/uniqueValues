# uniqueValues
A simple C# project that asks the user to enter numbers until they type Quit. It then returns a list of unique numbers entered.

## Running
```
dotnet build
dotnet run
```
## Process
* runs a loop asking the user to input a number or type quit to exit
* if the number is entered for the first time it is added to a list of numbers
* after the user types quit a list of only unique numbers is returned

## Output
```
Enter a number or type Quit: 
3
Enter a number or type Quit: 
6
Enter a number or type Quit: 
6
Enter a number or type Quit: 
6
Enter a number or type Quit: 
4
Enter a number or type Quit: 
quit
Unique Numbers:
3
6
4
```
