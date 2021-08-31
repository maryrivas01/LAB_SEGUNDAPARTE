using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_SEGUNDAPARTE
{
    class Persona
    {

        private String nombre;
        private int edad;
        private string sexo;
        private double peso;
        private double altura;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public double Peso { get => peso; set => peso = value; }
        public double Altura { get => altura; set => altura = value; }

        public Persona(double peso, double altura)
        {
            Peso = peso;
            Altura = altura;
        }

        public Persona(string nombre, int edad, string sexo)
        {
            Nombre = nombre;
            Edad = edad;
            Sexo = sexo;
        }

        public Persona(string nombre, int edad, string sexo, double peso, double altura)
        {
            Nombre = nombre;
            Edad = edad;
            Sexo = sexo;
            Peso = peso;
            Altura = altura;
        }

        public Persona()
        {
        }

        public override string ToString()
        {
            return Nombre + " " + Edad + "  " + Peso + "  " + Altura;
        }


    }
}
