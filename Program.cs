using System;
using System.Linq;
using System.Collections.Generic;


// See https://aka.ms/new-console-template for more information
Console.Write("Good Morning And ");
Console.WriteLine("Hello, World!");

// Console.write is for console in the same row as the console.writeline item
Console.Write("Hey! ");
Console.WriteLine("Wibi Hanif Wibowo");

// add new line with \n
Console.WriteLine("Wibi\nHanif Wibowo");

// This is a comment
/*
This is a multi-line comment.
You can write as many lines as you want in between.
It will be ignored by the compiler.
*/

// VARIABLE
// its all non constants variable so its mutable variables

// store bilangan bulat
int y = 321;
int x = 111;
Console.WriteLine(x + y);

// store decimal number
double height = 300.5;
// store bilangan bulat
int age = 25;
// store string type
String name = "Wibi Hanif Wibowo";
// store boolean type
bool isAlive = true;

// proof that is mutable variabele
age = 26;
name = "Wita Hanifa Widiya";
height = 150.6;
isAlive = false;

Console.WriteLine("Hello my name is " + name);
Console.WriteLine("I am " + age + " years old");
Console.WriteLine("My height is " + height + " cm");
Console.WriteLine("Do i still alive? " + isAlive);

// constant variable or immutable variable
const String college = "Universitas Indonesia";
Console.WriteLine("I study at " + college);

// TYPE CASTING
double pi = 3.14;
Console.WriteLine(pi);
Console.WriteLine(pi.GetType());

int roundedPi = Convert.ToInt32(pi);
Console.WriteLine(roundedPi);
Console.WriteLine(roundedPi.GetType());

int roundedArea = 34;

// fact that if double type in can be added by decimal value
double area = Convert.ToDouble(roundedArea) + 0.1;
Console.WriteLine(area);
Console.WriteLine(area.GetType());

int perimeter = 321;
String parsedPerimeter = Convert.ToString(perimeter);
Console.WriteLine(parsedPerimeter);
Console.WriteLine(parsedPerimeter.GetType());

String symbol = "&";
char parsedSymbol = Convert.ToChar(symbol);
Console.WriteLine(parsedSymbol);
Console.WriteLine(parsedSymbol.GetType());

String isReadyString = "true";
bool isReady = Convert.ToBoolean(isReadyString);
Console.WriteLine(isReady);
Console.WriteLine(isReady.GetType());

// USER INPUT
// Console.WriteLine("Hello, What's your name?");
// Readline method always reproduce string type
// String nickName = Console.ReadLine();

// Console.WriteLine("How much is your money? ");
// int amount = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("My name is " + nickName + " and i have " + "Rp." + amount);

// OPERATOR
int friends = 5;
double parsedFriends = Convert.ToDouble(friends);

// add
// friends = friends + 1;
// Console.WriteLine(friends);
// friends++;
// Console.WriteLine(friends);
// friends += 1;
// Console.WriteLine(friends);

// min
// friends = friends - 1;
// Console.WriteLine(friends);
// friends--;
// Console.WriteLine(friends);
// friends -= 1;
// Console.WriteLine(friends);

// multiple
// friends = friends * 2;
// Console.WriteLine(friends);
// friends *= 2;
// Console.WriteLine(friends);

// divide
// friends = friends / 2;
// friends /= 2;
// the result is 2 becuase is an integer
// Console.WriteLine(friends + "test");

// parsedFriends = parsedFriends / 2;
// parsedFriends /= 2;
// Console.WriteLine(parsedFriends);

// modulus 
// int remainder = friends % 5;
// Console.WriteLine(remainder);

// MATH CLASS
double amount = 4.11;
double amountComparison = 5;

// pangkat dua
double powAmount = Math.Pow(amount, 2);

// akar dua
double squaredAmount = Math.Sqrt(amount);

// angka absolut
double absAmount = Math.Abs(amount);

// pembulatan absolut
double roundAmount = Math.Round(amount);

// pembulatan ke atas
double ceilAmount = Math.Ceiling(amount);

// pembulatan ke bawah
double floorAmount = Math.Floor(amount);

// compare two number wether max or min number
double maxAmount = Math.Max(amount, amountComparison);
double minAmount = Math.Min(amount, amountComparison);

Console.WriteLine(powAmount);
Console.WriteLine(squaredAmount);
Console.WriteLine(absAmount);
Console.WriteLine(roundAmount);
Console.WriteLine(ceilAmount);
Console.WriteLine(floorAmount);
Console.WriteLine(maxAmount);
Console.WriteLine(minAmount);

// RANDOM OBJECT
Random random = new Random();

