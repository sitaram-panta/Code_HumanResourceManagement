using System;
                        // 1. Create 5 variables: first holds employee name, second his age, third his weight in kg, 4th represents if he has passport or not, 5th his date of birth.

                        // 1. Print values of all varialbes created in 1. in console

// string employee_Name = "sitaram Panta";
// byte age =  27;
// string weight = "60kg";
// bool passport = true;
// DateTime dateOfBirth = new DateTime(2052, 10, 23);
// Console.WriteLine(employee_Name);
// Console.WriteLine(age);
// Console.WriteLine(weight);
// Console.WriteLine(passport);
// Console.WriteLine(dateOfBirth);
// Console.WriteLine("{0},{1},{2},{3},{4}", employee_Name, age, weight, passport, dateOfBirth);

// // object created
    // Person person1 = new();
    // person1.name = "Sitaram";
    // person1.age = 12;

    // string message = person1.GetLegalGreeting();
    // Console.WriteLine(message);

// Create a C# class with 3 fields in it and a method. 
// Create an object from that class in Main() method and print corresponding field values.


// students student = new();
// student.section = "first, second, third, fourth, fifth, sixth, seventh";
// student.semester = 4;

// string suggestion = student.message();
// Console.WriteLine(suggestion);

// Classwork: Ask user to enter his name and convert that to uppercase and print on console

// Console.Write("Enter a Name:");
// var name = Console.ReadLine();
// var name1 = name.ToLower();
// Console.WriteLine(name1);



// for (int i = 0; i <= 100; i++)
// {
//     System.Console.WriteLine(i);
// }

// int i = 1;
// while (i <= 100)
// {
//     Console.Write("jhare" + " ");
//     i++;


// }

// Console.WriteLine("Enter a number");
// var num = Console.ReadLine();

int a = 10;
int b = 20;
int c = 30; 
 
 if (a >100)
 {
    Console.WriteLine("work hard");
 }

else if(b > 50)

{
System.Console.WriteLine("not found");


}

else if(c<40)
{

    System.Console.WriteLine("got it");
}

