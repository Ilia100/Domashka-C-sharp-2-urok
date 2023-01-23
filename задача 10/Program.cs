/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

int secondNumber(int x)
{
{
return (x / 10)  - (x / 100)*10;
}
}

Console.WriteLine($"введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());


if (number >99 && number <1000 || number <-99 && number >-1000)
{
int num = secondNumber(number);
Console.WriteLine("второе число это " + num );

}
else
{
    Console.WriteLine($"число не трехзначное");
}