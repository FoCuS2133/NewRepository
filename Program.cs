using System.Drawing;
using System.Threading.Channels;
using Triangle;

ForTriangle one = new();
Console.WriteLine("Введите стороны треугольника");
string a=Console.ReadLine();
string b=Console.ReadLine();    
string c=Console.ReadLine();
int A=int.Parse(a);
int B=int.Parse(b);
int C=int.Parse(c);


one.Perimeter();
one.Area();
