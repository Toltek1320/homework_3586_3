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

// ДЗ_21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3, 6, 8); B (2, 1, -7) -> 15,84
// A (7, -5, 0); B (1, -1, 9) -> 11,53

System.Console.Write("Enter number X1: ");
double numX1 = double.Parse(Console.ReadLine());

System.Console.Write("Enter number Y1: ");
double numY1 = double.Parse(Console.ReadLine());

System.Console.Write("Enter number Z1: ");
double numZ1 = double.Parse(Console.ReadLine());

System.Console.Write("Enter number X2: ");
double numX2 = double.Parse(Console.ReadLine());

System.Console.Write("Enter number Y2: ");
double numY2 = double.Parse(Console.ReadLine());

System.Console.Write("Enter number Z2: ");
double numZ2 = double.Parse(Console.ReadLine());

double numSQRT = Math.Pow((numX1 - numX2),2) + Math.Pow((numY1 - numY2),2) + Math.Pow((numZ1 - numZ2),2); 
// Math.Pow((numX1 - numX2),2) Возведение в степень
double result = Math.Sqrt(numSQRT); 
// Math.Sqrt Корень

Console.WriteLine(result.ToString("c2")); 

// ДЗ_23 Напишите программу, которая принимает на вход число N и выдает таблицу кубов чисел от 1 до N

System.Console.WriteLine("Enter number: ");
int num = int.Parse(Console.ReadLine());

int I = 1;

while(I <= num)
{
    System.Console.Write(Math.Pow(I, 3) + " ");
    I += 1;
}
