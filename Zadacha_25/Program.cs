Console.Clear();

void start()
{
    bool work = true;
    while (work)
    {
        System.Console.WriteLine("Решаем задачу? (y/n)");
        string i= System.Console.ReadLine();
        switch (i)
        {
            case "y": task();break;
            case "n": work = false; break;
            default: System.Console.WriteLine("Something goes wrong. Try again."); break;
        }
    }
}

start();

void task()
{
    System.Console.WriteLine("Введите число А: ");
    int num1 = int.Parse(System.Console.ReadLine());
    System.Console.WriteLine("Введите число Б: ");
    int num2 = int.Parse(System.Console.ReadLine());
    System.Console.WriteLine($"Число А в степени Б = {MathPath(num1, num2)}");
}

double MathPath(int a, int b)
{
    double result = Math.Pow(a,b);
    return result;
}