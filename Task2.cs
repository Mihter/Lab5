namespace Labs5
{
    internal class Task2
    {
        public static void Main()
        {
            Console.Write("Введите число: ");
            string num = Console.ReadLine();
            int summ = 0;
            bool mark = true;
            for (int i = 0; i < num.Length; i++)
            {
                char notInt = (char)num[i];
                if (!(notInt >= 48 && notInt <= 57))
                {
                    Console.WriteLine("Введённое число не является целым.");
                    mark = false;
                    break;
                }
                summ += notInt - '0';
            }
            if (mark)
            {
                Console.WriteLine($"Число {num} является целым.");
                Console.WriteLine($"Сумма цифр введённого числа равно: {summ}.");
            }

        }
    }
}
