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


        /// <summary>
        ///  Напишите класс Calculator, 
        ///  который содержит статические методы для выполнения арифметических операций над двумя числами типа double: double Add(double x, double y), double Subtract(double x, double y), double Multiply(double x, double y) и double Divide(double x, double y). 
        ///  Затем напишите метод, который принимает на вход два числа типа double и делегат типа Func<double, double, double> и возвращает результат выполнения делегата над этими числами. Продемонстрируйте использование ковариантности и контрвариантности при передаче различных методов калькулятора в этот метод.
        /// </summary>
        /// <param name="args"></param>
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