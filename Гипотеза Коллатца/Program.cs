namespace Гипотеза_Коллатца
{
    internal class Program
    {
        public int steps(int number)
        {
            if (number > 0)
            {
                int step = 0;
                while (number != 1)
                {
                    if (number % 2 == 0)
                    {
                        number /= 2;
                    }
                    else
                    {
                        number = number * 3 + 1;
                    }
                    step++;
                }
                return step;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Количество шагов: {program.steps(number)}");
        }
    }
}