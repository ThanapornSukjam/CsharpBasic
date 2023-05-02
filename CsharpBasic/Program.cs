//Console.WriteLine("Hello, World!");
//Console.Write("Hello, World!");

//int num1 = 0;
//long num2 = 10;

//Console.WriteLine(num1);
//Console.WriteLine(num2);

//char myChar =  'a';

//double d1 = 700;
//int d2 = Convert.ToInt32(d1);

//string num1 = "1000";
//string num2 = "500";

//int num3 = int.Parse(num1);
//int num4 = int.Parse(num2);

//Console.WriteLine(d2);

//int num1 = 5;
//int num2 = 10;

//double num3 = 9.7;

//Console.WriteLine(Math.Ceiling(num3);

//--------LAB1-------------
/*Console.Write("Name : ");
string Name1 = Console.ReadLine();
Console.Write("Input Weight(kg) : ");
double Weight1 = double.Parse(Console.ReadLine());
Console.Write("Input Height(cm) : ");
double Height1 = double.Parse(Console.ReadLine());

Console.Write("--------2--------");
Console.Write("\n Name : ");
string Name2 = Console.ReadLine();
Console.Write("Input Weight(kg) : ");
double Weight2 = double.Parse(Console.ReadLine());
Console.Write("Input Height(cm) : ");
double Height2 = double.Parse(Console.ReadLine());

double BMI1 = Math.Round(Weight1 / Math.Pow(Height1 / 100, 2), 2);
double BMI2 = Math.Round(Weight2 / Math.Pow(Height2 / 100, 2), 2);

Console.WriteLine($"\n {Name1} BMI = {BMI1}");
Console.WriteLine($"\n {Name2} BMI = {BMI2}");*/

//double x = 7;
//double y = 3;

//Console.WriteLine(x % y);

//double x1 = x++;
//double x2 = ++x;

//Console.WriteLine(x++);
//Console.WriteLine(++y);


/*double x = 7;
Console.WriteLine(x=3);
x = 7;
Console.WriteLine(x+=3);
x = 7;
Console.WriteLine(x = 3);
x = 7;
Console.WriteLine(x += 3);*/



//--------LAB2-------------
/*using System;
class Program
{
    static void Main(string[] args)
    {
        string position;
        float salary;

        Console.Write("Enter your position : ");
        position = Console.ReadLine();

        Console.Write("Enter your salary: ");
        salary = float.Parse(Console.ReadLine());

        float SalaryIncrease = 0;
        switch (position)
        {
            case "Assistant Developer":
                SalaryIncrease = 1.05f;
                break;
            case "IT Support":
                SalaryIncrease = 1.07f;
                break;
            case "Senior Developer":
                SalaryIncrease = 1.1f;
                break;
            case "Administrator":
                SalaryIncrease = 1.08f;
                break;
            default:
                SalaryIncrease = 1.03f;
                break;
        }

        float bonus = salary * SalaryIncrease;
        float newSalary = salary + bonus;
        Console.WriteLine("Salary increase: {0}", bonus);
        Console.WriteLine("New salary: {0}", newSalary);
    }
}*/



//--------LAB3-------------
/*using System;
using static System.Formats.Asn1.AsnWriter;

class Program
{
    static void Main(string[] args)
    {
        int numStudents;
        do
        {
            Console.Write("Enter number of students: ");
        } while (!int.TryParse(Console.ReadLine(), out numStudents) || numStudents <= 0);

        string[] studentIDs = new string[numStudents];
        double[] studentScores = new double[numStudents];

        for (int i = 0; i < numStudents; i++)
        {
            Console.Write($"Enter student ID for student {i + 1}: ");
            string id = Console.ReadLine();
            studentIDs[i] = id;

            double score;
            do
            {
                Console.Write($"Enter score for student {i + 1}: ");
            } while (!double.TryParse(Console.ReadLine(), out score) || score < 0 || score > 100);
            studentScores[i] = score;
        }

        char input;
        do
        {
            Console.Write("Exit? (Y/N): ");
            input = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();
        } while (input != 'Y' && input != 'N');

        if (input == 'Y')
        {
            Console.WriteLine("Student Data:");
            for (int i = 0; i < numStudents; i++)
            {
                Console.WriteLine($"Student ID: {studentIDs[i]}, Score: {studentScores[i]}");
            }
        }
        else
        {
            Main(args);
        }
    }
}*/



//--------LAB4-------------
// Parent Class
public class ParentClass
{
    // Attribute
    public string parentAttribute;

    // Method
    public void ParentMethod()
    {
        Console.WriteLine("This is parent method.");
    }
}

//Child Class
public class ChildClass : ParentClass
{
    // Attribute
    public string childAttribute;

    // Method
    public void ChildMethod()
    {
        Console.WriteLine("This is child method.");
    }

    // Constructor Method
    public ChildClass(string parentAttribute, string childAttribute)
    {
        this.parentAttribute = parentAttribute;
        this.childAttribute = childAttribute;
    }
}

// Program Class
class Program
{
    static void Main(string[] args)
    {
        // Create object from Child Class
        ChildClass obj = new ChildClass("Parent Attribute", "Child Attribute");

        obj.ParentMethod();
        obj.ChildMethod();

        // Access Attribute from Parent Class
        Console.WriteLine("Parent Attribute: " + obj.parentAttribute);

        // Access Attribute from Child Class
        Console.WriteLine("Child Attribute: " + obj.childAttribute);
    }
}

