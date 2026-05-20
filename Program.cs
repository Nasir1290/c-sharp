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
        //  string? name;
        //  int age;
        //  double gpa;
        //  bool isRegistered;

        //  Console.Write("Enter your name: ");
        //  name=Console.ReadLine();

        //  Console.Write("Enter your age: ");
        //  age=Convert.ToInt32(Console.ReadLine());

        //  Console.Write("Enter you GPA: ");
        //  gpa=Convert.ToDouble(Console.ReadLine());

        //  Console.Write("Are you registered? (true/false): ");
        //  isRegistered=Convert.ToBoolean(Console.ReadLine());

        //  Console.WriteLine($"Hey {name}, you are {age} years old. Your GPA is {gpa} and your registration status is {isRegistered}.");
        // Console.WriteLine("Hello World"+ " Welcome to me to c# language");


        // Farenheit to Celsius
        // double fahrenheit,celcius;
        // Console.Write("Enter temperature in fahrenheit: ");
        // fahrenheit=Convert.ToDouble(Console.ReadLine());
        // celcius=(fahrenheit-32)*5/9;
        // Console.WriteLine($"Temperature in celcius is: {celcius:F2}");

        // ^ operator
        // int result = 15 ^ 12;
        // Console.WriteLine($"Result of 15 ^ 12 is: {result}");



        // // if else statement
        // int number = 5;
        // if (number > 0)
        // {
        //     Console.WriteLine("The number is positive.");
        // }
        // else if (number < 0)
        // {
        //     Console.WriteLine("The number is negative.");
        // }
        // else
        // {
        //     Console.WriteLine("The number is zero.");
        // }

        // leap year

        // int year;
        // Console.Write("Enter a year: ");
        // year=Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine((year%400==0 || (year%4==0 && year%100!=0))?$"{year} is a Leap Year":$"{year} is Not a Leap Year");

        // check vowel or consonent

        // Console.Write("Enter a single charecter : ");
        // char input = Convert.ToChar(Console.ReadLine());
        // switch (char.ToLower(input))
        // {
        //     case 'a':
        //     case 'e':
        //     case 'i':
        //     case 'o':
        //     case 'u':
        //         Console.WriteLine($"{input} is a vowel");
        //         break;
        //     default:
        //         if (char.IsLetter(input))
        //         {
        //             Console.WriteLine($"{input} is a consonent");
        //         }
        //         else
        //         {
        //             Console.WriteLine($"{input} is not a charecter!");
        //         }
        //         break;
        // }


        // short hand switch statement
        int num=4;

        string message= num switch
        {
           1=>"One",
           2=>"Two",
           3=>"Three",
           _=>"Number is not between 1 and 3" 
        };

        Console.WriteLine(message);

    }
}