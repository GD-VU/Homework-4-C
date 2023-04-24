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
    System.Console.WriteLine("Введите число, чтобы узнать сумму цифр в него входящих: ");
    string num1 = System.Console.ReadLine();
    System.Console.WriteLine($"Сумма цифр = {Sum(num1)}");
}

int Sum(string a)
{
    int b = int.Parse(a);
    int l = 0;
    int length = a.Length;
    int result = 0;
    for (l = 0; l < length; l++)
    {
        result = result + b%10;
        b = b / 10;
    }
    return result;
}