/*Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= N; i = i+2)
{
    Console.WriteLine(i + ", ");
}
*/

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 2;
while ( i <= N)
{
    if ( i % 2 == 0)
    {
        Console.WriteLine(i + ", ");
    }
    i++;
}