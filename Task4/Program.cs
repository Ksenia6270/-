// Задача 4: Напишите программу, которая принимает на вход три числа  
//и выдаёт максимальное из этих чисел. 
 
//2, 3, 7 -> 7 
//44 5 78 -> 78 
//22 3 9 -> 22 
 
 
Console.Write("Введите число а:");  
int a = int.Parse(Console.ReadLine()!);  
Console.Write("Введите число b:");  
int b = int.Parse(Console.ReadLine()!);  
Console.Write("Введите число c:");  
int c = int.Parse(Console.ReadLine()!);  
 
if (a > b && a > c) 
                    Console.WriteLine("Nubmer Max = " + a);  
                else if (b > c) 
                    Console.WriteLine("Number Max = " + b);  
                else 
                    Console.WriteLine("Number Max = " + c);  
             
            Console.ReadLine();
