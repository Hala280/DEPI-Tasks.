using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    public void PassByRef(ref int x) => x += 10;
    public void PassByValue(int x) => x += 10;

    public (int sum, int difference) Calculate(int a, int b, int c, int d)
    {
        int addition = a + b + c + d;
        int subr = c - d;
        return (addition, subr);
    }

    public void SumOfNumber(int number)
    {
        int original = number;
        int sum = 0;
        string numStr = Math.Abs(number).ToString();
        foreach (char c in numStr)
        {
            sum += (int)char.GetNumericValue(c);
        }
        Console.WriteLine($"The sum of the digits of the number {original} is: {sum}");
    }

    public bool IsPrime(int x)
    {
        if (x <= 1) return false;
        if (x == 2) return true;
        if (x % 2 == 0) return false;
        for (int i = 3; i <= Math.Sqrt(x); i += 2)
            if (x % i == 0) return false;
        return true;
    }

    public void MinMaxArray(int[] arr, ref int min, ref int max)
    {
        min = arr[0];
        max = arr[0];
        foreach (int num in arr)
        {
            if (num < min) min = num;
            if (num > max) max = num;
        }
    }

    public void Factorial(int n)
    {
        if (n < 0) return;
        long result = 1;
        for (int i = 1; i <= n; i++) result *= i;
        Console.WriteLine($"Factorial of {n} is: {result}");
    }

    public void ChangeChar(ref string s, int position, char replace)
    {
        if (position >= 0 && position < s.Length)
        {
            char[] chars = s.ToCharArray();
            chars[position] = replace;
            s = new string(chars);
        }
    }

    public void FindSecondLargest(int[] arr)
    {
        if (arr.Length < 2) return;
        int largest = int.MinValue;
        int secondLargest = int.MinValue;
        foreach (int num in arr)
        {
            if (num > largest)
            {
                secondLargest = largest;
                largest = num;
            }
            else if (num > secondLargest && num != largest)
            {
                secondLargest = num;
            }
        }
        Console.WriteLine($"Second largest number is: {secondLargest}");
    }

    public void LongestDistanceTask()
    {
        Console.WriteLine("Enter array values separated by spaces (e.g. 7 0 0 0 5 7):");
        string input = Console.ReadLine();
        int[] arr = input.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                         .Select(int.Parse).ToArray();

        Dictionary<int, int> firstSeen = new Dictionary<int, int>();
        int maxDist = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (!firstSeen.ContainsKey(arr[i]))
            {
                firstSeen[arr[i]] = i;
            }
            else
            {
                int dist = i - firstSeen[arr[i]] - 1;
                if (dist > maxDist) maxDist = dist;
            }
        }
        Console.WriteLine($"The longest distance is: {maxDist}");
    }

    public void TwoDimArrayTask()
    {
        Console.Write("Enter rows: "); int r = int.Parse(Console.ReadLine());
        Console.Write("Enter cols: "); int c = int.Parse(Console.ReadLine());
        int[,] arr1 = new int[r, c];
        int[,] arr2 = new int[r, c];

        for (int i = 0; i < r; i++)
            for (int j = 0; j < c; j++)
            {
                Console.Write($"Enter value for [{i},{j}]: ");
                arr1[i, j] = int.Parse(Console.ReadLine());
            }

        Array.Copy(arr1, arr2, arr1.Length);
        Console.WriteLine("Array copied. Content of second array:");
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++) Console.Write(arr2[i, j] + " ");
            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        Program p = new Program();
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\n--- Main Menu ---");
            Console.WriteLine("1. Sum of Digits\n2. Is Prime\n3. MinMax (Ref params)\n4. Factorial\n5. Change Char at Index\n6. Second Largest\n7. Longest Distance (User Input)\n8. 2D Array Copy\n0. Exit");
            Console.Write("Select: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter number: ");
                    p.SumOfNumber(int.Parse(Console.ReadLine()));
                    break;
                case "2":
                    Console.Write("Enter number: ");
                    Console.WriteLine("Result: " + p.IsPrime(int.Parse(Console.ReadLine())));
                    break;
                case "3":
                    int[] a = { 10, 5, 20, 8 };
                    int min = 0, max = 0;
                    p.MinMaxArray(a, ref min, ref max);
                    Console.WriteLine($"Min: {min}, Max: {max}");
                    break;
                case "4":
                    Console.Write("Enter number: ");
                    p.Factorial(int.Parse(Console.ReadLine()));
                    break;
                case "5":
                    string text = "Hello";
                    p.ChangeChar(ref text, 1, 'a');
                    Console.WriteLine("Modified: " + text);
                    break;
                case "6":
                    p.FindSecondLargest(new int[] { 1, 5, 10, 10, 8 });
                    break;
                case "7":
                    p.LongestDistanceTask();
                    break;
                case "8":
                    p.TwoDimArrayTask();
                    break;
                case "0":
                    exit = true;
                    break;
            }
        }
    }
}