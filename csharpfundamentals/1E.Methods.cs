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

    }

    // returns multiple values, takes some arguments
    public (byte, byte) GetMinMax(byte[] nums)
    {
        byte min = byte.MaxValue, max = byte.MinValue;
        foreach (byte n in nums) // nums={2,3,1,4}
        {
            if (n < min)
            {
                min = n;
            }
            if (n > max)
            {
                max = n;
            }
        }

        return (min, max);
    }


    // cw1: write a method which returns average of all 4 numbers supplied as parameter.

    public float CalculateAverage(short n1, short n2, short n3, short n4)
    {

        float average = ((float)n1 + n2 + n3 + n4) / 4;




       return average;
    }



// cw2: modify above method to take array of numbers and calculate average of all.
    
    public float CalculateAverageArray(params short[] numbers)
    {
        float average2 = 0;

    foreach (var n in numbers)
    {
        average2 = average2 + n;
    }

    float average1 = average2/numbers.Length;
    return average1;
    }

// modify same method to return average and minimum of all.
public float CalculateAverageAndMinimum(params short[] numbers)
    {
        float average3 = 0;

    foreach (var n in numbers)
    {
        average3 = average3 + n;
    }

    float average = average3/numbers.Length;
    return average;
    }

    float min = float.maxvalue



}