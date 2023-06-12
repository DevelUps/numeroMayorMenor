using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeroMayorMenor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variable
            double numero;
            // se solicita al usuario el numero a evaluar
            Console.Write("Por favor ingresa numero a evaluar: ");
            // Se asigna valor a la variable y se convierte el dato segun el valor ingresado
            numero = double.Parse(Console.ReadLine());
            // evaluamos los valores que ingresa el usuario
            if (numero < 0)
            {
                Console.WriteLine("El valor ingresado es {0} y es negativo", numero);
            }
            if (numero > 0) 
            {
                Console.WriteLine("El valor ingresado es {0} y es positivo",numero);
            }
            if (numero == 0)
            {
                Console.WriteLine("El numero ingresado es igual a {0} y no puede ser evaluado", numero);
            }
            



        }
    }
}
