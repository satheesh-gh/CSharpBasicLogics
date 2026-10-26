// See https://aka.ms/new-console-template for more information
using BasicLogicsConsole;

Console.WriteLine("Hello, World!");
BasicLobic basicLobic = new BasicLobic();
//Console.WriteLine("Enter a text to check if it is a palindrome:");
//string ptext = Console.ReadLine();
//Console.WriteLine(basicLobic.PolinString(ptext));
//Console.WriteLine("Enter a number to check if it is a palindrome:");
//int num = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(basicLobic.PolinNumber(num));

//Console.WriteLine("Enter a number to check if it is prime:");
//int primeNum = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(basicLobic.IsPrime(primeNum));
//Console.WriteLine("Enter the number of Fibonacci terms to generate:");
//int fibNum = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(basicLobic.Fibonacci(fibNum));

Console.WriteLine("Enter a number for swapping:");
int a = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Enter another number for swapping:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(basicLobic.SwapNumbers(a, b));
Console.ReadLine();