namespace TestUvarovCsharp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose one of the three tasks (1-3) or enter 0 to quit");
                byte choice;

                if(!byte.TryParse(Console.ReadLine(), out choice) && choice > 4)
                {
                    Console.WriteLine("Input value have to be from 1 to 4");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter number");
                        int number = int.Parse(Console.ReadLine());
                        if (IsGreaterThanSeven(number))
                            Console.WriteLine("Привет");

                        break;
                    case 2:
                        Console.WriteLine("Enter name");
                        string name = Console.ReadLine();
                        if (IsStringVyacheslav(name))
                            Console.WriteLine("Привет, Вячеслав");
                        else
                            Console.WriteLine("Нет такого имени");

                        break;
                    case 3:
                        Console.WriteLine("Enter array length");
                        int[] array = CreateRandomArray(int.Parse(Console.ReadLine()));
                        var elementsMultipleOfThree = GetElementsMultipleOfThree(array);

                        Console.WriteLine("elementsMultipleOfThree:");
                        foreach ( var element in elementsMultipleOfThree)
                        {
                            Console.Write(element.ToString() + ';');
                        }
                        Console.WriteLine();

                        break;
                    case 0:
                        return;
                }
            }
        }

        static bool IsGreaterThanSeven(int number) => number > 7;

        static bool IsStringVyacheslav(string name) => name == "Вячеслав";

        static IEnumerable<int> GetElementsMultipleOfThree(int[] array)
        {
            foreach (var element in array)
                if(element % 3 == 0)
                    yield return element;
        }

        static int[] CreateRandomArray(int length)
        {
            int[] array = new int[length];
            Random generator= new Random();

            for (int i = 0; i < length; i++)
                array[i] = generator.Next(1000);

            return array;
        }
    }
}