
// Console.WriteLine(employee_Name+ "," +age+ "," +weight+ "," +passport);
// for printing in same line Console.WriteLine("{0},{1},{2},{3},{4}",employee_Name,age,weight,passport,dt);
// Console.WriteLine("Hello, World!");
// DateTime x = DateTime.Now;
// Console.WriteLine(x);

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

// // object created
//     Person person1 = new();
//     person1.name = "Sitaram";
//     person1.age = 12;

//     string message = person1.GetLegalGreeting();
//     Console.WriteLine(message);

// Create a C# class with 3 fields in it and a method. 
// Create an object from that class in Main() method and print corresponding field values.
 

students student = new();
student.section = "first, second, third, fourth, fifth, sixth, seventh";
student.semester = 4;

string suggestion = student.message();
Console.WriteLine(suggestion);