// imagine this is a dice we need to random
// 1 to 6 number 1 is inklusif and 7 is ekslusif
int randomNumber = random.Next(1, 7);
Console.WriteLine(randomNumber);
double randomDecimal = random.NextDouble();
Console.WriteLine(randomDecimal);

// HYPETENUSE CASE
// Console.WriteLine("please insert for side A: ");
// double sideA = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Please insert side B: ");
// double sideB = Convert.ToDouble(Console.ReadLine());

// double hypotenuse = Math.Sqrt((Math.Pow(sideA, 2) + Math.Pow(sideB, 2)));
// Console.WriteLine(hypotenuse);

// STRING METHODS
String fullName = "Wibi Hanif Wibowo";
// upper case
String fullNameUpperCased = fullName.ToUpper();
// replace
String fullNameReplaced = fullName.Replace(" ", "");
// insert character in index
String fullNameInserted = fullName.Insert(0, "Mr. ");
// substring: take some character from srting, second parameter is ekslusif
String fullNameSubStr = fullName.Substring(0, 4);
// split strings
String splitedFullName = fullName.Split(" ")[0];

Console.WriteLine(fullName);
Console.WriteLine(fullNameUpperCased);
Console.WriteLine(fullNameReplaced);
Console.WriteLine(fullNameInserted);
Console.WriteLine(fullNameSubStr);
Console.WriteLine(splitedFullName);

// IF STATEMENT
// Console.WriteLine("How many bank accounts do you have? ");
// int bankAccountNumber = Convert.ToInt32(Console.ReadLine());

// if (bankAccountNumber > 3)
// {
//     Console.WriteLine("You are aligible to do the transaction");
// }
// else
// {
//     Console.WriteLine("You are not eligible to do the transaction");
// }

// FizzBuzz with c#
// Console.WriteLine("Please input any number! We want is it fizz buzz or the number itself");
// int insertedNumber = Convert.ToInt32(Console.ReadLine());

// if (insertedNumber % 3 == 0 && insertedNumber % 5 == 0)
// {
//     Console.WriteLine("FizzBuzz");
// }
// else if (insertedNumber % 5 == 0)
// {
//     Console.WriteLine("Buzz");
// }
// else if (insertedNumber % 3 == 0)
// {
//     Console.WriteLine("Fizz");
// }
// else
// {
//     Console.WriteLine(insertedNumber);
// }

// SWITCH CASE
// Console.WriteLine("What is your mother's name? ");
// string motherName = Console.ReadLine();

// switch (motherName)
// {
//     case "":
//         Console.WriteLine("Mother's name is empty.");
//         break;
//     default:
//         Console.WriteLine("Mother's name is " + motherName);
//         break;
// }

// WHILE LOOP
// String day = "";
// while (day == "")
// {
//     Console.WriteLine("What day is it today? ");
//     day = Console.ReadLine();
// }

// switch (day.ToLower())
// {
//     case "monday":
//         Console.WriteLine("Today is " + day);
//         break;
//     case "tuesday":
//         Console.WriteLine("Today is " + day);
//         break;
//     case "wednesday":
//         Console.WriteLine("Today is " + day);
//         break;
//     case "thursday":
//         Console.WriteLine("Today is " + day);
//         break;
//     case "friday":
//         Console.WriteLine("Today is " + day);
//         break;
//     case "saturday":
//         Console.WriteLine("Today is " + day);
//         break;
//     case "sunday":
//         Console.WriteLine("Today is " + day);
//         break;
//     default:
//         Console.WriteLine("Invalid input day");
//         break;
// }

// int i = 1;
// Console.WriteLine("How many this loop would be proceed? ");
// int loopNumber = Convert.ToInt32(Console.ReadLine());

// while (i <= loopNumber)
// {
//     Console.WriteLine("This text will show by total of " + loopNumber);
//     i++;
// }

// FOR LOOP
// for (int i = 1; i <= 10; i++)
// {
//     Console.WriteLine("this will countup " + i);
// }

// for (int i = 10; i >= 1; i--)
// {
//     Console.WriteLine("this will countdown " + i);
// }
// Console.WriteLine("Happy new year");

// NESTED LOOP
// there are two arrays, find the same number of that two array
// and remove the duplicate value and return array value

// int[] myNum1 = { 1, 2, 3, 4, 4, 6, 7, 9, 3 };
// int[] myNum2 = { 2, 2, 3, 4, 4, 3 };

// List<int> groupedSameNum = new List<int>();

// for (int i = 0; i < myNum1.Length; i++)
// {
//     for (int j = 0; j < myNum2.Length; j++)
//     {
//         if (myNum1[i] == myNum2[j])
//         {
//             groupedSameNum.Add(myNum1[i]);
//         }
//     }
// }

