using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Globalization;
using System.Reflection.PortableExecutable;

namespace Cartesiano {
    internal class Program {
        static void Main(string[] args) {


            string[] valores = Console.ReadLine().Split(' ');
            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);

            while (x != 0 && y != 0) {
                
                if (x > 0 && y > 0) {
                    Console.WriteLine(" primeiro Quadrante ");
                }
                else if (x < 0 && y > 0) {
                    Console.WriteLine("Segundo Quadrante ");
                }
                else if (x < 0 && y < 0) {
                    Console.WriteLine("terceiro Quadrante ");

                }
                else {
                    Console.WriteLine(" Quarto Quadrante ");
                }

                valores = Console.ReadLine().Split(' ');
                x = int.Parse(valores[0]);
                y = int.Parse(valores[1]);





            }
        }
    }
}

