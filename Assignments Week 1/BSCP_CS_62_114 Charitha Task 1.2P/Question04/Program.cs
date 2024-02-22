
// BSCP|CS|62|114   Charitha Pieris


using System;

namespace CodeSnippetExamples {
    class Program {
        static void Main(string[] args) {
            // Code Snippet 1: 
            int c = 0, product = 1;
            while (c <= 5) {            
                product = product * 5; // Multiply 'product' by 5 for 6 iterations
                c = c + 1;
            }
            Console.WriteLine("Product: " + product); // Display the product

            // Code Snippet 2: 
            int a = 31, b = 0, sum = 0; 
            while (a != b) {
                sum = sum + a; // Add 'a' to 'sum'
                b = b + 2; // Increment 'b' by 2
                if (b > a) {
                    break; // Exit the loop if 'b' exceeds 'a'
                }
            }
            Console.WriteLine("Sum: " + sum); // Display the sum

            // Code Snippet 3: 
            int x = 1;
            int total = 0;      
            while (x <= 10) {
                total = total + x; // Add 'x' to 'total'
                x = x + 1; // Increment 'x'
            }
            Console.WriteLine("Total: " + total); // Display the total

            // Code Snippet 4: 
            int y = 0;          
            while (y < 10) {
                Console.WriteLine("y: " + y); // Display 'y'
                y = y + 1; // Increment 'y'
            }

            // Code Snippet 5: 
            int z = 0;          
            while (z > 0) {
                z = z - 1; // Decrement 'z'
                Console.WriteLine("z: " + z); // Display 'z'
            }

            // Code Snippet 6: 
            for (int count = 1; count < 100; count++) {
                Console.WriteLine("Hello"); // Display "Hello"
            }

            // Code Snippet 7: 
            for (int i = 1; i < 10; i++) {
                if (i > 2) {
                    Console.WriteLine("Flower"); // Display "Flower" for i > 2
                }
            }
        }
    }
}