else
{
Console.WriteLine("get lost");


if (number % 2 == 0)
{
    // Even
    Console.WriteLine(number + " is even");
}
else
{
    // Odd
    Console.WriteLine(number + " is odd");
}
// if (number % 2 == 0)
// {
//     // Even
//     Console.WriteLine(number + " is even");
// }
// else
// {
//     // Odd
//     Console.WriteLine(number + " is odd");
// }

// Classwork: Ask user to enter his name and convert that to uppercase and 
// print on console.
// // Classwork: Ask user to enter his name and convert that to uppercase and 
// // print on console.

int mark = 45;
// int mark = 45;

// If marks is less than 40, print "You failed"
// If marks is less than 60 and greater than 40, print "You Passed with second division"
// If marks is less than 80 and greater than 60, print "You Passed with first division"
// If marks is greater than 80, print "You Passed with distiction"
// // If marks is less than 40, print "You failed"
// // If marks is less than 60 and greater than 40, print "You Passed with second division"
// // If marks is less than 80 and greater than 60, print "You Passed with first division"
// // If marks is greater than 80, print "You Passed with distiction"

if (mark < 40)
{
    Console.WriteLine("You failed");
}
else if (mark < 60)
{
    Console.WriteLine("You Passed with second division");
}
else if (mark < 80)
{
    Console.WriteLine("You Passed with first division");
}
else
{
    Console.WriteLine("You Passed with distiction");
}
// if (mark < 40)
// {
//     Console.WriteLine("You failed");
// }
// else if (mark < 60)
// {
//     Console.WriteLine("You Passed with second division");
// }
// else if (mark < 80)
// {
//     Console.WriteLine("You Passed with first division");
// }
// else
// {
//     Console.WriteLine("You Passed with distiction");
// }

// Print corresponding roman equivalents for numbers upto 5
// 1 => I
// 2 => II
// 3 => III
// 4 => IV
// 5 => V
// // Print corresponding roman equivalents for numbers upto 5
// // 1 => I
// // 2 => II
// // 3 => III
// // 4 => IV
// // 5 => V

var z = Console.ReadLine();
var n = int.Parse(z);
var result = "";
// var z = Console.ReadLine();
// var n = int.Parse(z);
// var result = "";

if (n is 1)
{
    result = "I";
}
else if (n is 2)
{
    result = "II";
}
else if (n is 3)
{
    result = "III";
}
else if (n is 4)
{
    result = "IV";
}
else if (n is 5)
{
    result = "V";
}
// if (n is 1)
// {
//     result = "I";
// }
// else if (n is 2)
// {
//     result = "II";
// }
// else if (n is 3)
// {
//     result = "III";
// }
// else if (n is 4)
// {
//     result = "IV";
// }
// else if (n is 5)
// {
//     result = "V";
// }

Console.WriteLine(result);
// Console.WriteLine(result);

// Switch
switch(n)
// // Switch
// switch (n)
// {
//     case 1:
//         result = "I";
//         break;
//     case 2:
//         result = "II";
//         break;
//     case 3:
//         result = "III";
//         break;
//     case 4:
//         result = "IV";
//         break;
//     case 5:
//         result = "V";
//         break;
// }

// Console.WriteLine(result);


// //Question 4
// Console.Write("Enter a number: ");
// var num = Convert.ToInt16(Console.ReadLine());

// if (num % 2 != 0 && num % 3 != 0 && num % 5 != 0)
// {
//     Console.WriteLine("Not divisible by 2, 3 and 5");
// }
// else
// {
//     if (num % 2 == 0)
//     {
//         Console.WriteLine("It's even number");
//     }

//     if (num % 3 == 0)
//     {
//         Console.WriteLine("It's multiple of 3 ");
//         if (num % 5 == 0)
//         {
//             Console.WriteLine("It's multiple of 5");
//         }
//     }
// }


// // Loops or iteration statements: for, foreach, while, do while

// for (int counter = 10; counter < 200; counter++)
// {
//     Console.Write(100 + " ");
// }

// Print numbers from 1-100 in console

// for (int counter = 1; counter <= 100; counter = counter + 1)
// {
//     Console.Write(counter + " ");
// }

// int counterx = 1;
// while (counterx <= 100)
// {
//     Console.Write(counterx + " ");

//     counterx = counterx + 1;
// }

// Print "Hello" until user press "y" in the console
// While and Do-while can only implement this, we can't use for loop for this solution
// char yes = 'y';
// while (yes == 'y')
// {
//     Console.WriteLine("Hello");
//     Console.Write("Print another hello?:");
//     var keyPressed = Console.ReadKey();    
//     yes = keyPressed.KeyChar;
// }


// // Print all even numbers upto 100
// for (int counter = 2; counter <= 100; counter = counter + 2)
// {
//     Console.Write(counter + " ");
// }

// for (int counter = 1; counter <= 100; counter++)
// {
//     if (counter % 2 == 0)
//     {
//         Console.Write(counter + " ");
//     }
// }

// 3X3
// 1 2 3
// 4 5 6
// 7 8 9

//
// #
// ##
// ###
// ####

// for(int i = 1; i <= 10; i++)
// {
//     case 1: result = "I";
//     break;
//     case 2: result = "II";
//     break;
//     case 3: result = "III";
//     break;
//     case 4: result = "IV";
//     break;
//     case 5: result = "V";
//     break;
// }
//     for(int j = 0; j < i; j++)
//     {
//         Console.Write(j);    
//     }

// Console.WriteLine(result);
//     Console.WriteLine();
// }

// Loops or iteration statements
// i=2, j=1

}


// 1. Print following matrix on console using nested loops:
//    
//     1 2  3  4
//     5 6  7  8
//     9 10 11 12


int row;
int col;

for (row = 1; row <= 3; row++)
{
    for(col = 1; col<=4; col++)
    {
        Console.Write("{0}, {1}" , row, col);

    }
}
    




















