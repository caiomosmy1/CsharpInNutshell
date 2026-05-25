// CLASSES - Fields
var o = new Octopus();
o.Age.Dump();

class Octopus
{
  string name;
  public int Age = 10;
  Static readonly int leg = 8, eyes = 1;
}

// CLASSES - readonly
var o = new Octopus("Jack");
o.Name.Dump();
o.Legs = 20;

class Octopus
{
  public readonly string Name;
  public readonly int Legs = 9;

  public Octopus (string name)
  {
    Name = name;
  }

}

// CLASSES - Constatns - scoped to class
Test.Message.Dump();

public class Test
{
  public const string Message = "Hello word";
}

// CLASSES - Constants - scoped to method
const double twoPI = 2 * System.Math.PI;
twoPI.Dump();

// CLASSES - Expression-bodied

Foo1 (10).Dump();
Foo2 (10).Dump();

int Foo1 (int x) {return x * 2; }
int Foo2 (int x) => x * 2;

// CLASSES - Local methods
void Main()
{
  WriteCubes()
}
void WriteCubes()
{
  Console.WriteLine (Cube (3));
  Console.WriteLine (Cube (5));
  Console.WriteLine (Cube (4));

  int Cube (int value) => value * value * value;
}

// Local methods - with top-level statements

int x = 3;
Foo();

void Foo() => Console.WriteLine (X);

// Methods - Overloading
void Foo (int x)          { "int".Dump(); }
void Foo (double x)       { "double".Dump(); }
void Foo (int x, float y) { "int, float".Dump(); }
void Foo (float x, int y) { "float, int".Dump(); }

void Main()
{
  Foo (123);      // int
  Foo (123.0);    // double
  Foo (123, 123F);  // int, float
  Foo (123F, 123);  // float, int
}

// The following overloads are prohibited:

// Methods - Illegal Overloading

void  Foo (int x);
float Foo (int x);           // Compile-time error

void  Goo (int[] x);
void  Goo (params int[] x);  // Compile-time error

void Hoo (int x);
void Hoo (ref int x);      // OK so far
void Hoo (out int x);      // Compile-time error

void Main() {}

//Constructors

Panda p = new Panda ("Petey");   // Call constructor

public class Panda
{
  string name;                   // Define field
  public Panda (string n)        // Define constructor
  {
    name = n;                    // Initialization code (set up field)
  }
}

// Constructors - Overloading
new Wine (78).Dump();
new Wine (78, 2001).Dump();

public class Wine
{
  public decimal Price;
  public int Year;
  public Wine (decimal price) => Price = price;
  public Wine (decimal price, int year) : this (price) => Year = year;
  )

// Constructors - Nonpublic
// A common reason to have a nonpublic constructor is to control instance creation via a
// static method call:

Class1 c1 = Class1.Create();  // OK
Class1 c2 = new Class1();    // Error: Will not compile

public class Class1
{
  Class1() { }    // Private constructor
  
  public static Class1 Create()
  {
    // Perform custom logic here to create & configure an instance of Class1
    /* ... */
    return new Class1();
  }
}
  
Deconstructors
Object Initializers
Object Initializer Alternative - Optional Parameters
The this Reference
Properties
Properties - calculated & read-only
Properties - expression-bodied
Automatic Properties
Property Initializers
Properties - get & set accessibility
Indexers
Primary Constructors
Primary Constructors - additional constructors
Primary Constructors and initializers
Primary Constructors - masking
Primary Constructors - validating
Static Constructors
Static Constructors & Field Initialization Order
Static Constructors & Field Initialization Order (Constructor Call)
Partial Types
Partial Methods
Extended Partial Methods
The nameof operator























// INHERITANCE

// THE OBJECT TYPE

// STRUCTS

// ACCESS MODIFIERS

// INTERFACES

// ENUMS

// NESTED TYPES

// GENERICS
