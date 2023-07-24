/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

Console.Write("Введите первое число: ");
int first = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int second = int.Parse(Console.ReadLine()!);

if(first > second){
    Console.WriteLine($"max = {first}");
}
else Console.WriteLine($"max = {second} ");

/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.Write("Введите первое число: ");
int num = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите тре́тье число: ");
int num3 = int.Parse(Console.ReadLine()!);

int max = num;
if (num2 > num)
    max = num2;
if (num3 > max)
    max = num3;

Console.WriteLine($"max = {max} ");

/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет*/

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int numb = number%2;
if (numb > 0) {
    Console.WriteLine($"нет, число {number} нечётное");
}
else Console.WriteLine($"да, число {number} чётное ");

/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/

Console.Write("Введите число: ");
int chislo = Convert.ToInt32(Console.ReadLine());

int chislo2 = 2;

if(chislo > 1)
{
    while(chislo2 <= chislo)
    {
        Console.Write(chislo2 + " ");
        chislo2 = chislo2 + 2;
    }
}