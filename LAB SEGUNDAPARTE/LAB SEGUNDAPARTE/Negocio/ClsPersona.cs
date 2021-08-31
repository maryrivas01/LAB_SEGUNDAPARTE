﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_SEGUNDAPARTE.Negocio
{
    class ClsPersona
    {
        Persona pers = new Persona();
        public String CalcularIMC()
        {
            double pro = pers.Peso1 / Math.Pow(pers.Altura1, 2);

            if (pro < 20)
            {
                return "peso ideal";
            }
            if (pro > 25)
            {
                return "tiene sobre peso";
            }
            return "";
        }

        public String MayorDeEdad()
        {
            if (pers.Edad1 >= 18)
            {
                return "El usuario es mayor de edad";

            }
            else
                return "El usuario es menor de edad";
        }
    }
        
}