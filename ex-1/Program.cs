// See https://aka.ms/new-console-template for more information
double raio, area, diametro, perimetro;

Console.Write("Informe a o raio do Circulo: ");
raio = Convert.ToDouble(Console.ReadLine());

area = 3.14 * (raio*raio);
diametro = 2*raio;
perimetro = 2*3.14*raio; 

Console.WriteLine("A area do circulo é:" + area);
Console.WriteLine("O diametro do circulo é:" + diametro);
Console.WriteLine("O perimetro do circulo é:" + perimetro);

