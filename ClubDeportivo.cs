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
        private List<Socio> socioList;
        private List<Actividad> actividadList;

        //método constructor -> instanciación
        public ClubDeportivo()
        {
            this.socioList = new List<Socio>();
            this.actividadList = new List<Actividad>();
        }
             
        
        //Definimos el siguiente metodo para inscribir un socio en una actividad
        public bool InscribirActividad(string nombreActividad, string dniSocio)
        {
            Actividad actividad = actividadList.Find(a => a.Nombre == nombreActividad);
            Socio socio = socioList.Find(s => s.Dni == dniSocio);

            if (actividad != null && socio != null && actividad.CupoDisponible > 0) 
            {
                socio.Actividad = actividad; //asignamos la actividad
                actividad.CupoDisponible--; //y reducimos el cupo tras ser registradoel socio en la actividdd
                return true;
            }
            return false;
        }

        //para obtener lalista de actividades
        public List<Actividad> ObtenerActividades()
        {
            return actividadList;
        }
    }
}
