Console.Write("Введите число: N ");
string a = Console.ReadLine(); 

if (a.Length !=5)
{
    Console.WriteLine("Число не является палиндромом");
}
else
{
    if (a[0] == a[4] && a[1] == a[3])
    {
       Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");
    }
}