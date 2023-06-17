namespace ConsoleApp79
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number;
            int numberStart = 0;
            int firstDivisor = 3;
            int secondDivider = 5;
            int maxNumber = 100;
            float finalResult = 0;
            number = random.Next(maxNumber + 1);

            Console.WriteLine("Ваше число:" + number);

            for (int i = numberStart; i <= number; i++)
            {
                if (i % firstDivisor == 0 || i % secondDivider == 0)
                {
                    finalResult += i;
                }
            }

            Console.WriteLine("Общая сумма - " + finalResult);
        }
    }
}