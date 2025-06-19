using CalculatorConsole;

while (true)
{
    

    Console.WriteLine("Введите первое число: ");

    string? input1 = Console.ReadLine();

    CalculatorLog.AddLogEntry($"Введена строка: {input1}");

    if (input1 == null || !double.TryParse(input1, out double number1))
    {
        Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");

        CalculatorLog.AddLogEntry($"Введена строка с нечисловым значением: {input1}. ERROR.");

        continue;
    }

    Console.WriteLine("Введите второе число: ");

    string? input2 = Console.ReadLine();

    CalculatorLog.AddLogEntry($"Введена строка: {input2}");
    if (input2 == null || !double.TryParse(input2, out double number2))
    {
        Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");

        CalculatorLog.AddLogEntry($"Введена строка с нечисловым значением: {input2}. ERROR.");

        continue;
    }

    Calculator calculator = new(number1, number2);

    Console.WriteLine("Выберите операцию: +, -, *, /, %");

    string? operation = Console.ReadLine();

    CalculatorLog.AddLogEntry($"Введена строка операции: {operation}");

    switch (operation)
    {
        case "+":
            Console.WriteLine($"Результат: {calculator.Add()}");

            CalculatorLog.AddLogEntry($"Результат сложения: {calculator.Add()}");

            break;
        case "-":
            Console.WriteLine($"Результат: {calculator.Subtract()}");

            CalculatorLog.AddLogEntry($"Результат вычисления: {calculator.Add()}");

            break;
        case "*":
            Console.WriteLine($"Результат: {calculator.Multiply()}");

            CalculatorLog.AddLogEntry($"Результат умножения: {calculator.Multiply()}");

            break;
        case "/":
            try
            {
                Console.WriteLine($"Результат: {calculator.Divide()}");

                CalculatorLog.AddLogEntry($"Результат деления: {calculator.Divide()}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);

                CalculatorLog.AddLogEntry($"Ошибка: {ex.Message}");
            }
            break;
        case "%":
            Console.WriteLine($"Результат: {calculator.Modulus()}");

            CalculatorLog.AddLogEntry($"Результат процента: {calculator.Modulus()}");

            break;
        default:
            Console.WriteLine("Некорректная операция. Пожалуйста, выберите +, -, *, / или %.");

            CalculatorLog.AddLogEntry($"Некорректная операция: {operation}. ERROR.");

            break;
    }

    Console.WriteLine("Хотите продолжить? (да/нет)");
    string? continueInput = Console.ReadLine()?.ToLower();
    if (continueInput != "да" && continueInput != "yes")
    {
        CalculatorLog.ShowHistory();
        break;
    }
    Console.Clear();

}