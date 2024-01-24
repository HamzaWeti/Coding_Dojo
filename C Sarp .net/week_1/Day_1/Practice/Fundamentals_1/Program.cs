// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

for(int i = 1; i < 256; i++)
{
    Console.WriteLine(i);
}

Random rand = new Random();
for(int i = 0; i < 5; i++)
{
    Console.WriteLine(rand.Next(10,21));
}

int sum = 0;
for(int i = 0; i < 5; i++)
{
    sum+=rand.Next(10,21);
}
Console.WriteLine(sum);
Random rand = new Random();
int sum = 0;

for (int i = 0; i < 5; i++)
{
    sum += rand.Next(10, 21);
}

Console.WriteLine(sum);


for(int i = 1; i < 101; i++)
{
    if(i % 3 == 0 && i % 5 == 0)
    {
        continue;
    }
    if(i % 3 == 0 || i % 5 == 0)
    {
        Console.WriteLine(i);
    }
}

for(int i = 1; i < 101; i++)
{
    if(i % 3 == 0 && i % 5 == 0)
    {
        continue;
    }
    if(i % 3 == 0)
    {
        Console.WriteLine($"{i} - Fizz");
    }
    if(i % 5 == 0)
    {
        Console.WriteLine($"{i} - Buzz");
    }
}

for(int i = 1; i < 101; i++)
{
    if(i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine($"{i} - FizzBuzz");
    }
    else if(i % 3 == 0)
    {
        Console.WriteLine($"{i} - Fizz");
    }
    else if(i % 5 == 0)
    {
        Console.WriteLine($"{i} - Buzz");
    }
}
