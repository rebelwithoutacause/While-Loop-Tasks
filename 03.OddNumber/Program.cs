//Write a program to enter an odd number:
//•	Read numbers from the console until an odd number is entered
//•	Print the odd number as output

int number = int.Parse(Console.ReadLine());

while (number % 2 == 0) 
{
 number = int. Parse(Console.ReadLine());
}
Console.WriteLine(number); number++;
