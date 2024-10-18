try {
    Console.WriteLine("Введите начало отрезка a: ");
    double a = double.Parse(Console.ReadLine());

    Console.WriteLine("Введите конец отрезка b: ");
    double b = double.Parse(Console.ReadLine());

    Console.Write("Введите шаг h: ");
    double h = double.Parse(Console.ReadLine());

    if (a >= b || h <= 0)
    {
        Console.WriteLine("Ошибка: Убедитесь, что a < b и h > 0.");
        return;
    }
    int count = (int)((b - a) / h) + 1;

    Console.WriteLine("\nТаблица значений функции y(x) = cos(x^2) + sin^2(x):");
    Console.WriteLine("--------------------------------------------------");
    Console.WriteLine("|   x   |       y       |");
    Console.WriteLine("--------------------------------------------------");

    for (double x = a; x <= b; x += h)
    {
        double y = Math.Cos(x * x) + Math.Sin(x) * Math.Sin(x);
        Console.WriteLine($"| {x,6:F2} | {y,12:F6} |");
    }

    Console.WriteLine("--------------------------------------------------");
    Console.WriteLine($"Количество точек в таблице: {count}");
}
catch (FormatException)
{
    Console.WriteLine("Ошибка: Введено неверное значение. Пожалуйста, введите число.");
}
catch (Exception ex)
{
    Console.WriteLine($"Произошла ошибка: {ex.Message}");
}
