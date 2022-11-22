using System;

class Methods
{
    // Returns nothing, takes no arguments

    public void print()
    {
        System.Console.WriteLine("I am a simple method");

    }
    // Returns nothing, takes some arguments
    public void PrintSomething(string message)
    {

        Console.WriteLine(message);
    }

    // Returns something, takes something arguments
    // num3 is optional

    public double Add(double num1, double num2, double num3 = 0)
    {

        var sum = num1 + num2 + num3;
        return sum;

    }

    // Returns something, takes arbitrary number of arguments
    public int Multiply(params int[] numbers)
    {
        var product = 1;
        foreach (var num in numbers)
        {
            product = product * num;

        }
        return product;

        // Returns multiple values, takes some arguments
        public (byte, byte) GetMinMax(byte[] nums)
        {
            byte min = byte.MaxValue max = byte.MinValue;
            foreach (var n in nums) //
            {

            }


        }





    }







}