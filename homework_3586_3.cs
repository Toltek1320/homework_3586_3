// ДЗ_19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да


System.Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());
if (num > 9999 && num < 100000)
{
    if (num / 10000 == num % 10 && ((num / 1000) % 10 == (num % 100) / 10))
    {
        System.Console.WriteLine($"Число {num} - палиндром.");
    }
    else 
    {
        System.Console.WriteLine($"Число {num} - не палиндром.");
    }
}
else
{
    System.Console.WriteLine("Это не пятизначное число!");
}