// int[] arrayResultNum = groupedSameNum.Distinct().ToList().ToArray();

// Console.Write("How many columns do you want? ");
// int columns = Convert.ToInt32(Console.ReadLine());

// Console.Write("How many row do you want? ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("What symbol do you want to print? ");
// String printedSymbol = Console.ReadLine();

// for (int i = 1; i <= rows; i++)
// {
//     for (int j = 1; j <= columns; j++)
//     {
//         Console.Write(printedSymbol);
//     }
//     Console.WriteLine();
// }

// GUESSING GAME
// kalo udah ketebak mau play again atau engga
// kalo salah dipaksa untuk nebak terus sampe ketebak
// bool playAgain = true;
// Random randomized = new Random();
// int initialNumber = 1;
// int finalNumber = 100;
// int randomizedNumber = randomized.Next(initialNumber, finalNumber + 1);
// int guess = 0;
// int guesses = 0;
// while (playAgain)
// {
//     while (guess != randomizedNumber)
//     {
//         Console.WriteLine("Please guess the number between " + initialNumber + " and " + finalNumber);
//         guess = Convert.ToInt32(Console.ReadLine());

//         if (guess > randomizedNumber)
//         {
//             Console.WriteLine("Number is too high");
//         }
//         else if (guess < randomizedNumber)
//         {
//             Console.WriteLine("Number is too low");
//         }
//         else
//         {
//             Console.WriteLine("correct");
//         }

//         guesses++;
//     }

//     randomizedNumber = randomized.Next(initialNumber, finalNumber + 1);
//     guess = 0;
//     Console.WriteLine("total guesses: " + guesses);
//     Console.WriteLine("Do you want to play again? (Y/N)");
//     String playAgainResponse = Console.ReadLine();
//     playAgainResponse = playAgainResponse.ToUpper();

//     if (playAgainResponse == "Y")
//     {
//         playAgain = true;
//     }
//     else
//     {
//         playAgain = false;
//     }
// }

// CALCULATOR
// double firstNumber;
// double secondNumber;
// double result = 0;
// bool isCalculateAgain = true;
// String answer = "";

// Console.WriteLine("Pick the first number: ");
// firstNumber = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Pick the second number: ");
// secondNumber = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Choose Operator Option: ");
// Console.WriteLine(" + (add)\n - (minus)\n * (times)\n / (divide)\n");
// String operatorSymbol = Console.ReadLine();

// while (isCalculateAgain)
// {
//     switch (operatorSymbol)
//     {
//         case "+":
//             result = firstNumber + secondNumber;
//             break;
//         case "-":
//             result = firstNumber - secondNumber;
//             break;
//         case "*":
//             result = firstNumber * secondNumber;
//             break;
//         case "/":
//             result = firstNumber / secondNumber;
//             break;
//         default:
//             Console.WriteLine("operator that have been inputted is wrong");
//             isCalculateAgain = false;
//             break;
//     }
//     Console.WriteLine("the result is: " + result);

//     Console.WriteLine("would you like to calculate again? (Y/N)");
//     answer = Console.ReadLine().ToUpper();

//     if (answer == "Y")
//     {
//         isCalculateAgain = true;
//     }
//     else if (answer == "N")
//     {
//         isCalculateAgain = false;
//     }
// }

// ARRAY
String[] cars = { "BMW", "TOYOTA", "HONDA" };

// List<Car> carObjects = new List<Car>();

// foreach (string car in cars)
// {
//     string color = getColorForBrand(car);

//     carObjects.Add(new Car { Brand = car, Color = color });
// }

// // we can make array object like this
// foreach (var car in carObjects)
// {
//     Console.WriteLine($"{{ brand: {car.Brand}, color: {car.Color} }}");
// }

// static string getColorForBrand(string brand)
// {
//     switch (brand.ToLower())
//     {
//         case "bmw":
//             return "Red";
//         case "toyota":
//             return "Blue";
//         case "honda":
//             return "Green";
//         default:
//             return "Unknown";
//     }
// }


// create function to generate array of objects

// define class for the object
// define function for define color
// define function to generate the array of object 

// Car[] brandDetails = GenerateBrandDetail(cars);

// static Car[] GenerateBrandDetail(string[] cars)
// {
//     List<Car> carObjects = new List<Car>();

//     foreach (var car in cars)
//     {
//         String definedColor = DefineBrandColor(car);
//         carObjects.Add(new Car { Brand = car, Color = definedColor });
//     }

//     return carObjects.ToArray();
// }

