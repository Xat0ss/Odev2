namespace Odev2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.WriteLine("Enter the first number:");
            byte start = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter the scond number:");
            byte end = byte.Parse(Console.ReadLine());

            Console.WriteLine("How many numbers created?:");
            byte count = byte.Parse(Console.ReadLine());


            int[] numbers = new int[count];
            int number;
            for (int i = 0; i < numbers.Length; i++)
            {
                number = rnd.Next(start, end);
                if (i == 0)
                {
                    numbers[i] = number;
                }
                for (int x = 0; x < i; x++)
                {
                    if (numbers[x] == number)
                    {
                        i--;
                        break;
                    }
                    else
                    {
                        numbers[i] = number;
                    }
                }
            }
            Array.Sort(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

        }
    }
}
