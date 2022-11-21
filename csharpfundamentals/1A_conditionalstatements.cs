
using System;

class Conditional_Statement
{
    public void ifelse()
    {

        int marks = 45;

        if (marks < 40)
        {
            Console.WriteLine("you failed");

        }
        else if (marks < 60)
        {
            Console.WriteLine("you passed with second division");
        }

    }
}

//             / // // if marks is less than 40, print "you failed"
// // // // if marks is less than 60 and greater than 40, print"you passed with second division"
// // // // if marks is less than 80 and greater than 60, print"you passed with first division"
// // // // if marks is greater than 80, print "you passed with distinction"

//         // // else if (marks < 80)
//         // // {
//         // //     Console.WriteLine("you passed with first division");
//         // // }
//         // // else
//         // // {
//         // //     Console.WriteLine("you passed with distinction");
//         // // }
//         // // // converting numbers into roman equivalent via if else condition through asking a input with the user

//         // // Console.WriteLine("Enter a number up to  five");
//         // // var num = Console.ReadLine();
//         // // var  n = int.Parse(num);
//         // // if(n == 1)
//         // // {
//         // //     Console.WriteLine("I");
//         // // }
//         // //  else if (n == 2)
//         // //  {
//         // //     Console.WriteLine("II");

//         // //  }
//         // // else if (n == 3)
//         // //  {
//         // //     Console.WriteLine("III");

//         // //  }

//         // // else if (n == 4)
//         // //  {
//         // //     Console.WriteLine("IV");

//         // //  }
//         // // else if (n == 5)
//         // //  {
//         // //     Console.WriteLine("v");

//         // //  }

//         // // // get a number from a user and do following :
//         // // // 1. If number is divisible by 2,  print "its even number"
//         // // // 2. If number is divisible by 3, print "Its multiple of 3"
//         // // // 3. If number is divisible by 3 and 5, print "its multiple of 3 and 5


//         // for (int i = 2; i <= 100; i= i +  2)
//         // {
//         // Console.Write(i + " ");

//         // }


//         // // Console.Write("Enter a Name:");
//         // // var name = Console.ReadLine();
//         // // var name1 = name.ToLower();
//         // // Console.WriteLine(name1);



//         // // for (int i = 0; i <= 100; i++)
//         // // {
//         // //     System.Console.WriteLine(i);
//         // // }

//         // // int i = 1; 
//         // // while (i <= 100)
//         // // {
//         // //     Console.Write("jhare" + " ");
//         // //     i++;


//         // // }

//         // // Console.WriteLine("Enter a number");
//         // // var num = Console.ReadLine();

//         // int a = 10;
//         // int b = 20;
//         // int c = 30; 

//         //  if (a >100)
//         //  {
//         //     Console.WriteLine("work hard");
//         //  }

//         // else if(b > 50)

//         // {
//         // System.Console.WriteLine("not found");


//         // }

//         // else if(c<40)
//         // {

//         //     System.Console.WriteLine("got it");
//         // }

//         // else
//         // {
//         // Console.WriteLine("get lost");


//         // if (number % 2 == 0)
//         // {
//         //     // Even
//         //     Console.WriteLine(number + " is even");
//         // }
//         // else
//         // {
//         //     // Odd
//         //     Console.WriteLine(number + " is odd");
//         // }
//         // // if (number % 2 == 0)
//         // // {
//         // //     // Even
//         // //     Console.WriteLine(number + " is even");
//         // // }
//         // // else
//         // // {
//         // //     // Odd
//         // //     Console.WriteLine(number + " is odd");
//         // // }

//         // // Classwork: Ask user to enter his name and convert that to uppercase and 
//         // // print on console.
//         // // // Classwork: Ask user to enter his name and convert that to uppercase and 
//         // // // print on console.

//         // int mark = 45;
//         // // int mark = 45;

