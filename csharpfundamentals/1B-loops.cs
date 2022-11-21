using System;

class looping_statement
{
    public void AboutLoops()
    {
        // // // Loops or iteration statements: for, foreach, while, do while

        for (int counter = 10; counter < 200; counter++)
        {
            Console.Write(100 + " ");
        }
    }
}

//         // // Print numbers from 1-100 in console

//         // // for (int counter = 1; counter <= 100; counter = counter + 1)
//         // // {
//         // //     Console.Write(counter + " ");
//         // // }

//         // // int counter x = 1;
//         // // while (counter  x <= 100)
//         // // {
//         // //     Console.Write(counter x + " ");

//         // //     counter x = counter x + 1;
//         // // }

//         // // Print "Hello" until user press "y" in the console
//         // // While and Do-while can only implement this, we can't use for loop for this solution
//         // // char yes = 'y';
//         // // while (yes == 'y')
//         // // {
//         // //     Console.WriteLine("Hello");
//         // //     Console.Write("Print another hello?:");
//         // //     var keyPressed = Console.ReadKey();    
//         // //     yes = keyPressed.KeyChar;
//         // // }


//         // // // Print all even numbers up to 100
//         // // for (int counter = 2; counter <= 100; counter = counter + 2)
//         // // {
//         // //     Console.Write(counter + " ");
//         // // }

//         // // for (int counter = 1; counter <= 100; counter++)
//         // // {
//         // //     if (counter % 2 == 0)
//         // //     {
//         // //         Console.Write(counter + " ");
//         // //     }
//         // // }

//         // // 3X3
//         // // 1 2 3
//         // // 4 5 6
//         // // 7 8 9

//         // //
//         // // #
//         // // ##
//         // // ###
//         // // ####

//         // // for(int i = 1; i <= 10; i++)
//         // // {
//         // //     case 1: result = "I";
//         // //     break;
//         // //     case 2: result = "II";
//         // //     break;
//         // //     case 3: result = "III";
//         // //     break;
//         // //     case 4: result = "IV";
//         // //     break;
//         // //     case 5: result = "V";
//         // //     break;
//         // // }
//         // //     for(int j = 0; j < i; j++)
//         // //     {
//         // //         Console.Write(j);    
//         // //     }

//         // // Console.WriteLine(result);
//         // //     Console.WriteLine();
//         // // }

//         // // Loops or iteration statements
//         // // i=2, j=1

//         // }


//         // // 1. Print following matrix on console using nested loops:
//         // //    
//         // //     1 2  3  4
//         // //     5 6  7  8
//         // //     9 10 11 12


//         // int row;
//         // int col;

//         // for (row = 1; row <= 3; row++)
//         // {
//         //     for(col = 1; col<=4; col++)
//         //     {
//         //         Console.Write("{0}, {1}" , row, col);

//         //     }
//         // }

//         // int val = 0;
//         // for (int i = 0; i < 3; i++)
//         // {
//         //     for (int j = 0; j < 4; j++)
//         //     {
//         //         val++;
//         //         Console.Write(val + "\t");   // Escape sequences 
//         //     }

//         //     Console.WriteLine();
//         // }

//         // // Let's talk about arrays

//         // // One-dimensional array
//         // byte age1 = 23;
//         // byte age2 = 49;

//         // // 1000
//         // byte[] ages = new byte[1000];
//         // ages[0] = 34;
//         // ages[1] = 34;
//         // ages[2] = 34;
//         // ages[3] = 34;
//         // //....
//         // ages[999] = 90;

//         // var a = ages[49];

//         // // multi-dimensional
//         // int[,] table = new int[2, 3];

//         // table[0, 0] = 1;
//         // table[0, 1] = 2;
//         // table[0, 2] = 3;
//         // table[1, 0] = 4;
//         // table[1, 1] = 5;
//         // table[1, 2] = 6;

//         // for(int i = 1; i <= 10; i++)
//         // for (int i = 0; i < 2; i++)
//         // {
//         //     for(int j = 0; j < i; j++)
//         //     for (int j = 0; j < 3; j++)
//         //     {
//         //         Console.Write(j);    
//         //         Console.Write(table[i, j] + "\t");   // Escape sequences 
//         //     }

//         //     Console.WriteLine();
//         // }

//         // // i=2, j=1
//         // string[] names = {"Bishnu", "Sangyel", "Ram" };


//         // // CW: Declare a number array with at least 10 items, print squares of each in console.
//         //  short[] numbers = { 78, 3, 4, 5, 6, 6, 7, 812, 3, 45 };

//         // Console.WriteLine("Using for:");
//         // for (int i = 0; i < numbers.Length; i++)
//         // {
//         //     Console.Write(numbers[i] * numbers[i] + " ");
//         // }

//         // Console.WriteLine("\nUsing foreach:");
//         // foreach (var num in numbers)
//         // {
//         //     int square = num * num;
//         //     // string interpolation
//         //     Console.WriteLine($"{num} * {num} = {sqaure}");
//         // }

//         // //Print multiplication table for 8
//         // // 8 * 1 = 8
//         // // 8 * 2 = 16
//         // // 8 * 3 = 24
//         // // ....
//         // // 8 * 10 = 80

//         // // for (int i = 1; i <= 10; i++)
//         // // {
//         // //     int product = 8 * i;
//         // //     Console.WriteLine($"8 * {i} = {product}");

//         // 1. Print multiplication tables for numbers 10 to 100. Output should look like:

//         // ```
//         // 10 * 1 = 10         11 * 1 = 11         ...         19 * 1 = 19
//         // 10 * 2 = 20         11 * 2 = 22         ...         19 * 2 = 38
//         // 10 * 3 = 30         11 * 3 = 33         ...         19 * 3 = 57
//         // ...                 ...                 ...         ...
//         // 10 * 100 = 100      11 * 10 = 110                   19 * 10 = 190
//         // 20 * 1 = 20         21 * 1 = 21         ...         29 * 1 = 29
//         // 20 * 2 = 40         21 * 2 = 42         ...         29 * 2 = xxx
//         // 20 * 3 = 60         21 * 3 = 63         ...         29 * 3 = xxx
//         // ...                 ...                 ...         ...
//         // 20 * 100 = 200      21 * 10 = 210                   29 * 10 = xxx
//         // .........................
//         // ```

//         // Nested loop

//         // for (int i = 10; i <= 100; i++)
//         // {
//         //     System.Console.WriteLine("Table of" + " " + i);

//         //     for (int j = 1; j <= 10; j++)
//         //     {
//         //         Console.WriteLine($"{i} * {j} = {i * j}");
//         //     }

//         //     Console.WriteLine("**************\n");
//         // }






//     }


// }