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


byte[] values = { 45, 56, 83, 86, 57, 54 };
var squares = values.Select(x => x * x);
System.Console.WriteLine("printing squares");
foreach (var item in squares)
{
    System.Console.WriteLine(item);

    
}