using CalculatorConsole;

while (true)
{
    Console.WriteLine("Введите первое число: ");

    string? input1 = Console.ReadLine();

    if (input1 == null || !double.TryParse(input1, out double number1))
    {
        Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
        continue;
    }

    Console.WriteLine("Введите второе число: ");

    string? input2 = Console.ReadLine();
    if(input2 == null || !double.TryParse(input2, out double number2))
    {
        Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
        continue;
    }

    Calculator calculator = new(number1, number2);

    Console.WriteLine("Выберите операцию: +, -, *, /, %");

    string? operation = Console.ReadLine();

    switch (operation)
    {
        case "+":
            Console.WriteLine($"Результат: {calculator.Add()}");
            break;
        case "-":
            Console.WriteLine($"Результат: {calculator.Subtract()}");
            break;
        case "*":
            Console.WriteLine($"Результат: {calculator.Multiply()}");
            break;
        case "/":
            try
            {
                Console.WriteLine($"Результат: {calculator.Divide()}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;
        case "%":
            Console.WriteLine($"Результат: {calculator.Modulus()}");
            break;
        default:
            Console.WriteLine("Некорректная операция. Пожалуйста, выберите +, -, *, / или %.");
            break;
    }

    Console.WriteLine("Хотите продолжить? (да/нет)");
    string? continueInput = Console.ReadLine()?.ToLower();
    if (continueInput != "да" && continueInput != "yes")
    {
        break;
    }
    Console.Clear();
}