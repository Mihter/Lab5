namespace Labs5
{
    internal class Task4
    {
        public static void Main()
        {
            Console.Write("Enter an array: ");
            string[] origin = Console.ReadLine().Split();
            double[] result = new double[origin.Length];
            for (int i = 0; i < origin.Length; i++)
            {
                bool isInt = int.TryParse(origin[i], out int element);
                if (element > 0 && isInt)
                {
                    result[i] = Factorial(element);
                }
                else if (element < 0 && isInt)
                {
                    result[i] = element;
                }
                else
                {
                    double element2 = double.Parse(origin[i]);
                    double result0 = element2 - (int)element2;
                    result[i] = Math.Round(result0, 2);
                }
                Console.Write($"The resulting array: {result[i]}");
            }
        }
        public static double Factorial(double number)
        {
            if (number == 0)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }
    }
}
