Console.WriteLine ("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n<10000 && n>100000)
{
    Console.WriteLine("Введено неверное число.Ведите повторно: ");
 n=Convert.ToInt32(Console.ReadLine());

}
if (Convert.ToString (n) [0] == Convert.ToString (n) [4] && Convert.ToString (n)[1]==Convert.ToString (n)[3] )
Console.WriteLine("Число является палиндромом");
else
Console.WriteLine("Число не является палиндромом");
