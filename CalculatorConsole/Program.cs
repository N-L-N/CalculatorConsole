using CalculatorConsole;

while (true)
{
    CalculatorLog calculatorLog = new CalculatorLog();

    Console.WriteLine("Введите первое число: ");

    string? input1 = Console.ReadLine();

    calculatorLog.AddLogEntry($"Введена строка: {input1}");

    if (input1 == null || !double.TryParse(input1, out double number1))
    {
        Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");

        calculatorLog.AddLogEntry($"Введена строка с нечисловым значением: {input1}. ERROR.");

        continue;
    }

    Console.WriteLine("Введите второе число: ");

    string? input2 = Console.ReadLine();

    calculatorLog.AddLogEntry($"Введена строка: {input2}");
    if (input2 == null || !double.TryParse(input2, out double number2))
    {
        Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");

        calculatorLog.AddLogEntry($"Введена строка с нечисловым значением: {input2}. ERROR.");

        continue;
    }

    Calculator calculator = new(number1, number2);

    Console.WriteLine("Выберите операцию: +, -, *, /, %");

    string? operation = Console.ReadLine();

    calculatorLog.AddLogEntry($"Введена строка операции: {operation}");

    switch (operation)
    {
        case "+":
            Console.WriteLine($"Результат: {calculator.Add()}");

            calculatorLog.AddLogEntry($"Результат сложения: {calculator.Add()}");

            break;
        case "-":
            Console.WriteLine($"Результат: {calculator.Subtract()}");

            calculatorLog.AddLogEntry($"Результат вычисления: {calculator.Add()}");

            break;
        case "*":
            Console.WriteLine($"Результат: {calculator.Multiply()}");

            calculatorLog.AddLogEntry($"Результат умножения: {calculator.Multiply()}");

            break;
        case "/":
            try
            {
                Console.WriteLine($"Результат: {calculator.Divide()}");

                calculatorLog.AddLogEntry($"Результат деления: {calculator.Divide()}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);

                calculatorLog.AddLogEntry($"Ошибка: {ex.Message}");
            }
            break;
        case "%":
            Console.WriteLine($"Результат: {calculator.Modulus()}");

            calculatorLog.AddLogEntry($"Результат процента: {calculator.Modulus()}");

            break;
        default:
            Console.WriteLine("Некорректная операция. Пожалуйста, выберите +, -, *, / или %.");

            calculatorLog.AddLogEntry($"Некорректная операция: {operation}. ERROR.");

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