int y=1234;

    int count = 1;
    while ((y/count)>1000)
    {
count = count*10;
    }
    Console.WriteLine($"{count}");


    
int s= (y / count)  - (y / (count*10))*10;

    Console.WriteLine($"{s}");
