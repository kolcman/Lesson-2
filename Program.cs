// int number = int.Parse(Console.ReadLine());
// int number2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(number);
// Console.WriteLine(number2);

// Console.Write("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// if (number1 == (number2 * number2))
// {
//     Console.WriteLine("Да");
// } else Console.WriteLine("Нет");

System.Console.WriteLine("Введите первое число: ");
int N = Convert.ToInt32(Console.ReadLine());

// int i = - N;
// while(i <= N)
// {
//     System.Console.Write(i + ",");
//     i++;
// }



for (int i = -N; i <= N; i++)
{
    System.Console.Write(i + ", ");
}
