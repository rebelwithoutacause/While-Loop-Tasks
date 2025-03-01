// Write a program that:
//•	Reads an integer number N
//•	Print the numbers from N down to 1 (inclusively), each on separate line
//Note: N will always be bigger than 1.

int N = int.Parse(Console.ReadLine());

while (N >= 1) 
{
Console.WriteLine(N);N--;
}


