using System;
class Test
{
    public static void Main(string[] args)
    {
    //    assign multiple variables and their value in a single line
    // int a,b,c;
    // a=b=c=10;

    // a=20;
    // Console.WriteLine(a);
    // Console.WriteLine(b);
    // Console.WriteLine(c);

    // typecasting
    // int salary=(int)(20000.89);
    // Console.WriteLine(salary);
    
    // int salary=80;
    // double newSalary=salary;
    // Console.WriteLine(newSalary);

    // implicit/automatic conversion
    // we can't convert from higher data type to lower data type. say example double to int. but we can convert from lower to higher data type. say example int to double.
    // lower to higher automatic conversion
    // int a=2;
    // double b=a;
    // Console.WriteLine(a);

    // higher to lower explicit conversion
    // double a=589825.89;
    // int b=(int)a;
    // Console.WriteLine(b);

    // also we can use Convert class to convert from one data type to another data type
    // double a = 32433.34;
    // int b=Convert.ToInt32(a);
    // Console.WriteLine(b);


    // Parse vs TryParse
    // string input = "12.12";
    // int result;
    // bool isSuccess = int.TryParse(input, out result);
    // if (isSuccess)
    // {
    //     Console.WriteLine(isSuccess);
    //     Console.WriteLine("Conversion successful. Result: " + result);
    // }
    // else
    // {
    //     Console.WriteLine(isSuccess);
    //     Console.WriteLine("Conversion failed. Invalid input.");

    // }


    // How to take input from user and convert it.
     string? name;
     int age;
     double gpa;
     bool isRegistered;

     Console.Write("Enter your name: ");
     name=Console.ReadLine();

     Console.Write("Enter your age: ");
     age=Convert.ToInt32(Console.ReadLine());

     Console.Write("Enter you GPA: ");
     gpa=Convert.ToDouble(Console.ReadLine());

     Console.Write("Are you registered? (true/false): ");
     isRegistered=Convert.ToBoolean(Console.ReadLine());
     if(isRegistered!=true || isRegistered != false)
        {
         Console.Write("Invalid input for registration status. Please enter 'true' or 'false'.");
         isRegistered=Convert.ToBoolean(Console.ReadLine()); 
        }

     Console.WriteLine($"Hey {name}, you are {age} years old. Your GPA is {gpa} and your registration status is {isRegistered}.");

    }
}