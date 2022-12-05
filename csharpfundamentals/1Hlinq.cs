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

var squares = from x in numbers where x > 70 select x * x;
foreach (var item in squares)
{
 System.Console.WriteLine(item);   
}

var square_root = from x in numbers where x % 3 == 0 select Math.Sqrt(x);
foreach (var item in square_root)
{
    System.Console.WriteLine(item);
}

