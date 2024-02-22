//BSCP_CS_62_114 Charitha 

using System;

class TestMyPolynomial
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        
        // Create polynomial objects
        MyPolynomial p1 = new MyPolynomial(6, 8, 6, 0, 1);
        MyPolynomial p2 = new MyPolynomial(1, 2, 3);
        
        // Display polynomial information
        Console.WriteLine("Polynomial p1: " + p1.ToString());
        Console.WriteLine("Degree of p1: " + p1.GetDegree());
        Console.WriteLine("Evaluate p1 at x=2: " + p1.Evaluate(2));

        Console.WriteLine("\nPolynomial p2: " + p2.ToString());
        Console.WriteLine("Degree of p2: " + p2.GetDegree());
        Console.WriteLine("Evaluate p2 at x=3: " + p2.Evaluate(3));

        // Perform polynomial operations
        MyPolynomial sum = p1.Add(p2);
        Console.WriteLine("\nSum of p1 and p2: " + sum.ToString());

        MyPolynomial product = p1.Multiply(p2);
        Console.WriteLine("Product of p1 and p2: " + product.ToString());
    }
}
