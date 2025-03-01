//Write a program to print a sequence of numbers:
//•	The first number is 1
//•	Each next number is 2 times the previous number + 1
//•	Read an integer number n from the console – the max number
//•	Print the elements of the sequence (starting with 1), which are ≤ n

int maxNumber = int.Parse(Console.ReadLine());
int n = 1;

while (n <= maxNumber) 
{
    Console.WriteLine(n); 
        n = n * 2 + 1;
}