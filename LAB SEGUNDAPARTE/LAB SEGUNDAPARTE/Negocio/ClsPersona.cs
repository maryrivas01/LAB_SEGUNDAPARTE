using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_SEGUNDAPARTE.Negocio
{
    class ClsPersona

    {

        public String CalcularIMC(Persona persona)
        {
            double pro = (persona.Peso / Math.Pow(persona.Altura, 2));

            if (pro <= 20)
            {
                return "Peso ideal";
            }
            else
            {
                return "Tiene sobre peso";
            }
        }
        public string esMayorDeEdad(Persona persona)
        {
            if (persona.Edad >= 18)
            {
                return "Es mayor de Edad";
            }
            else
            {
                return "Es menor de edad";
            }
        }

    } 
}
