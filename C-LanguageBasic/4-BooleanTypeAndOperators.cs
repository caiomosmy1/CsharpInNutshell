//EQUALITY AND COMPARISON OPERATORS
int x = 1;
int y = 2;
int z = 1;

Console.WriteLine(x == y);
Console.WriteLine(x != y);
Console.WriteLine(x == z);

Console.WriteLine(x < y);
Console.WriteLine(x >= z);


// EQUIALITY WITH REFERENCE TYPES
Dude d1 = new Dube ("John");
Dude d2 = new Dube ("John");
Console.WriteLine (d1 == d2);
Dude d3 = d1;
Console.WriteLine(d1 == d3);

public class Dude
{
    public string Name;
    public dude (string n) { Name = n; }
}

//AND & OR OPERATORS
UseUmbrella (true, false, false).Dump();
UseUmbrella (true, true, true).Dump();

bool UseUmbrella (bool rainy, bool sunny, bool windy)

//Shortcirtcuiting

StringBuilder sb = null;

if(sb != null & sb.Lenght > 0)
    Console.WriteLine("sb has data")
else 
    Console.WriteLine("sb is null or empty");

//And & Or Operators -non-shortcircuiting
UseUmbrella (true, false, false).Dump();
UseUmbrella (true, true, true).Dump();

StringBuilder sb = null;

if(sb != null & sb.Lenght > 0)
    Console.WriteLine("sb has data");
else
    Console.WriteLine("sb is null or empty");
bool
    UseUmbrella (bool rainy, bool sunny, bool windy)
{
    return !windy & (rainy | sunny);
}