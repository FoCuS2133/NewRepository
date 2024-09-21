using System.Drawing;
using System.Threading.Channels;
using Triangle;

ForTriangle one = new();
Console.WriteLine("Введите стороны треугольника");
string a=Console.ReadLine();
string b=Console.ReadLine();    
string c=Console.ReadLine();
uint A=uint.Parse(a);
uint B=uint.Parse(b);
uint C=uint.Parse(c);


one.Perimeter();
one.Area();
