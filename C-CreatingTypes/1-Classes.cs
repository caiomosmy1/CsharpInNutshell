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











// INHERITANCE

// THE OBJECT TYPE

// STRUCTS

// ACCESS MODIFIERS

// INTERFACES

// ENUMS

// NESTED TYPES

// GENERICS
