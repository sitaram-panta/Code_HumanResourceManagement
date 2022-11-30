
using System;


class program
{
    public static void Main()
    {
        

    
        House obj1 = new(4, 40);
        obj1.Length = 34.4f;
        obj1.width = 23.34f;
       var AreaOfRoof1 =obj1.GetAreaOfRoof();
       System.Console.WriteLine(AreaOfRoof1);
        

        Collection coll = new();
        coll.LearnList();
        coll.LearnDictionary();
    
    
    
    
    }







}




