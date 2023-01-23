/*
 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/


void vih(int y)
{
    if (y==7 || y==6)
    {
Console.WriteLine($"это выходной");
    }
    else 
    {Console.WriteLine($"это будний день");
}
    
}

Console.WriteLine($"введите день недели");
int number = Convert.ToInt32(Console.ReadLine());

if (number >7 || number <1)
{
    Console.WriteLine($"это не день недели");
}
else
{
vih(number);   
}