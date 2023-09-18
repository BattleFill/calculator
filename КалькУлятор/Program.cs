int vibor;
double chislo1;
double chislo2;
double result;
int konez;
do
{
    do
    {
        Console.WriteLine("Выберите действие:");
        Console.WriteLine("1. Сложить 2 числа");
        Console.WriteLine("2. Вычесть первое из второго");
        Console.WriteLine("3. Перемножить два числа");
        Console.WriteLine("4. Разделить первое на второе");
        Console.WriteLine("5. Возвести в степень N первое число");
        Console.WriteLine("6. Найти квадратный корень из числа");
        Console.WriteLine("7. Найти 1 процент от числа");
        Console.WriteLine("8. Найти факториал из числа");
        Console.WriteLine("9. Выйти из программы");
        vibor = Convert.ToInt32(Console.ReadLine());
        switch (vibor)
        {
            case 1:
                Console.WriteLine("Введите первое число:");
                chislo1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число:");
                chislo2 = Convert.ToInt32(Console.ReadLine());
                result = chislo1 + chislo2;
                Console.WriteLine(chislo1 + " + " + chislo2 + " = " + result);
                break;
            case 2:
                Console.WriteLine("Введите первое число:");
                chislo1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число:");
                chislo2 = Convert.ToInt32(Console.ReadLine());
                result = chislo1 - chislo2;
                Console.WriteLine(chislo1 + " - " + chislo2 + " = " + result);
                break;
            case 3:
                Console.WriteLine("Введите первое число:");
                chislo1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число:");
                chislo2 = Convert.ToInt32(Console.ReadLine());
                result = chislo1 * chislo2;
                Console.WriteLine(chislo1 + " * " + chislo2 + " = " + result);
                break;
            case 4:
                Console.WriteLine("Введите первое число:");
                chislo1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число:");
                chislo2 = Convert.ToInt32(Console.ReadLine());
                result = chislo1 / chislo2;
                Console.WriteLine(chislo1 + " : " + chislo2 + " = " + result);
                break;
            case 5:
                Console.WriteLine("Введите первое число:");
                chislo1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число:");
                chislo2 = Convert.ToInt32(Console.ReadLine());
                result = Math.Pow(chislo1, chislo2);
                Console.WriteLine("число " + chislo1 + " в степени " + chislo2 + " = " + result);
                break;
            case 6:
                Console.WriteLine("Введите число:");
                chislo1 = Convert.ToInt32(Console.ReadLine());
                result = Math.Sqrt(chislo1);
                Console.WriteLine("квадратный корень " + chislo1 + " = " + result);
                break;
            case 7:
                Console.WriteLine("Введите число:");
                chislo1 = Convert.ToInt32(Console.ReadLine());
                result = chislo1 / 100;
                Console.WriteLine("один процент от " + chislo1 + " = " + result);
                break;
            case 8:
                Console.WriteLine("Введите число:");
                chislo1 = Convert.ToInt32(Console.ReadLine());
                result = 1;
                for (int i = 1; i <= chislo1; i++)
                    result *= i;
                Console.WriteLine("Факториал " + chislo1 + " = " + result);
                break;
            case 9:
                break;
        }
    } while (vibor < 9);
    Console.WriteLine("Вы уверены?");
    Console.WriteLine("1 - да");
    Console.WriteLine("остальное - нет");
    konez = Convert.ToInt32(Console.ReadLine());
} while (konez != 1);
