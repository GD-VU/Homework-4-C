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
int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next(0,999);
    }
System.Console.WriteLine(string.Join(", ", array));
}