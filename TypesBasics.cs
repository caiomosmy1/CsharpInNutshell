//String, int and bool types are examples of predefined types

string message = "Hello Word !";
string upperMensage = message.ToUpper();
Console.WriteLine (upperMessage); // HELLO WORD !

int x = 2015;
message = messagem x x.ToString();
Console.WriteLine (message); // Hello Word 2015

bool simpleVar = false;
if (simpleVar)
  Console.WriteLine ("This will not print");

int y = 5000;
bool lessThanAMile = y < 5290;
if (lessThanAMile)
  Console.WriteLine ("This Will Print");

// 2-2 Custom Type Examples
// Assim como podemos construir funções complexas a partir de funções simples, podemos construir tipos complexos a partir de tipos prmitivos
// O Conversor de unidade serve como um modelo para conversões de unidades

UnitConverter feetToInchesConverter = new UnitConverter (12);
UnitConverter milesToFeetConverter = new UnitConverter (5200);

Console.WriteLine (feetToInchesConverter.Convert (30)); // 360
Console.WriteLine (feetToInchesConverter.Convert (100)); // 1200
Console.WriteLine (feetToInchesConverter.Convert (milesToFeetConverter.Convert (1))); // 63360

public class UnitConverter
{
  int ratio;                                                  // filed
  public UnitConverter (int unitRatio) { ratio = unitRatio; } // Constructor
  public int Convert (int unit)        { return unit * ratio;} // Method
}

// 2-3 Instance vs Static Members
// The instance field Name pertains to an instance of a particular Panda,
// whereas Population pertains to the set of all Pandas:

Panda p1 = new Panda ("Pan Dee");
Panda p2 = new Panda ("Pan Dah");

Console.WriteLine (p1.Name);      // Pan Dee
Console.WriteLine (p2.Name);      // Pan Dah

Console.WriteLine (Panda.Population);   // 2

public class Panda
{
  public string Name;             // Instance field
  public static int Population;   // Static field

  public Panda (string n)         // Constructor
  {
    Name = n;                      // Assign the instance field
    Population = Population + 1;   // Increment the static Population field
  }
}
// 2-4 Defining a namespace
// The same code, but with Panda defined inside a namespace.

using Animals;

Panda p = new Panda ("Pan Dee");
Console.WriteLine (p.Name);

namespace Animals
{
  public class Panda
  {
    public string Name;

    public Panda (string n)         // Constructor
    {
      Name = n;                     // Assign the instance field
    }
  }
}

// 2-5 Defining a Main method
// // Aqui está o nosso programa original, sem usar instruções de nível superior.
using System;

class program
{
  static void Main() // Program entry point
  {
    int x = 12 * 30;
    Console.WriteLine (x);
  }
}
// 2-6 Conversions
// Conversões implícitas são permitidas quando o compilador pode garantir que elas sempre serão bem-sucedidas e nenhuma informação será perdida na conversão;

int x = 12345; // int é um inteiro de 32 bits
long y = x;    // Conversão implícita para inteiro de 64 bits

// Em outros casos, você precisa de conversões explícitas:

short z = (short)x; // Conversão explícita para inteiro de 16 bits

x.Dump ("x");
y.Dump ("y");
z.Dump ("Z");

// 2-7 Value Types
// O conteúdo de uma variável ou constante de tipo valor é simplesmente um valor.
// Você pode definir um tipo valor personalizado com a palavra-chave struct:
Point p1 = new Point();
p1.X = 7;

Point p2 = p1;             // Assignment causes copy

Console.WriteLine (p1.X);  // 7
Console.WriteLine (p2.X);  // 7

p1.X = 9;                  // Change p1.X

Console.WriteLine (p1.X);  // 9
Console.WriteLine (p2.X);  // 7

public struct Point { public int X, Y; }

// 2-8 Reference Types
// Um ​​tipo de referência tem duas partes: um objeto e a referência a esse objeto.
Point p1 = new Point();

p1.X = 7;

Point p2 = p1;             // Copies p1 *reference*

Console.WriteLine (p1.X);  // 7
Console.WriteLine (p2.X);  // 7

p1.X = 9;                  // Change p1.X

Console.WriteLine (p1.X);  // 9
Console.WriteLine (p2.X);  // 9

public class Point { public int X, Y; }
// 2-9 Null
// Uma referência pode receber o valor literal nulo, indicando que a referência não aponta para nada:
Point p = null;
Console.WriteLine (p == null);   // True

// A linha seguinte gera um erro de tempo de execução (uma exceção NullReferenceException é lançada):
Console.WriteLine(p.X)

public class Point { public int X, Y; 
// 2-10 Nulls With Structs
// Normalmente, um tipo de valor não pode ter um valor nulo:
Point p = null;   // This line will not compile.
int x = null;      // Illegal, too.

public struct Point { public int X, Y; }

// See "Nullable Types" in Chapter 4 for a workaround.
                    
// 2-11 Storage Overhead
// As estruturas ocupam tanto espaço quanto seus campos:

unsafe static void Main()
{
  sizeof (Point).Dump(); // 8 bytes
  sizeof (A).Dump();     // 16 bytes
}

struct Point
{
  int x;  // 4 bytes
  int y;  // 4 bytes
}

// However, the CLR requires that fields are offset within the type at an address
// that’s a multiple of their size:
struct A
{
  byte b;  // 1 byte
  long l;  // 8 bytes
}
