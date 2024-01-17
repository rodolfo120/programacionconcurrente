using System;

class Program {
    static void Main() {
        Console.Write("Ingrese la longitud del rectángulo: ");
        double longitud = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el ancho del rectángulo: ");
        double ancho = Convert.ToDouble(Console.ReadLine());

        double area = longitud * ancho;
        Console.WriteLine("El área del rectángulo es: " + area);
    }
}
