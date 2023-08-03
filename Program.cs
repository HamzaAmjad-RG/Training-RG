// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices;
using System.Collections;
using System.Drawing;

//Alias support in C# 12
//global using BandPass = (int Min, int Max);
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
public interface IAnimal
{
    void Speak(); // Traditional interface method

    // Default interface method
    void Eat()
    {
        Console.WriteLine("The animal eats.");
    }
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
        
        
        //Tuples
        (double, int) t1 = (4.5, 2);
        Tuples t2 = new Tuples();
        Console.WriteLine($"Length of Default: {t2.NoOfCharactersInName()}");
        t2.SetName("Hamza");
        Console.WriteLine($"Length of my Name is : {t2.NoOfCharactersInName()}");

        //Tuples t3 = new Tuples(name:"Hamza", 2, value:999);
        
        //Named arguments can be in any order.
        Tuples t3 = new Tuples(id:2,name:"Hamza", value:999);
        (int?, string) t4 = t3.GetATuple();
        Console.WriteLine($"Tuple Id: {t4.Item1} \n Tuple Name:{t4.Item2}");
        t4.Item1 = 2123;
        Console.WriteLine($"Tuple Id: {t4.Item1} \n Tuple Name:{t4.Item2}");

            
        (int? id, string name) t5 = t3.GetATuple();
        Console.WriteLine($"Tuple Id: {t5.id} \n Tuple Name:{t5.name}");
        var (id, name) = t3.GetATuple();
        Console.WriteLine($"Tuple Id: {id} \n Tuple Name:{name}");
        
        var tt = (Sum: 4.5, Count: 3);
        Console.WriteLine($"Sum of {tt.Count} elements is {tt.Sum}.");

        (double Sum, int Count) d = (4.5, 3);
        Console.WriteLine($"Sum of {d.Count} elements is {d.Sum}.");
        //This works only with
        var (id5,_)= t3.GetATuple();
        (int? , string _) t7 = t3.GetATuple();
        Console.WriteLine(t3.val());
        //(string,int?, int?) t8 = t3;
        Math.DisplayNothing();
        IMinusTwo<int> m = new Math();
        Console.WriteLine("----------------------------------------------------------------");
        m.DisplayHello();
        
        //Error on Dog.Eat();
        /*Dog dog = new Dog();
        dog.Speak();  // Output: Woof!
        dog.Eat();    // Output: The animal eats.*/
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

public class Tuples
{
    private string _tupleName = null;
    private int? _tupleId = null;
    private int? _tupleValue;

    public Tuples()
    {
        //_tupleName = "Default Name";
        _tupleId = null;
    }
    
    public Tuples(string name, int id, int? value=null)
    {
        _tupleName = name;
        _tupleId = id;
        _tupleValue = value;
        
    }

    public int NoOfCharactersInName()
    {
        if (_tupleName == null)
            return 0;
        //return _tupleName.Length;
        
        //Checking foreach
        int countChar = 0;
        foreach (var character in _tupleName)
        {
            countChar++;
        }

        //int a = _tupleId ?? 0;
        return countChar;
    }
    public void SetName(string name)
    {
        this._tupleName = name;
    }

    public (int?, string) GetATuple()
    {
        return (_tupleId, _tupleName);
    }

    public double val()
    {
        double n = 1 / 2.0;
        return n;
    }
}

interface IAddTwo
{
    int Add(int val);
}
interface IEquatable
{
    bool Equals(int obj);
}

public interface IMinusTwo<T>
{
    int Minus(T val);

    void DisplayHello()
    {
        Console.WriteLine("Hello!!!!");
    }
}

public class Math: IAddTwo, IMinusTwo<int>
{
    public int Add(int val)
    {
        //throw new NotImplementedException();
        return 2 + val;
    }

    public int Minus(int val)
    {
        //throw new NotImplementedException();
        return val - 2;
        
    }

    public static void DisplayNothing()
    {
        Console.WriteLine("Nothing!!");
    }
}

public class Dog : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Woof!");
    }
}

public abstract class Motorcycle
{
    // Anyone can call this.
    public void StartEngine() {/* Method statements here */ }

    // Only derived classes can call this.
    protected void AddGas(int gallons) { /* Method statements here */ }

    // Derived classes can override the base class implementation.
    public virtual int Drive(int miles, int speed) { /* Method statements here */ return 1; }

    // Derived classes can override the base class implementation.
    public virtual int Drive(TimeSpan time, int speed) { /* Method statements here */ return 0; }

    // Derived classes must implement this.
    public abstract double GetTopSpeed();
}

public class Cycle: Motorcycle
{
    public override double GetTopSpeed()
    {
        return 60.0;
    }
    
    //There is no suitable method for override
    /*public override void AddGas()
    {
        
    }*/
}