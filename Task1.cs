namespace Labs5
{
    internal class Task1
    {
        public static void Main()
        {

            while (true)
            {
                double lastNumber = 0;
                Console.Write("Введите число: ");
                string num = Console.ReadLine();
                bool isInt = int.TryParse(num, out int intNumber);
                bool isDouble = double.TryParse(num, out double doubleNumber);
                if (isInt)
                {
                    Console.WriteLine($"Числу {num} соответсвует символ {(char)intNumber} ");
                    lastNumber = intNumber;
                }
                else if (isDouble)
                {
                    if (doubleNumber == lastNumber)
                    {
                        Console.WriteLine($"Введённое число равно предыдущему числу .");
                        Console.WriteLine("Программа завершена.");
                        break;
                    }
                    lastNumber = doubleNumber;
                }
                else if (num == "q")
                {
                    Console.WriteLine("Программа завершена.");
                    break;
                }
            }

        }
    }
}
