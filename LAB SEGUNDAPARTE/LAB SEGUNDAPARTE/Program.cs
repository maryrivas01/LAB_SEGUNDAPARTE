using System;
using LAB_SEGUNDAPARTE.Negocio;

namespace LAB_SEGUNDAPARTE
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona clsPersona = new Persona();
            ClsPersona nclspersona = new ClsPersona();

            Console.WriteLine("Escriba su nombre");
            String nombre = (Console.ReadLine());

            Console.WriteLine("Escriba su edad");
            int edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escriba su genero H o M");
            String sexo = (Console.ReadLine());

            Console.WriteLine("Escriba su peso");
            Double peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escriba su altura");
            Double altura = Convert.ToDouble(Console.ReadLine());

            Persona persona = new Persona(nombre, edad, sexo, peso, altura);
            Persona persona1 = new Persona(nombre, edad, sexo);

            Console.WriteLine(nclspersona.CalcularIMC(persona));
            Console.WriteLine(nclspersona.esMayorDeEdad(persona1));

            Console.WriteLine(persona.ToString());
            Console.ReadLine();

        }
    }
}
