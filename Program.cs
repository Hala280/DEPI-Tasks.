using StudentDataLibrary;


class StudentConsoleApp
{
    static void Main(string[] args)
    {

        StudentGrades obj1 = new StudentGrades();
        StudentGrades obj2 = new StudentGrades();

        bool running = true;
        while (running)
        {
            Console.Clear();
            Console.WriteLine("=== Student Management System ===");
            Console.WriteLine("1. Initialize and Enter Data (obj1)");
            Console.WriteLine("2. Display Data (obj1)");
            Console.WriteLine("3. Calculate Average (Student 1 in obj1)");
            Console.WriteLine("4. Show Total Sum (obj1)");
            Console.WriteLine("5. Exit");
            Console.Write("\nSelect an option: ");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter number of students: ");
                    string? countInput = Console.ReadLine();
                    if (int.TryParse(countInput, out int count))
                    {
                        obj1.Intialize(count);
                        obj1.PopulateGrades();
                    }
                    else
                    {
                        Console.WriteLine("Invalid number entered.");
                    }
                    break;
                case "2":
                    obj1.DisplayGrades();
                    break;
                case "3":

                    Console.WriteLine($"Average: {obj1.GetAverageGrade(0)}");
                    break;
                case "4":
                    Console.WriteLine($"Total Sum: {obj1.GetTotalSum()}");
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            if (running)
            {
                Console.WriteLine("\nPress any key to return to menu...");
                Console.ReadKey();
            }
        }
    }
}