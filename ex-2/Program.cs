// See https://aka.ms/new-console-template for more information
int a,b,c;
double delta, x1, x2;

Console.Write("Entr com o valor de A: ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Entr com o valor de B: ");
b = Convert.ToInt32(Console.ReadLine());

Console.Write("Entr com o valor de C: ");
c = Convert.ToInt32(Console.ReadLine());

delta = (b*b)-4*a*c;

x1 = (-b + Math.Sqrt(delta)) / (2*a);
x2 = (-b - Math.Sqrt(delta)) / (2*a);

Console.WriteLine(delta);
Console.WriteLine("X1 = " + x1);
Console.WriteLine("X2 = " + x2);



