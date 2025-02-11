using System;

internal class Calculator
{
    private static Int32 Sum(Int32 number1, Int32 number2) { return number1 + number2; }

    private static Int32 Sub(Int32 number1, Int32 number2) { return number1 - number2; }

    private static Int32 Mult(Int32 number1, Int32 number2) { return number1 * number2; }

    private static Int32 Div(Int32 number1, Int32 number2) { return number1 / number2; }

    private static Int32 DrawMenu(bool clear = false)
    {
        if (clear) Console.Clear();

        Console.WriteLine("1 - Sum");
        Console.WriteLine("2 - Subtract");
        Console.WriteLine("3 - multiply");
        Console.WriteLine("4 - Division");
        Console.WriteLine("0 - Exit");
        Console.WriteLine("Type your Option: ");

        string? inputUser = Console.ReadLine();

        if (inputUser == null) return DrawMenu(true);
        if (inputUser == string.Empty) return DrawMenu(true);

        Int32 inputOption = int.Parse(inputUser);

        if (inputOption > -1 && inputOption <= 4) return inputOption;

        return DrawMenu(true);
    }

    private static Int32 InputUser(string message, bool clear = false)
    {
        if (clear) Console.Clear();

        Console.WriteLine($"{message}");

        string? inputUser = Console.ReadLine();

        if (inputUser == null) return InputUser(message, true);
        if (inputUser == string.Empty) return InputUser(message, true);

        return int.Parse(inputUser);
    }

    private static Int32 Calculate(Int32 number1, Int32 number2, Int32 option)
    {
        switch (option)
        {
            case 1:
                return Sum(number1, number2);
            case 2:
                return Sub(number1, number2);
            case 3:
                return Mult(number1, number2);
            case 4:
                return Div(number1, number2);
            default:
                return -1;
        }
    }

    private static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Welcome to calculator");

            Int32 option = DrawMenu(true);

            if (option == 0) break;

            Int32 number1 = InputUser("Digite o primeiro numero: ");
            Int32 number2 = InputUser("Digite o segundo numero: ");

            Int32 result = Calculate(number1, number2, option);

            Console.WriteLine($"the result is: {result}");

            Console.ReadLine();
        }
    }
}