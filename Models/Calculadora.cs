using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamentos.C_.Models
{
    public class Calculadora
    {
        public void somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y} ");
        }
        public void subtrai(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y} ");
        }
         public void dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y} ");
        }
         public void multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y} ");
        }
         public void restoDaDivisao(int x, int y)
        {
            Console.WriteLine($"{x} % {y} = {x % y} ");
        }
          public void potencia(int x, int y)
        {
            double pot = Math.Pow(x, y);
            Console.WriteLine($"{x}^{y} {pot}");
        }
          public void seno(double angulo)
          {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno do {angulo} = {Math.Round(seno,4)}");
          }         
           public void Coseno(double angulo)
          {
            double radiano = angulo * Math.PI / 180;
            double Coseno = Math.Cos(radiano);
            Console.WriteLine($"Coseno do {angulo} = {Math.Round(Coseno,4)}");
          }         
           public void Tangente(double angulo)
          {
            double radiano = angulo * Math.PI / 180;
            double Tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente do {angulo} = {Math.Round(Tangente,4)}");
          }         
            public void RaizQuadrada(double x)
            {
             double raiz = Math.Sqrt(x);
              Console.WriteLine($"Raiz quadrada de {x} = {raiz}");
            }
    }
}