// Понять и простить ^_^ :))
// Задача 10: Напишите программу, которая принимает на вход трёхзначное
//  число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Введите трёхзначное число");
// int num = Convert.ToInt32(Console.ReadLine());

// int result = num / 10 % 10;
// Console.WriteLine(result);

// Задача 13: Напишите программу, которая выводит третью цифру заданного
//  числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// int num = new Random().Next(100, 1000);
// Console.WriteLine(num);

// int num1 = num / 10;
// int num2 = num / 10;

// if (result = num )
// {
//     Console.WriteLine($"Третья цифра в числе: {result}");
// }
// else
// {
//     Console.WriteLine("Третьей цифры нет");
// }



// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите номер дня недели (1-7): ");
if (int.TryParse(Console.ReadLine(), out int dayNumber))
{
    if (dayNumber >= 1 && dayNumber <= 7)
    {
        if (dayNumber == 6 || dayNumber == 7)
        {
            Console.WriteLine("Да, это выходной день.");
        }
        else
        {
            Console.WriteLine("Нет, это не выходной день.");
        }
    }
}
