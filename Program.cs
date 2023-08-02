// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices;
using System.Collections;
namespace Training;

/*Console.WriteLine("Hello, World!");
int [] source= {1,2,3,4,5};
var queryInt= from item in source where item <=4 select item;
Console.WriteLine(queryInt);
Console.WriteLine($"Type of QueryInt(Type Var): {queryInt.GetType()}");*/



/*
string[] sourceString=
{
    "Hamza","Ali","Amjad"
};
var queryString= from item in sourceString where item.Length >=2 select item; //Type of queryString will be System.Linq.Enumerable+WhereArrayIterator`1[System.String]
Console.WriteLine(queryString);
Console.WriteLine($"Type of QueryString(Type Var): {queryString.GetType()}");
Console.Read(); //Read int
Console.ReadLine();// Read String
*/
public class Person
{
    public required string LastName { get; set; }
    public required string FirstName { get; set; }
}

public class Everything
{
    public enum MyEnum
    {
        myE = 1
    }

    static void Main(string[] args)
    {
        //var var1 = 2;
        Console.WriteLine("Heyyyy");
        short a = 32767; //Error at 32768
        float x = 12.22f;
        int i = 2;
        Console.WriteLine("x and a contains: {0} {1}", x, a);
        string myNum = "10";
        int sum = Int32.Parse(myNum) + i;
        Console.WriteLine("String to int parsing: " + sum);

        string stringForFloat = "0.85"; // datatype should be float
        string stringForInt = "12345"; // datatype should be int

        float num1 = float.Parse(stringForFloat);
        int num2 = Int32.Parse(stringForInt);
        //const double PI = 3.14;
        // constant field on type byte.
        byte b = byte.MaxValue;
        Console.WriteLine($"Max value of byte is: {b} ");
        Console.WriteLine($"Printing my Enum: {MyEnum.myE}");
        if ((int)MyEnum.myE == 1)
        {
            Console.WriteLine($"Printing my Enum: {(int)MyEnum.myE}");
        }

        Type t = 1.GetType();
        var v = new { Amount = 108, Message = "Hello" };
        Console.WriteLine(v.Amount + v.Message);
        IEnumerable<char> someCharacters = "abcdefghijklmnopqrstuvwxyz";
        Console.WriteLine(someCharacters);
        int[] numbers = { 1, 2, 3, 4, 5 };
        IEnumerable enumerable = numbers; // IEnumerable reference to int array

        IEnumerator enumerator = enumerable.GetEnumerator(); // Get the enumerator
        while (enumerator.MoveNext()) // MoveNext() returns false when the end is reached
        {
            int number = (int)enumerator.Current; // Access the current element
            Console.WriteLine(number);
        }
        //Arrays are known as pitfall for nullable reference types.
        /*string[] values = new string[10];
        string s = values[0];
        Console.WriteLine(s.ToUpper());*/

        //var p1 = new Person(); // Error! Required properties not set
        var pe2 = new Person() { FirstName = "Grace", LastName = "Hopper" };

        var p1 = new Coords(0, 0);
        Console.WriteLine(p1); // output: (0, 0)

        var p2 = p1 with { X = 3 };
        Console.WriteLine(p2); // output: (3, 0)

        var p3 = p1 with { X = 1, Y = 4 };
        Console.WriteLine(p3); // output: (1, 4)
    }
}

public class Foo
{
    public int N;
}
public class NullableQuestionsTest
{
    private Foo _f;
    public string QText { get; }
    public string? QHint { get; }
    public NullableQuestionsTest()
    {
        _f = new Foo();
        Console.WriteLine(_f);
        QHint = "No Hint Available" ;
    }
    
}

//Inheritance
public class Manager : Person
{
    // Employee fields, properties, methods and events are inherited
    // New Manager fields, properties, methods and events go here...
}

public readonly struct Coords
{
    public Coords(double x, double y)
    {
        X = x;
        Y = y;
    }

    public double X { get; init; }
    public double Y { get; init; }

    public override string ToString() => $"({X}, {Y})";
}
//Beginning with C# 12, you can declare inline arrays as a struct type:
/*[System.Runtime.CompilerServices.InlineArray(10)]
public struct CharBuffer
{
    private char _firstElement;
}*/

public struct TempStruct
{
    public string Name="Hamza";

    public TempStruct()
    {
        Name = "Hamza";
    }
}