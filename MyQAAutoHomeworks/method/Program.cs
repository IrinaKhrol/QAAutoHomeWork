namespace method
{
    internal class Program
    {

        static float GetSum(int[] myArray)
        {
            float sum = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                sum += myArray[i];
            }
            sum /= myArray.Length;

            return sum;
        }

        static int GetMinNumber(int[] numbers)
        {
            int minNumber = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < minNumber)
                {
                    minNumber = numbers[i];
                }
            }
            return minNumber;
        }

        static int GetMaxNumber(int[] numbers)
        {
            int maxNumber = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maxNumber)
                {
                    maxNumber = numbers[i];
                }
            }
            return maxNumber;
        }

        static void Main(string[] args)
        {

            int[] student = { 9, 8, 9, 10, 4, 7 };

            float sum = GetSum(student);
            Console.WriteLine(sum);

            int minNumber = GetMinNumber(student);
            Console.WriteLine(minNumber);

            int maxNumber = GetMaxNumber(student);
            Console.WriteLine(maxNumber);

            int[] student2 = { 10, 8, 9, 10, 10, 9 };

            sum = GetSum(student2);
            Console.WriteLine(sum);

            int minNumber2 = GetMinNumber(student2);
            Console.WriteLine(minNumber2);

            int maxNumber2 = GetMaxNumber(student2);
            Console.WriteLine(maxNumber2);

            int[] student3 = { 9, 8, 8, 10, 4, 7 };

            sum = GetSum(student3);
            Console.WriteLine(sum);

            int minNumber3 = GetMinNumber(student3);
            Console.WriteLine(minNumber3);

            int maxNumber3 = GetMaxNumber(student3);
            Console.WriteLine(maxNumber3);

            int[] student4 = { 10, 10, 9, 10, 7, 8 };

            sum = GetSum(student4);
            Console.WriteLine(sum);

            int minNumber4 = GetMinNumber(student4);
            Console.WriteLine(minNumber4);

            int maxNumber4 = GetMaxNumber(student4);
            Console.WriteLine(maxNumber4);

            int[] student5 = { 8, 9, 7, 10, 4, 7 };

            sum = GetSum(student5);
            Console.WriteLine(sum);

            int minNumber5 = GetMinNumber(student5);
            Console.WriteLine(minNumber5);

            int maxNumber5 = GetMaxNumber(student5);
            Console.WriteLine(maxNumber5);

            maxNumber5 = GetMaxNumber(student5);
            Console.WriteLine(maxNumber5);
        }

    }
}





