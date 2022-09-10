Console.WriteLine("Введите координаты трех точек");
Console.Write("Введите х1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите у1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n1: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите х2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите у2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n2: ");
int n2 = Convert.ToInt32(Console.ReadLine());

double L=Math.Sqrt(Math.Pow(x1-x2,2)+ Math.Pow(y1-y2,2)+Math.Pow(n1-n2,2));
Console.WriteLine("Расстояние между точками равно: " +L);