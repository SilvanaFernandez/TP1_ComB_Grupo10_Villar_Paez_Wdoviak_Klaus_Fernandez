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
        private List<Socio> socios;
        private List<Actividad> actividades;

        //método constructor -> instanciación
        public ClubDeportivo()
        {
            this.socios = new List<Socio>();
            this.actividades = new List<Actividad>();
        }
             
        
        //Definimos el siguiente metodo para inscribir un socio en una actividad
        public string InscribirActividad(string nombreActividad, string dniSocio)
        {
            Actividad actividad = buscarActividad(nombreActividad);
            Socio socio = socios.Find(s => s.Dni == dniSocio);

            if (actividad == null) 
            {
                return "ACTIVIDAD INEXISTENTE";
            }
            if (socio == null)
            {
                return "SOCIO INEXISTENTE";
            }
            return "false";

            /*
             en el siguiente if, verificamos si el socio esta inscripto
            en la maxima cantidad de actividades permitidas [3]
             */
            if (socio.ActividadesInscriptas.Count >= 3) 
            {
                return "TOPE DE ACTIVIDADES ALCANZADO";
            }

            //a continuación verificamos la disponibilidad de cupos en la actividad
            if (actividad.CupoDisponible <= 0) 
            {
                return "SIN CUPOS DISPONIBLES";
            }

            if (actividad != null && socio != null && actividad.CupoDisponible >= 1) 
            {
                socio.ActividadesInscriptas.Add(actividad);
                actividad.CupoDisponible--;
                return "INSCRIPCIÓN EXITOSA";
            }
            return "Algo a fallado, socio o actividad inexistentes";
        }

        public Actividad buscarActividad(string nombre) 
        {
            return actividades.Find(a => a.Nombre == nombre);
        }
        
        //para obtener lalista de actividades
        public List<Actividad> ObtenerActividades()
        {
            return actividades;
        }
    }
}
