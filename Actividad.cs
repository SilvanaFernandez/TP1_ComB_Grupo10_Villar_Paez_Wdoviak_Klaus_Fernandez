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
        private string nombreAct;
        private int cupoDisponible;

        //instanciación
        public Actividad(string nombreAct, int cupoDisponible)
        {
            this.NombreAct = nombreAct;
            this.CupoDisponible = cupoDisponible;
        }

        //métodos get y set
        public string NombreAct { get => nombreAct; set => nombreAct = value; }
        public int CupoDisponible { get => cupoDisponible; set => cupoDisponible = value; }

        //sobreescribir el método ToString con un override
        public override string ToString()
        {
            return "Actividad: " + NombreAct + "\nCupos disponibles: " + CupoDisponible;
        }
    }
}
