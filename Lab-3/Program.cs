using System;

class Program
{
    static void Main(string[] args)
    {
        string expression = "15+4=19";

        // Розділяємо вираз на операнди та знак дорівнює
        string[] parts = expression.Split('=');
        string operands = parts[0];
        int result = int.Parse(parts[1]);

        // Розділяємо операнди на лівий та правий операнди та знак операції
        string[] operandParts = operands.Split(new char[] { '+', '-' }, StringSplitOptions.RemoveEmptyEntries);
        int operand1 = int.Parse(operandParts[0]);
        char operation = operands[operandParts[0].Length]; // Знак операції між операндами
        int operand2 = int.Parse(operandParts[1]);

        // Виконуємо операцію
        int calculatedResult = 0;
        if (operation == '+')
        {
            calculatedResult = operand1 + operand2;
        }
        else if (operation == '-')
        {
            calculatedResult = operand1 - operand2;
        }

        // Перевіряємо, чи отриманий результат співпадає з результатом виразу
        if (calculatedResult == result)
        {
            Console.WriteLine("Вираз є вірним.");
        }
        else
        {
            Console.WriteLine("Вираз є невірним.");
        }
    }
}
