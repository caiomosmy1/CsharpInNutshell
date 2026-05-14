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

//   
