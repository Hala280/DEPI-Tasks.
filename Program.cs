using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string check_tempertaure(double temp)
            {
                if (temp < 10)
                    return "just cold";
                if (temp > 30)
                    return "just hot";
                return "just good";


            }


            bool is_divisable(int num)
            {
                if (num % 3 == 0 && num % 4 == 0)
                    return true;
                return false;
            }

            string is_negative_or_positive(int num)
            {
                if (num < 0)
                    return "negative";
                else if (num > 0)
                    return "positive";
                else
                    return "zero";
            }

            void Max_min(int num1, int num2, int num3)
            {
                int max = num1;
                int min = num1;
                if (num2 > max)
                    max = num2;
                if (num3 > max)
                    max = num3;
                if (num2 < min)
                    min = num2;
                if (num3 < min)
                    min = num3;
                Console.WriteLine("Max: " + max);
                Console.WriteLine("Min: " + min);
            }

            int Num_of_Day_in_Month(int month)
            {
                if (month == 2)
                    return 28;
                else if (month == 4 || month == 6 || month == 9 || month == 11)
                    return 30;
                else
                    return 31;
            }

            string is_vowel_or_consonant(char letter)
            {
                char lowerLetter = char.ToLower(letter);
                if (lowerLetter == 'a' || lowerLetter == 'e' || lowerLetter == 'i' || lowerLetter == 'o' || lowerLetter == 'u')
                    return "vowel";
                else
                    return "consonant";
            }


            Console.WriteLine("choose the program: ");
            Console.WriteLine("1. Check temperature");
            Console.WriteLine("2. Check divisibility");
            Console.WriteLine("3. Check if a number is negative, positive, or zero");
            Console.WriteLine("4. Find the maximum and minimum of three numbers");
            Console.WriteLine("5.Find number of days in a month ");
            Console.WriteLine("6. Check if a letter is a vowel or consonant");
            Console.WriteLine("7. Student Grades program");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case (1):
                    Console.WriteLine("Enter the temperature: ");
                    double temperature = Convert.ToDouble(Console.ReadLine());
                    string check = check_tempertaure(temperature);
                    Console.WriteLine(" temperature is " + check);
                    break;
                case (2):
                    Console.WriteLine("Enter a number: ");
                    int number = Convert.ToInt32(Console.ReadLine());
                    bool check_divisibility = is_divisable(number);
                    if (check_divisibility)
                    {
                        Console.WriteLine(number + " is divisible by 3 and 4");

                    }
                    else
                    {
                        Console.WriteLine(number + " is not divisible by 3 and 4");
                    }
                    break;
                case (3):
                    Console.WriteLine("Enter a number: ");
                    int numberInput = Convert.ToInt32(Console.ReadLine());
                    string check_sign = is_negative_or_positive(numberInput);
                    Console.WriteLine(check_sign);
                    break;
                case (4):
                    Console.WriteLine("Enter three numbers: ");
                    int number1 = Convert.ToInt32(Console.ReadLine());
                    int number2 = Convert.ToInt32(Console.ReadLine());
                    int number3 = Convert.ToInt32(Console.ReadLine());
                    Max_min(number1, number2, number3);
                    break;
                case (5):
                    Console.WriteLine("Enter the month number: ");
                    int month = Convert.ToInt32(Console.ReadLine());
                    int days = Num_of_Day_in_Month(month);
                    Console.WriteLine("Number of days in month " + month + " is: " + days);
                    break;
                case (6):
                    Console.WriteLine("enter the letter: ");
                    char letter = Convert.ToChar(Console.ReadLine());
                    string check_letter = is_vowel_or_consonant(letter);
                    Console.WriteLine(check_letter);
                    break;
                case (7):

                    List<string> names = new List<string>();
                    List<double> grades = new List<double>();
                    Console.WriteLine("How many students do you want to register? ");
                    int numberOfStudents = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < numberOfStudents; i++)
                    {
                        Console.WriteLine("Enter  student " + (i + 1) + " name: ");
                        string name = Console.ReadLine();
                        names.Add(name);
                        Console.WriteLine("Enter " + names[i] + "'s grade: ");
                        double grade = Convert.ToDouble(Console.ReadLine());
                        grades.Add(grade);
                        Console.WriteLine("Student Name: " + name + ", Grade: " + grade);
                    }

                    double sum = 0;
                    double max = grades[0];
                    double min = grades[0];
                    foreach (double i in grades)
                    {
                        sum += i;
                        if (i > max)
                            max = i;
                        if (i < min)
                            min = i;

                    }

                    Console.WriteLine("Average grades: " + sum / numberOfStudents);
                    Console.WriteLine("lowest grade: " + min);
                    Console.WriteLine("highes grade: " + max);

                    string caluclate_letter_grade(double grade)
                    {
                        if (grade >= 90 && grade <= 100)
                            return "A";
                        else if (grade >= 80 && grade < 90)
                            return "B";
                        else if (grade >= 70 && grade < 80)
                            return "C";
                        else if (grade >= 60 && grade < 70)
                            return "D";
                        else
                            return "F";
                    }

                    for (int k = 0; k < numberOfStudents; k++)
                    {
                        string letterGrade = caluclate_letter_grade(grades[k]);
                        Console.WriteLine("Student Name: " + names[k] + ", Grade: " + "letter grade: " + letterGrade);

                    }
                    break;




            }










        }




    }



}












