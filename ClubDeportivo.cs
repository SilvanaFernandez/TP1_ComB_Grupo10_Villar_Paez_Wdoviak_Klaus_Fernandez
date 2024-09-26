using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_ComB_Grupo10_Villar_Paez_Wdoviak_Klaus_Fernandez
{
    internal class ClubDeportivo
    {
        //atributos (dos listas) de la clase ClubDeportivo
        private List<Socio> socio;
        private List<Actividad> actividad;

        //método constructor -> instanciación
        public ClubDeportivo()
        {
            this.socio = new List<Socio>();
            this.actividad = new List<Actividad>();
        }
             
        
        private Actividad inscribirActividad(string Actividades.nombre, string Socios.dni, int Actividades.cupoDisponible)
        {

        }
    }
}
