// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// int Number(int a)
// {
//     int result = (a/10)%10;
//     return result;
// };
// Console.WriteLine("введите трехзначное число");
// int a = Convert.ToInt32(Console.ReadLine());
// int res = Number(a);
// Console.WriteLine("Вторая цифра данного числа: "+res);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// int Number(int a)
// {
//     int c = 1000;
//     int d = 10; 
//     int f = 1;
// while (a>c){
// c=c*10;
// d=d*10;
// f=f*10;
// } 
// int b = (a % d) / f;
// return b;
// }
// Console.WriteLine("Введите число");
// int a = Convert.ToInt32(Console.ReadLine());
// if (a<100)
// {Console.WriteLine("Третьей цифры нет");}
// else {int res = Number(a);
// Console.WriteLine("Третья цифра данного числа: "+res);}

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// void Week (int a)
// {
//     if (a>5){
//         Console.WriteLine("Это выходной день");
//     }
//     else 
//     Console.WriteLine("Это будний день");
// }

// Console.WriteLine("Введите цифру, обозначающую день недели (от 1 до 7)");
// int a = Convert.ToInt32(Console.ReadLine());
// Week(a);

