using System.Runtime.InteropServices.JavaScript;


namespace StudentDataLibrary
{
    public class StudentGrades
    {
        private double[][] _grades;

        public int StudentCount { get; private set; }

        public void Intialize(int studentCount)
        {
            StudentCount = studentCount;
            _grades = new double[StudentCount][];
        }

        public void PopulateGrades()
        {
            for (int i = 0; i < StudentCount; i++)
            {
                Console.WriteLine($"enter the number of subjects for student {i + 1}");

                int numOfSubjects = int.Parse(Console.ReadLine());

                _grades[i] = new double[numOfSubjects];

                for (int j = 0; j < numOfSubjects; j++)
                {
                    Console.WriteLine($"enter the grade of the subject{j + 1}");

                    _grades[i][j] = double.Parse(Console.ReadLine());

                }
            }

        }

        public void DisplayGrades()
        {
            for (int i = 0; i < _grades.Length; i++)
            {
                Console.WriteLine($"Student number {i + 1} Grades: ");

                for (int j = 0; j < _grades[i].Length; j++)
                {
                    Console.WriteLine(_grades[i][j]);


                }
                Console.WriteLine();

            }



        }

        public double GetAverageGrade(int studentIndex)
        {
            double sum = 0;
            for (int i = 0; i < _grades[studentIndex].Length; i++)
            {
                sum += _grades[studentIndex][i];


            }
            return (sum / _grades[studentIndex].Length);
        }

        public double GetTotalSum()
        {
            double sum = 0;
            foreach (var row in _grades)
            {
                if (row != null)
                {
                    foreach (var grade in row)
                    {
                        sum += grade;

                    }
                }

            }
            return sum;
        }

        public static StudentGrades operator +(StudentGrades obj1, StudentGrades obj2)
        {
            StudentGrades result = new StudentGrades();
            result.Intialize(obj1.StudentCount + obj2.StudentCount);

            for (int i = 0; i < obj1.StudentCount; i++)
            {
                result._grades[i] = obj1._grades[i];
            }
            for (int i = 0; i < obj2.StudentCount; i++)
            {
                result._grades[obj1.StudentCount + i] = obj2._grades[i];
            }
            return result;

        }


        public static bool operator ==(StudentGrades obj1, StudentGrades obj2)
        {
            if (obj1.StudentCount != obj2.StudentCount)
            {
                return false;

            }

            for (int i = 0; i < obj1.StudentCount; i++)
            {
                if (obj1._grades[i].Length != obj2._grades[i].Length)
                {
                    return false;
                }

                for (int j = 0; j < obj1._grades[i].Length; j++)
                {
                    if (obj1._grades[i][j] != obj2._grades[i][j])
                    {
                        return false;
                    }

                }
            }

            return true;
        }
        public static bool operator !=(StudentGrades obj1, StudentGrades obj2)
        {


            return (obj1 == obj2);
        }



    }
}
