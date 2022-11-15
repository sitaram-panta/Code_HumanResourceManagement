
// Console.WriteLine(employee_Name+ "," +age+ "," +weight+ "," +passport);
// Console.WriteLine("{0},{1},{2},{3},{4}",employee_Name,age,weight,passport,dt);
// Console.WriteLine("Hello, World!");
// DateTime x = DateTime.Now;
// Console.WriteLine(x);

// 1. Create 5 variables: first holds employee name, second his age, third his weight in kg, 4th represents if he has passport or not, 5th his date of birth.

// 1. Print values of all varialbes created in 1. in console

string employee_Name = "sitaram Panta";
byte age =  27;
string weight = "60kg";
bool passport = true;
DateTime dateOfBirth = new DateTime(2052, 10, 23);
Console.WriteLine(employee_Name);
Console.WriteLine(age);
Console.WriteLine(weight);
Console.WriteLine(passport);
Console.WriteLine(dateOfBirth);

// object created


// if marks is less than 40, print "you failed"
// if marks is less than 60 and greater than 40, print"you passed with second division"
// if marks is less than 80 and greater than 60, print"you passed with first division"
// if marks is greater than 80, print "you passed with distinction"

 int marks = 45;

if(marks < 40)
{
    Console.WriteLine("you failed");

}
else if (marks < 60)
{
    Console.WriteLine("you passed with second division");
}

else if (marks < 80)
{
    Console.WriteLine("you passed with first division");
}
else
{
    Console.WriteLine("you passed with distinction");
}
// converting numbers into roman equivalent via if else condition through asking a input with the user

Console.WriteLine("Enter a number up to  five");
var num = Console.ReadLine();
var  n = int.Parse(num);
if(n == 1)
{
    Console.WriteLine("I");
}
 else if (n == 2)
 {
    Console.WriteLine("II");

 }
else if (n == 3)
 {
    Console.WriteLine("III");

 }

else if (n == 4)
 {
    Console.WriteLine("IV");

 }
else if (n == 5)
 {
    Console.WriteLine("v");

 }

// get a number from a user and do following :
// 1. If number is divisible by 2,  print "its even number"
// 2. If number is divisible by 3, print "Its multiple of 3"
// 3. If number is divisible by 3 and 5, print "its multiple of 3 and 5"


