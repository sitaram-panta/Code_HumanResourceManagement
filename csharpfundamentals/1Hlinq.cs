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
byte[] numbers = { 23, 45, 11, 21, 33, 12, 90, 98, 87, 65, 55, 99, 234, 76, 10, 82 };
// Find squares of all numbers which are greater than 70
// Find square root of all numbers which are multiple of 3

// var squares = from a in numbers where a>70 select a * a;
// foreach (var item in squares)
// {
//     System.Console.WriteLine(item);
// }

// var squares = numbers.Where(x => x > 70).Select(y => y * y);  //using Lambda expression
// foreach (var item in squares)
// {
//  System.Console.WriteLine(item);   
// }

// var square_root = numbers.Where(x => x % 3 == 0).Select(y => Math.Sqrt(y));
// foreach (var item in square_root)
// }
//     System.Console.WriteLine(item);
// }

//check if any of the number is multiple of 7 on  numbers;
var multipleOf7 = numbers.Any(x => x % 7 == 0); //it returns boolean i.e true or false


//check if all of the numbers in numbers are multiple of 7
multipleOf7 = numbers.All(x => x % 7 == 0); // it also returns boolean 
 
// print first five of numbers in numbers

var first5 = numbers.Take(5);

//skip first five and get next five
var num = numbers.Skip(5).Take(5);


