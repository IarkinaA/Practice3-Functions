// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и
//  находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите коордХ первой точки");
int X1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите коордY первой точки");
int Y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите коордZ первой точки");
int Z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите коордХ второй точки");
int X2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите коордY второй точки");
int Y2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите коордZ второй точки");
int Z2 = int.Parse(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(X2-X1,2)+ Math.Pow(Y1-Y1,2)+Math.Pow(Z2-Z1,2));

Console.WriteLine(d);
