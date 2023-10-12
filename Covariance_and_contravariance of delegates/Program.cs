namespace Covariance_and_contravariance_of_delegates
{

    class Calculator
    {
        public static double Add(double x, double y)
        {
            return x + y;
        }

        public static double Subtract(double x, double y)
        {
            return x - y;
        }

        public static double Multiply(double x, double y)
        {
            return x * y;
        }

        public static double Divide(double x, double y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return x / y;
        }
    }


    internal class Program
    {
        static double Calculate(double x, double y, Func<double, double, double> operation)
        {
            return operation(x, y);
        }

        static void Main(string[] args)
        {
            // Создадим методы для арифметических операций
            Func<double, double, double> addDelegate = Calculator.Add;
            Func<double, double, double> subtractDelegate = Calculator.Subtract;
            Func<double, double, double> multiplyDelegate = Calculator.Multiply;
            Func<double, double, double> divideDelegate = Calculator.Divide;

            // Выполним операции с использованием метода Calculate
            double additionResult = Calculate(5, 3, addDelegate);
            double subtractionResult = Calculate(5, 3, subtractDelegate);
            double multiplicationResult = Calculate(5, 3, multiplyDelegate);
            double divisionResult = Calculate(5, 3, divideDelegate);

            Console.WriteLine($"Addition: {additionResult}");
            Console.WriteLine($"Subtraction: {subtractionResult}");
            Console.WriteLine($"Multiplication: {multiplicationResult}");
            Console.WriteLine($"Division: {divisionResult}");
            Console.ReadLine();
        }
    }
}