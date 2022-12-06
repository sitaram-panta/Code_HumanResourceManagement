// LINQ - Language Integrated Query
// powerful feature to query collection

// byte[] numbers = {23, 34, 38, 89, 78, 49, 83 , 93};
// var oddNumbers = numbers.Where(number => number % 2 !=0);
// foreach (var item in oddNumbers)
// {
//     System.Console.WriteLine(item);
// }


// byte[] numbers1 = {23, 34, 38, 89, 78, 49, 83 , 93};
// var output =numbers1.Where(number => number<50);
// foreach (var item in output)
// {
//     System.Console.WriteLine(item);

// }

// byte[] values = { 23, 45, 78, 89, 98, 98, 89 };
// var result = values.Where(number => number < 50 && number % 2 == 1);
// foreach (var item in result)
// {
//     System.Console.WriteLine(item);


// }



// string[] names = { "sita", "Ram", "Hari", "shyam", "Mohan" };
// var output = names.Where(Y => Y.StartsWith("s"));
// foreach (var item in output)
// {
//     System.Console.WriteLine(item);
// }


// byte[] values = { 45, 56, 83, 86, 57, 54 };
// var squares = values.Select(x => x * x);
// System.Console.WriteLine("printing squares");
// foreach (var item in squares)
// {
//     System.Console.WriteLine(item);


// }

// We have following array:
using LivingThings;

// byte[] numbers = { 23, 45, 11, 21, 33, 12, 90, 98, 87, 65, 55, 99, 234, 76, 10, 82 };
// // Find squares of all numbers which are greater than 70
// // Find square root of all numbers which are multiple of 3

// // var squares = from a in numbers where a>70 select a * a;
// // foreach (var item in squares)
// {
//     System.Console.WriteLine(item);
// }

// var squares = from x in numbers where x > 70 select x * x;
// foreach (var item in squares)
// {
//  System.Console.WriteLine(item);   
// }
//     var square_root = numbers.Where(x => x % 3 == 0).Select(y => Math.Sqrt(y));
// // var square_root = from x in numbers where x % 3 == 0 select Math.Sqrt(x);
// foreach (var item in square_root)
// {
//     System.Console.WriteLine(item);
// }

//Sqaures of numbers > 70

// Method syntax
// var squaresGreater70 = numbers.Where(x => x > 70).Select(z => z * z);

// // Expression syntax
// squaresGreater70 = from x in numbers
//                    where x > 70
//                    select x * x;

// //Square root of all numbers which are multiple of 3

// // MS
// var srofnm3 = numbers.Where(x => x % 3 == 0).Select(y => Math.Sqrt(y));

// //ES
// srofnm3 = from x in numbers
//           where x % 3 == 0
//           select Math.Sqrt(x);

// // Check if ANY of the number is multiple of 7 on "numbers"
// var multipleOf7 = numbers.Any(x => x % 7 == 0);

// // Check if ALL the numbers in "numbers" are multiple of 7
// var allMultipleOf7 = numbers.All(x => x % 7 == 0);

// // Get first 5 items in numbers
// var first5 = numbers.Take(5);

// // Skip first 2 and get next 5
// var skip2AndGetNext5 = numbers.Skip(2).Take(5);

// Person p1 = new Person();
// p1.age = 23;

// Person p2 = new Person();
// p2.age = 32;

// Person p3 = new Person();
// p3.age = 33;

// Person p4 = new Person();
// p4.age = 20;

// Person p5 = new Person();
// p5.age = 26;

// Person p6 = new Person();
// p6.age = 12;

// Person[] people = { p1, p2, p3, p4, p5, p6 };

// Get all people who are adult now
//     var adults = people.Where(x => x.age > 18);
// }

// void PrintOutput<T>(IEnumerable<T> items, string displayText)
// {
//     Console.WriteLine($"Printing {displayText}");
//     foreach (var item in items)
//     {
//         Console.WriteLine(item);
//     }
// }


// . Create list/array of animals using `Animal` class we wrote.
//     1. Query that collection to find following:
//         1. Get list of all domestic animals
//         1. Get list of animals which has more than 4 legs 


Animal x = new Animal();
x.domestic = true;
x.numberOfLegs = 6;


Animal x1 = new Animal();
x1.domestic = true;
x1.numberOfLegs = 4;

Animal x2 = new Animal();
x2.domestic = false;
x2.numberOfLegs = 6;

Animal x3 = new Animal();
x3.domestic = true;
x3.numberOfLegs = 5;

Animal x4 = new Animal();
x4.domestic = false;
x4.numberOfLegs = 8;

Animal x5 = new Animal();
x5.domestic = false;
x5.numberOfLegs = 12;

Animal x6 = new Animal();
x6.domestic = true;
x6.numberOfLegs = 7;



Animal[] animal = { x, x1, x2, x3, x4, x5, x6 };

var domesticAnimal = animal.Where(x => x.domestic == true);
foreach (var item in domesticAnimal)
{
    System.Console.WriteLine(item);
}
System.Console.WriteLine(".......................");
var ahmt4l = animal.Where(x => x.numberOfLegs > 4);
foreach (var item in ahmt4l)
{
    System.Console.WriteLine(item);
}