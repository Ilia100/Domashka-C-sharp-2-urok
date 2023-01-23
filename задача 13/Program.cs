/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

int thirdnumber(int x, int z)
{
return (x / z)  - (x / (z*10))*10;
}

int razryad(int y)
{
    int count = 1;
    while ((y/count)>1000)
    {
count = count*10;
    }
     return count;
    
}

Console.WriteLine($"введите  число");
int number = Convert.ToInt32(Console.ReadLine());

if (number <100 && number >-100)
{
    Console.WriteLine($"третьей цифры нет");
}
else
{
int raz = razryad (number);   
int num = thirdnumber(number, raz);
Console.WriteLine("третье число " + num );
}