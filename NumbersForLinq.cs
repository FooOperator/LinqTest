namespace a
{

    public class NumbersForLinq
    {
        public static void FindDivisibleBy(int[] numbers, int divisor)
        {
            var results = from number in numbers
                          where (number % divisor) == 0
                          select number;
            foreach (var item in results)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        public static void FindGreaterThan(int[] numbers, int threshold)
        {
            var results = from number in numbers
                          where number > threshold
                          select number;
            foreach (var item in results)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }


    }

}
