using System.Globalization;

double raioDoCirculo, pi, area;

raioDoCirculo = double.Parse(Console.ReadLine());
pi = 3.14159;

area = pi * raioDoCirculo * raioDoCirculo;

Console.WriteLine("A = "+area.ToString("F4", CultureInfo.InvariantCulture));
