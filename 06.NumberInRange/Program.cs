//Write a program to read a number in the range [1 … 100]:
//•	Read an integer number from the console
//•	Check if the number is in the range [1 … 100]
//o	No (number is NOT in the range)  read a new number
//o	Yes (number is IN the range)  print the number and the program stops

int number = int.Parse(Console.ReadLine());

while (number < 1 || number > 100) 
{
number = int. Parse(Console.ReadLine());
}
Console.WriteLine(number);