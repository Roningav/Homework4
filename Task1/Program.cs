/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int GetNumber()
{
    int result = 0;
    string error = "Вы ввели ненатуральное число";
    Console.WriteLine("Введите второе число: ");

    while (true)
    {
        if(int.TryParse(Console.ReadLine(), out result))
        {
            if (result<0)
            {
                Console.WriteLine(error);
            }
            else
            {
                break;
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine(error);
        }
    }
    return result;
}

Console.WriteLine("Введите первое число: ");
int digitA = int.Parse(Console.ReadLine());
int digitB = GetNumber();
for (int i = 1; i>0; i++)
{
    double result = 0;
    result = Math.Pow(digitA, digitB);
    Console.WriteLine($"{digitA} в степени {digitB} = {result}");
    break;
}
