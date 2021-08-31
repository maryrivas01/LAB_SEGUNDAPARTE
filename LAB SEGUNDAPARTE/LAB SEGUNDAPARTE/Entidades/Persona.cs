using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_SEGUNDAPARTE
{
    class Persona
    {



        private String Nombre;
        private int Edad;
        private string Sexo;
        private int Peso;
        private int Altura;


        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public int Edad1 { get => Edad; set => Edad = value; }
        public string Sexo1 { get => Sexo; set => Sexo = value; }
        public int Peso1 { get => Peso; set => Peso = value; }
        public int Altura1 { get => Altura; set => Altura = value; }



        public Persona(int peso, int altura)
        {
            Peso1 = peso;
            Altura1 = altura;
        }

        public Persona(string nombre, int edad, string sexo)
        {
            Nombre1 = nombre;
            Edad1 = edad;
            Sexo1 = sexo;
        }

        public Persona(string nombre, int edad, string sexo, int peso, int altura)
        {
            Nombre1 = nombre;
            Edad1 = edad;
            Sexo1 = sexo;
            Peso1 = peso;
            Altura1 = altura;
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
