// По двум заданным числам проверять является ли одно квадратом другого

Console.Write("Введите число num_1: ");
int num_1 = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите число num_2: ");
int num_2 = int.Parse(Console.ReadLine() ?? "0");

if(num_1 == num_2 * num_2) Console.Write("Число num_1 является квадратом числа num_2 !");
    else if(num_2 == num_1 * num_1) Console.Write("Число num_2 является квадратом числа num_1 !");
        else Console.Write("Ни одно из заданных чисел (num_1, num_2) не являются квадратом другого !");
