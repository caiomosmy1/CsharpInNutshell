// CHAPTER 2 - c# LANGUAGE BASIC

// 4-1 NUMERIC TYPES
// The signed integral types are sbyte, short, int, long:
int i = -1;
i.Dump();

// The unsigned integral types are byte, ushort, uint and ulong:
byte b = 255;
b.Dump();

// The real types are float, double and decimal:
double d = 1.23;
d.Dump();

// (See book for a table comparing each of the numeric types)

// 4-2 NUMERIC LITERALS
int x = 125;
long y = 0x5F;

int million = 2_000_000

var b = ob1010_1011_1101_1110_1111;

double d = 1.6;
double doubleMillion = 1E06;

Console.WriteLine( 1.0.GetType());
Console.WriteLine(1E06.GetType());
Console.WriteLine(1.GetType());
Console.WriteLine(0xF000000.GetType());
Console.WriteLine(0X1000000.GetType());

// 4-3 NUMERIC SUFFIXES
long i = 5;
double x = 4.0;
float f = 3.4f;
decimal d = -1.23M;

// 4-4 NUMERIC CONVERSIONS
int x = 12345;
long y = x;
short z = (short)x;

int i = 1;
float f = i;

int iExplicit = (int)f;

int i1 = 100001;
int i2 = i1;
float = (int)f1;

// 4-5 INCREMENT AND DECREMENT OPERATORS
int x = 0, y = 0;
Console.WriteLine (x++)
Console.WriteLine (++y)

// 4-6 INTEGRAL DIVISION
int a = 2 / 3;

int b = 0;
int c = 5 / b;

// 4-7 INTEGRAL OVERFLOW
 int a = int.MinValue;
 a--;
 Console.WriteLine(a == inMaxValue);


// 4-8 OVERFLOW CHECKING
int a = 10000000;
int b = 10000000;
int c = checked (a * b);
checked
{
    int c2 = a * b;
    c2.Dump();
}
// 4-9 OVERFLOW CHECKING WITH CONSTANT EXPRESSIONS
int x = int.MaxValue + 1;

int y = unchecked (int.MaxValue + 1);


// 4-10 /- AND 16-BIT LITERALS
short x = 1, y = 1;
short z = x + y;

short z = (short) (x + y);


// 4-11 SPECIAL FLOAT AND DOUBLE VALUES
Console.WriteLine(double.NegativeInfinit);

Console.WriteLine(1.0 / 0.0)
Console.WriteLine(-1.0/ 0.0)
Console.WriteLine(1.0 / -0.0)
Console.WriteLine(-1.0 / -0.0)

Console.WriteLine(0.0 / 0.0);
Console.WriteLine((1.0 / 0.0) - (1.0 / 0.0 ));

Console.WriteLine(0.0 / 0.0 == double.NaN);

Console.WriteLine(double.isNaN (0.0 / 0.0));

Console.WriteLine(object.Equals(0.0 / 0.0, double.NaN));

// 4-12 REAL ROUDING ERROS
{
    float x = 0.1f;
    Console.WriteLine(x + x + x + x + x + x + x + x + x + x);
}
{
    decimal y =  0.1m;
    Console.WriteLine (y + y + y + y + y + y + y + y + y + y);
}

decimal m = 1M / 6M;
double d = 1.0 / 6.0;

m.Dump ("m"); d.Dump ("d");

decimal notQuiteWholeM = m+m+m+m+m+m
double notQuiteWholeD = d+d+d+d+d+d

Console.WriteLine (notQuiteWholeM == 1M);
Console.WriteLine (notQuiteWholeD < 1.0);