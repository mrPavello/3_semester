using System;
using System.Diagnostics.Metrics;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        //task 1.a
        bool boolVal = false;
        byte byteVal = 255;
        sbyte sByteVal = -128;
        char charVal = 'r';
        decimal decimalVal = 123.3M;
        double doubleVal = 9.444;
        float floatVal = 3.4F;
        int intVal = 4;
        uint uintVal = 45U;
        long longVal = 53939502L;
        ulong ulongVal = 58493053UL;
        short shortVal = 4224;
        ushort ushortVal = 5849;

        Console.WriteLine("\nВведите значения переменных:");
        Console.Write("Boolean Value: ");
        boolVal = Convert.ToBoolean(Console.ReadLine());

        Console.Write("Byte Value: ");
        byteVal = Convert.ToByte(Console.ReadLine());

        Console.Write("SByte Value: ");
        sByteVal = Convert.ToSByte(Console.ReadLine());

        Console.Write("Char Value: ");
        charVal = Convert.ToChar(Console.ReadLine());

        Console.Write("Decimal Value: ");
        decimalVal = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Double Value: ");
        doubleVal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Float Value: ");
        floatVal = Convert.ToSingle(Console.ReadLine());

        Console.Write("Int Value: ");
        intVal = Convert.ToInt32(Console.ReadLine());

        Console.Write("UInt Value: ");
        uintVal = Convert.ToUInt32(Console.ReadLine());

        Console.Write("Long Value: ");
        longVal = Convert.ToInt64(Console.ReadLine());

        Console.Write("ULong Value: ");
        ulongVal = Convert.ToUInt64(Console.ReadLine());

        Console.Write("Short Value: ");
        shortVal = Convert.ToInt16(Console.ReadLine());

        Console.Write("UShort Value: ");
        ushortVal = Convert.ToUInt16(Console.ReadLine());

        Console.WriteLine("Boolean Value: " + boolVal);
        Console.WriteLine("Byte Value: " + byteVal);
        Console.WriteLine("SByte Value: " + sByteVal);
        Console.WriteLine("Char Value: " + charVal);
        Console.WriteLine("Decimal Value: " + decimalVal);
        Console.WriteLine("Double Value: " + doubleVal);
        Console.WriteLine("Float Value: " + floatVal);
        Console.WriteLine("Int Value: " + intVal);
        Console.WriteLine("UInt Value: " + uintVal);
        Console.WriteLine("Long Value: " + longVal);
        Console.WriteLine("ULong Value: " + ulongVal);
        Console.WriteLine("Short Value: " + shortVal);
        Console.WriteLine("UShort Value: " + ushortVal);

        //task 1.b
        Console.WriteLine();
        int k = 45;
        float g_1 = (float)k;
        Console.WriteLine($"g = {g_1}");

        byte g_2 = (byte)k;
        Console.WriteLine($"g_2 = {g_2}");

        char g_3 = (char)k;
        Console.WriteLine($"g_3 = {g_3}");

        decimal g_4 = (decimal)k;
        Console.WriteLine($"g_4 = {g_4}");

        short g_5 = (short)k;
        Console.WriteLine($"g_5 = {g_5}");
        ///////////
        byte k_2 = 4;
        float d_1 = k_2;
        Console.WriteLine($"g = {d_1}");

        int d_2 = k_2;
        Console.WriteLine($"g_2 = {d_2}");

        double d_3 = k_2;
        Console.WriteLine($"g_3 = {d_3}");

        decimal d_4 = k_2;
        Console.WriteLine($"g_4 = {d_4}");

        short d_5 = k_2;
        Console.WriteLine($"g_5 = {d_5}");

        //Task 1.c
        Console.WriteLine();
        int intVal1 = 4;
        object objVal = intVal1;
        Console.WriteLine($"objVal = {objVal}");

        int unboxedInt = (int)objVal;
        Console.WriteLine($"unboxedInt = {unboxedInt}");
        ///////
        double doubleVal1 = 54.45;
        objVal = doubleVal1;
        Console.WriteLine($"objVal = {objVal}");

        double unboxedDouble = (double)objVal;
        Console.WriteLine($"unboxedDouble = {unboxedDouble}");
        //////
        byte byteVal1 = 4;
        objVal = byteVal1;
        Console.WriteLine($"objVal = {objVal}");

        byte unboxedByte = (byte)objVal;
        Console.WriteLine($"unboxedByte = {unboxedByte}");

        //Task 1.d
        Console.WriteLine();
        var varVal = 45.664;
        varVal += 56.333;
        Console.WriteLine($"varVal = {varVal}");

        //Task 1.e
        Console.WriteLine();
        int? nullableInt = null;
        if (nullableInt.HasValue)
        {
            Console.WriteLine($"nullableInt = {nullableInt}");
        }
        else
        {
            Console.WriteLine("nullableInt не имеет значения");
        }
        nullableInt = 54;
        if (nullableInt.HasValue)
        {
            Console.WriteLine($"nullableInt = {nullableInt}");
        }
        else
        {
            Console.WriteLine("nullableInt не имеет значения");
        }

        //Task 1.f
        //var varVal2 = "goal";
        //varVal2 = 45; //ошибка, т к тип переменной varVal2 орпеделился как string на этапе компиляции и больше не изменяется


        //Task 2.a
        Console.WriteLine();
        string str1 = "word";
        string str2 = "letter";
        Console.WriteLine(str1 == str2);
        bool strEqual = str1.Equals(str2);
        Console.WriteLine(strEqual);

        str2 = "word";
        int compareStrs = String.Compare(str1, str2);
        Console.WriteLine(compareStrs);
        str2 = "cooooooolll";
        compareStrs = String.Compare(str1, str2);
        Console.WriteLine(compareStrs);

        //Task 2.b
        Console.WriteLine();
        string strb1 = "The weather";
        string strb2 = "is cool";
        string strb3 = "today.";

        string concatenatedStr = strb1 + " " + strb2 + " " + strb3;
        Console.WriteLine(concatenatedStr);

        string copiedStr = strb3;
        Console.WriteLine(copiedStr);

        string substring = strb3.Substring(2, strb3.Length - 3);
        Console.WriteLine(substring);

        string[] words = concatenatedStr.Split(' ');
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

        string insertStr = strb2.Insert(3, "not ");
        Console.WriteLine(insertStr);

        string removeStr = concatenatedStr.Remove(19, strb3.Length);
        Console.WriteLine(removeStr);

        string interpolatedStr = $"{strb1} {strb2} in Belarus.";
        Console.WriteLine(interpolatedStr);


        //Task 2.c
        Console.WriteLine();
        string emptyStr = "";
        string nullStr = null;
        Console.WriteLine($"emptyStr: {string.IsNullOrEmpty(emptyStr)}");
        Console.WriteLine($"nullStr: {string.IsNullOrEmpty(nullStr)}");

        Console.WriteLine($"Length of emptyStr {emptyStr.Length}");

        if (nullStr != null)
        {
            Console.WriteLine($"Length of nullStr {nullStr.Length}");
        }
        else
        {
            Console.WriteLine("Length of nullStr is null");
        }

        string concstenatedStr = emptyStr + "String with emptyStr";
        Console.WriteLine(concstenatedStr);

        Console.WriteLine($"emptyStr is null or whitespace: {string.IsNullOrWhiteSpace(emptyStr)}");
        Console.WriteLine($"nullStr is null or whitespace: {string.IsNullOrWhiteSpace(nullStr)}");

        //Task 2.d
        Console.WriteLine();
        StringBuilder sb = new StringBuilder("Hello guys!");
        sb.Remove(5, 5);
        Console.WriteLine(sb.ToString());

        sb.Insert(0, "Phrase: '");
        Console.WriteLine(sb.ToString());

        sb.Append("'");
        Console.WriteLine(sb.ToString());


        //Task 3.a
        Console.WriteLine();
        int[,] matryx =
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };
        for (int i = 0; i < matryx.GetLength(0); i++)
        {
            for (int j = 0; j < matryx.GetLength(1); j++)
            {
                Console.Write($"{matryx[i, j]}\t");
            }
            Console.WriteLine();
        }

        //Task 3.b
        Console.WriteLine();
        string[] fruits = { "apple", "banana", "lemon", "orange", "pineapple", "pear" };
        PrintArray(fruits);
        Console.WriteLine($"Length of array: {fruits.Length}");

        int position = GetPosition();
        Console.WriteLine("Введите новое значение:");
        fruits[position] = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Новый массив:");
        PrintArray(fruits);


        static void PrintArray(string[] array)
        {
            Console.WriteLine(string.Join(" ", array));
        }

        static int GetPosition()
        {
            int position;
            while (true)
            {
                Console.Write("Введите позицию в элемента, который нужно изменить (0-5): ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out position) && position >= 0 && position <= 5)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка! Недопустимое число.");
                }
            }
            return position;
        }


        //Task 3.c
        double[][] jaggedArr = new double[3][];
        jaggedArr[0] = new double[2];
        jaggedArr[1] = new double[3];
        jaggedArr[2] = new double[4];

        Console.WriteLine("\nЗаполните массив:");
        for (int i = 0; i < jaggedArr.Length; i++)
        {
            for(int j = 0; j < jaggedArr[i].Length; j++)
            {
                Console.WriteLine($"jaggedArr[{i}][{j}]: ");
                jaggedArr[i][j] = double.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("\nВведенные значения массива:");
        for (int i = 0; i < jaggedArr.Length; i++)
        {
            for (int j = 0; j < jaggedArr[i].Length; j++)
            {
                Console.Write($"{jaggedArr[i][j]} ");
            }
            Console.WriteLine();
        }

        //Task 3.d
        Console.WriteLine();
        var forArr = new[] { "apple", "pear" };
        var forString = "Hello!";
        Console.WriteLine(string.Join(", ", forArr));
        Console.WriteLine(forString);

        //Task 4.a-с
        var myTuple = (33, "cow", 'w', "horse", 324244445566646645UL);

        Console.WriteLine(myTuple);
        Console.WriteLine($"1-й элемент: {myTuple.Item1}");
        Console.WriteLine($"3-й элемент: {myTuple.Item3}");
        Console.WriteLine($"4-й элемент: {myTuple.Item4}");

        //раcпаковка кортежа в отдельные переменные
        (int number, string animal1, char symbol, string animal2, ulong bigNumber) = myTuple;

        Console.WriteLine($"number: {number}");
        Console.WriteLine($"animal1: {animal1}");
        Console.WriteLine($"symbol: {symbol}");
        Console.WriteLine($"animal2: {animal2}");
        Console.WriteLine($"bigNumber: {bigNumber}");

        //распаковка кортежа с использованием существующих переменных
        int number1;
        string animal3;
        char symbol2;
        string animal4;
        ulong bigNumber2;
        (number1, animal3, symbol2, animal4, bigNumber2) = myTuple;

        Console.WriteLine($"\nnumber: {number1}");
        Console.WriteLine($"animal3: {animal3}");
        Console.WriteLine($"symbol2: {symbol2}");
        Console.WriteLine($"animal4: {animal4}");
        Console.WriteLine($"bigNumber2: {bigNumber2}");

        //частичная распаковка с ипользованием переменной _
        (int number3, _, char symbol3, string animal5, _) = myTuple;
        Console.WriteLine($"\nnumber3: {number3}");
        Console.WriteLine($"symbol3: {symbol3}");
        Console.WriteLine($"animal5: {animal5}");

        //Рапаковка с помощью метода
        static void PrintTuple((int, string, char, string, ulong) tuple)
        {
            var (number, animal1, symbol, animal2, bigNumber) = tuple;
            Console.WriteLine($"\nnumber: {number}");
            Console.WriteLine($"animal1: {animal1}");
            Console.WriteLine($"symbol: {symbol}");
            Console.WriteLine($"animal2: {animal2}");
            Console.WriteLine($"bigNumber: {bigNumber}");
        }
        PrintTuple(myTuple);

        //Task 4.d
        var tuple1 = (23, 44, "cat");
        var tuple2 = (44, 55, "dog");
        bool chekTuples = tuple1 == tuple2;
        Console.WriteLine($"\nСравнение кортежей: {chekTuples}");

        //Task 5
        int[] intArray = { 1, 3, 4, 5, 23, 53, 0 };
        string wordForFunc = "Celebration";

        (int max, int min, int sumArray, char firstLetter) LocalFunc(int[] array, string word)
        {
            int max = array[0];
            int min = array[0];
            int sum = 0;
            foreach (int i in array)
            {
                if (max < i) max = i;
                if (min > i) min = i;
                sum += i;
            }

            char s = word.Length > 0 ? word[0] : '\0';

            return (max, min, sum, s);
        }
        var resultTuple = LocalFunc(intArray, wordForFunc);
        Console.WriteLine($"\nMax: {resultTuple.max}");
        Console.WriteLine($"Min: {resultTuple.min}");
        Console.WriteLine($"Sum: {resultTuple.sumArray}");
        Console.WriteLine($"First Letter: {resultTuple.firstLetter}");

        //Task 6.a
        void CheckedFunction()
        {
            try
            {
                checked
                {
                    int intVal = int.MaxValue;
                    Console.WriteLine($"\nintVal = {intVal}");
                    intVal += 2;
                    Console.WriteLine($"intVal + 2 = {intVal}");
                }
            }
            catch ( Exception ex )
            {
                Console.WriteLine(ex.Message);
            }
        }
        void UncheckesFunction()
        {
            try
            {
                unchecked
                {
                    int intVal = int.MaxValue;
                    Console.WriteLine($"\nintVal = {intVal}");
                    intVal += 2;
                    Console.WriteLine($"intVal + 2 = {intVal}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        CheckedFunction();
        UncheckesFunction();

    }
}