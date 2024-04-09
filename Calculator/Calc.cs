namespace Calculator;

public class Calc
{
    public static double DoOperation(double num1, double num2, string op)
    {
        double result = double.NaN;

        switch (op)
        {
            case "a":
                result = num1 + num2;
                break;
            case "s":
                result = num1 - num2;
                break;
            case "m":
                result = num1 * num2;
                break;
            case "d":
                while (num2 == 0)
                {
                    Console.Write("Please enter non-zero divisor: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                }
                result = num1 / num2;

                break;
            default:
                break;
        }

        return result;
    }
}