namespace Week8;

public class BoxingTester
{
    public static void Test()
    {
        int a = 10;
        object b = a; // додаємо посилання в хіп
        int c = (int)b; // анбоксимо з хіпу у змінну

        Console.WriteLine($"a = {a}");
        Console.WriteLine($"b = {b}");
        Console.WriteLine($"c = {c}");
    }
}