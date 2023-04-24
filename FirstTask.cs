namespace Library
{
    public class Task1
    {

        public static string GetEnummerateString(int EnumurateLenght)
        {
            if (EnumurateLenght != 0)
            {
                return string.Join(", ", Enumerable.Range(1, EnumurateLenght)) + ".";
            }

            throw new ArgumentException();
        }


        public void ConsoleOut()
        {
            Console.Write("Введите число N: ");
            Console.WriteLine(GetEnummerateString(int.Parse(Console.ReadLine())));
        }
    }
    public class Task2
    {
        /// <summary>
        /// Возвращает строку с квадратом из "решеток"
        /// </summary>
        /// <param name="SideLength">должен быть не чётным и больше 3</param>
        /// <returns></returns>
        public static string GetSharpSquare(int SideLength)
        {
            if (SideLength > 3 && SideLength % 2 != 0)
            {
                string result = "";
                for (int row = 1; row <= SideLength; row++)
                {
                    for (int col = 1; col <= SideLength; col++)
                    {
                        if (row == SideLength / 2 + 1 && col == SideLength / 2 + 1) result += " ";
                        else result += "#";
                    }
                    result += "\n";
                }
                return result;
            }
            throw new ArgumentException();
        }
        public static void ConsoleOut()
        {
            Console.Write("Введите нечетное число N: ");
            Console.WriteLine(GetSharpSquare(int.Parse(Console.ReadLine())));
        }
    }
}
