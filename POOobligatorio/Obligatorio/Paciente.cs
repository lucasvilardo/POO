using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio
{
    class Paciente
    {
        int cedula;
        string nombre;
        DateTime fechaNac;

        public int Cedula
        {
            get { return cedula; }         
            set                                    
            {
                if (value.ToString().Length != 8 )
                    Console.WriteLine("La cédula debe tener 8 caracteres");

                cedula = value;

            }
        }

        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (value == null || value.Trim() == "")
                    Console.WriteLine("El nombre no puede estar vacío y deben ser caracteres.");


            }
        }

        public DateTime FechaNac
        {
            


            get { return fechaNac; }
            set
            {
                DateTime FechaActual = DateTime.Now;
                if (value > FechaActual)
                    Console.WriteLine("La fecha de nacimiento no puede ser mayor a la fecha actual.");

                value = fechaNac;

            }
        }

        public Paciente(int pCedula, string pNombre, DateTime pFechaNac)
        {
            Cedula = pCedula;
            Nombre = pNombre;
            FechaNac = pFechaNac;
          
        }




    }
}