// static string DefineBrandColor(string brand)
// {
//     switch (brand.ToLower())
//     {
//         case "bmw":
//             return "blue";
//         case "toyota":
//             return "green";
//         case "honda":
//             return "red";
//         default:
//             return "unknown";
//     }
// }


// METHODS
// singHappyBirthday(12, "Wibi");

// static void singHappyBirthday(int n, String name)
// {
//     for (int i = 1; i <= n; i++)
//     {
//         Console.WriteLine("Happy Birthday to you " + name + " " + i);
//     }
// }

// double multipliedNum = multiplyNumber(3, 2);

// Console.WriteLine(multipliedNum);

// static double multiplyNumber(double num1, double num2)
// {
//     return num1 * num2;
// }

// Method Overloading
// With method overloading, multiple methods can have the same name with different parameters

int myNum1 = PlusMethodInt(8, 5);
double myNum2 = PlusMethodDouble(4.3, 6.26);

Console.WriteLine(myNum1);
Console.WriteLine(myNum2);

static int PlusMethodInt(int x, int y)
{
    return x + y;
}

static double PlusMethodDouble(double x, double y)
{
    return x + y;
}

// method params

double sumResult = PlustMethodDouble(3, 3, 3, 3);

Console.WriteLine(sumResult);

static double PlustMethodDouble(params double[] doubleNumbers)
{
    double result = 0;

    foreach (double doubleNumber in doubleNumbers)
    {
        result += doubleNumber;
    }

    return result;
}

// EXCEPTION HANDLING
// catch type maybe different based on its case
// but if we dont know what shoul be catch we can use just "EXCEPTION"
// finally is used to show anything
// try
// {

//     Console.WriteLine("Enter Number 1: ");
//     double number1 = Convert.ToDouble(Console.ReadLine());

//     Console.WriteLine("Enter Number 2: ");
//     double number2 = Convert.ToDouble(Console.ReadLine());

//     double dividedResult = number1 / number2;
//     Console.WriteLine("The result is: " + dividedResult);
// }
// catch (FormatException e)
// {
//     Console.WriteLine("Invalid input");
//     Console.WriteLine(e);
// }
// catch (DivideByZeroException e)
// {
//     Console.WriteLine("divider cannot be zero");
//     Console.WriteLine(e);
// }
// catch (Exception e)
// {
//     Console.WriteLine("Something went wrong");
//     Console.WriteLine(e);
// }
// finally
// {
//     Console.WriteLine("Thanks for visiting");
// }

// CONDITIONAL OPERATOR
// Console.WriteLine(DefineColdness(52));
// static string DefineColdness(double temp)
// {
//     return temp > 30 ? "Its hot" : "Its cold";
// }

// Console.WriteLine(DefineDetailColdness(25));
// static string DefineDetailColdness(double temp)
// {
//     return temp > 30 ? "Its hot" : temp > 20 && temp <= 30 ? "Its warm" : "Its cold";
// }

// STRING INTERPOLATION
// Console.WriteLine(InterpolateString(23, "Wibi", "Hanif Wibowo"));

// static string InterpolateString(int age, string firstName, string lastName)
// {
//     return $"Hello my name is {firstName} {lastName} and im {age} years old";
// }

// MULTIDIMENSIONAL ARRAY

// String[,] parkingLot = {
//     { "Mustang", "F-150", "Explorer" },
//     { "Corvette", "Camaro", "Silverado" },
//     { "Corolla", "Camry", "Rav4" }
//     };

// // change array value, index ke 0 lalu masuk ke index kedua array index 0 tsb
// parkingLot[0, 2] = "Fusion";
// parkingLot[2, 0] = "Tacoma";

// // foreach (string car in parkingLot)
// // {
// //     Console.WriteLine(car);
// // }

// for (int i = 0; i < parkingLot.GetLength(0); i++)
// {
//     for (int j = 0; j < parkingLot.GetLength(1); j++)
//     {
//         Console.Write(parkingLot[i, j] + " ");
//     }
//     Console.WriteLine();
// }



// CLASS
// Class should be public so it can be accessed
// Car car1 = new Car();

// Console.WriteLine(car1.color);
// Console.WriteLine(car1.totalTier);

// Handphone handphone1 = new Handphone();
// Console.WriteLine(handphone1.brand + " " + handphone1.pulse);

String helloMessage = Message.Hello();
String waitingMessage = Message.Waiting();
String byeMessage = Message.Bye();

Console.WriteLine(helloMessage);
Console.WriteLine(waitingMessage);
Console.WriteLine(byeMessage);

Human human1 = new Human();
human1.name = "andri";
human1.age = 30;
String human1Eat = human1.Eat();
String human1Sleep = human1.Sleep();

Console.WriteLine(human1Eat);
Console.WriteLine(human1Sleep);
