//         // // If marks is less than 40, print "You failed"
//         // // If marks is less than 60 and greater than 40, print "You Passed with second division"
//         // // If marks is less than 80 and greater than 60, print "You Passed with first division"
//         // // If marks is greater than 80, print "You Passed with distiction"
//         // // // If marks is less than 40, print "You failed"
//         // // // If marks is less than 60 and greater than 40, print "You Passed with second division"
//         // // // If marks is less than 80 and greater than 60, print "You Passed with first division"
//         // // // If marks is greater than 80, print "You Passed with distiction"

//         // if (mark < 40)
//         // {
//         //     Console.WriteLine("You failed");
//         // }
//         // else if (mark < 60)
//         // {
//         //     Console.WriteLine("You Passed with second division");
//         // }
//         // else if (mark < 80)
//         // {
//         //     Console.WriteLine("You Passed with first division");
//         // }
//         // else
//         // {
//         //     Console.WriteLine("You Passed with distiction");
//         // }
//         // // if (mark < 40)
//         // // {
//         // //     Console.WriteLine("You failed");
//         // // }
//         // // else if (mark < 60)
//         // // {
//         // //     Console.WriteLine("You Passed with second division");
//         // // }
//         // // else if (mark < 80)
//         // // {
//         // //     Console.WriteLine("You Passed with first division");
//         // // }
//         // // else
//         // // {
//         // //     Console.WriteLine("You Passed with distiction");
//         // // }

//         // // Print corresponding roman equivalents for numbers upto 5
//         // // 1 => I
//         // // 2 => II
//         // // 3 => III
//         // // 4 => IV
//         // // 5 => V
//         // // // Print corresponding roman equivalents for numbers upto 5
//         // // // 1 => I
//         // // // 2 => II
//         // // // 3 => III
//         // // // 4 => IV
//         // // // 5 => V

//         // var z = Console.ReadLine();
//         // var n = int.Parse(z);
//         // var result = "";
//         // // var z = Console.ReadLine();
//         // // var n = int.Parse(z);
//         // // var result = "";

//         // if (n is 1)
//         // {
//         //     result = "I";
//         // }
//         // else if (n is 2)
//         // {
//         //     result = "II";
//         // }
//         // else if (n is 3)
//         // {
//         //     result = "III";
//         // }
//         // else if (n is 4)
//         // {
//         //     result = "IV";
//         // }
//         // else if (n is 5)
//         // {
//         //     result = "V";
//         // }
//         // // if (n is 1)
//         // // {
//         // //     result = "I";
//         // // }
//         // // else if (n is 2)
//         // // {
//         // //     result = "II";
//         // // }
//         // // else if (n is 3)
//         // // {
//         // //     result = "III";
//         // // }
//         // // else if (n is 4)
//         // // {
//         // //     result = "IV";
//         // // }
//         // // else if (n is 5)
//         // // {
//         // //     result = "V";
//         // // }

//         // Console.WriteLine(result);
//         // // Console.WriteLine(result);

//         // // Switch
//         // switch(n)
//         // // // Switch
//         // // switch (n)
//         // // {
//         // //     case 1:
//         // //         result = "I";
//         // //         break;
//         // //     case 2:
//         // //         result = "II";
//         // //         break;
//         // //     case 3:
//         // //         result = "III";
//         // //         break;
//         // //     case 4:
//         // //         result = "IV";
//         // //         break;
//         // //     case 5:
//         // //         result = "V";
//         // //         break;
//         // // }

//         // // Console.WriteLine(result);


//         // // //Question 4
//         // // Console.Write("Enter a number: ");
//         // // var num = Convert.ToInt16(Console.ReadLine());

//         // // if (num % 2 != 0 && num % 3 != 0 && num % 5 != 0)
//         // // {
//         // //     Console.WriteLine("Not divisible by 2, 3 and 5");
//         // // }
//         // // else
//         // // {
//         // //     if (num % 2 == 0)
//         // //     {
//         // //         Console.WriteLine("It's even number");
//         // //     }

//         // //     if (num % 3 == 0)
//         // //     {
//         // //         Console.WriteLine("It's multiple of 3 ");
//         // //         if (num % 5 == 0)
//         // //         {
//         // //             Console.WriteLine("It's multiple of 5");
//         // //         }
//         // //     }
//         // // }


//  }











// }