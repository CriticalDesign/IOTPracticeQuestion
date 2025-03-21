using System.Collections.Generic;

namespace IOTPracticeQuestion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> myListOfNumbers = CreateListFromFile("..\\..\\..\\numbers.txt");
            //PrintList(myListOfNumbers);
            int sum = SumOfList(myListOfNumbers);
            int max = Max(myListOfNumbers);


            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Program complete.")

        }

        public static List<int> CreateListFromFile(String fileName)
        {
            List<int> myListOfNumbers = new List<int>();

            StreamReader fileReader = new StreamReader(fileName);

            String line = fileReader.ReadLine();
            while(line != null)
            {
                int num = int.Parse(line);
                myListOfNumbers.Add(num);
                line = fileReader.ReadLine();
            }

            fileReader.Close();

            return myListOfNumbers;
        }
        public static List<int> CreateList()
        {
            List<int> myListOfNumbers = new List<int>();

            Console.Write("Enter a number, -ve to quit: ");
            int number = int.Parse(Console.ReadLine());

            while (number >= 0)
            {
                myListOfNumbers.Add(number);

                Console.Write("Enter a number, -ve to quit: ");
                number = int.Parse(Console.ReadLine());
            }

            return myListOfNumbers;
        }
        public static int SumOfList(List<int> list)
        {
            int sum = 0;
            foreach (int i in list)
            {
                sum += i;
            }
            return sum;
        }
        public static void PrintList(List<int> tempList)
        {
            for (int i = 0; i < tempList.Count; i++)
            {
                Console.WriteLine(tempList[i]);
            }
        }
        public static int Max(List<int> list)
        {
            int max = list[0];
            foreach (int i in list)
            {
                if (i > max)
                    max = i;
            }

            return max;
        }
    }
}
