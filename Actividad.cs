using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_ComB_Grupo10_Villar_Paez_Wdoviak_Klaus_Fernandez
{
    internal class Actividad
    {
        //atributos
        private string nombre;
        private int cupoDisponible;

        //método constructor -> instanciación
        public Actividad(string nombre, int cupoDisponible)
        {
            this.Nombre = nombre;
            this.CupoDisponible = cupoDisponible;
        }

        //métodos get y set
        public string Nombre { get => nombre; set => nombre = value; }
        public int CupoDisponible { get => cupoDisponible; set => cupoDisponible = value; }

        //sobreescribir el método ToString con un override
        public override string ToString()
        {
            return "Actividad: " + Nombre + "/nCupos disponibles: " + CupoDisponible;
        }
    }
}
