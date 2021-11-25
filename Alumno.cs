using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP9_ABSM_B
{
    public class Alumno
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }

        public Alumno(string Nombre, string Apellido, int DNI)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.DNI = DNI;
        }
        public override string ToString()
        {
            return Nombre + "," + Apellido + "," + DNI;
        }
    }

    public class Nota
    {
        public int DNI { get; set; }
        public double Valor { get; set; }
        public DateTime Fecha { get; set; }

        public Nota(int DNI, double Valor, DateTime Fecha)
        {
            this.DNI = DNI;
            this.Valor = Valor;
            this.Fecha = Fecha;
        }

        public override string ToString()
        {
            return DNI + "," + Valor + "," + Fecha.ToString();
        }
    }
}
