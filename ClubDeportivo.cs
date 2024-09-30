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

        //método constructor
        public ClubDeportivo(List<Socio> socios, List<Actividad> actividades)
        {
            this.socios = socios;
            this.actividades = actividades;
        }

        //métodos get y set
        internal List<Socio> Socios { get => socios; set => socios = value; }
        internal List<Actividad> Actividades { get => actividades; set => actividades = value; }

        //intanciación
        public ClubDeportivo()
        {
            socios = new List<Socio>();
            actividades = new List<Actividad>();
        }

        //método buscar socio si existe
        private Socio buscarSocio(string id)
        {
            Socio socioBuscascado = null;
            int i = 0;
            while (i < socios.Count && !socios[i].Id.Equals(id))
                i++;
            if (i != Socios.Count)
                socioBuscascado = Socios[i];
            return socioBuscascado;
        }

        // método registrar socio usando el método buscarSocio
        public string registrarSocio(string nombre, string id)
        {
            var socio = buscarSocio(id); //si el socio no existe en la var socio se guarda null y entra en el condicional if para registrarlo
            if (socio == null)
            {
                socio = new Socio(nombre, id);
                socios.Add(socio);
                return "SOCIO REGISTRADO";
            }
            else // si la var socio no es null es porque se encontró el socio ya registrado
            {
                return "EL SOCIO YA ESTÁ REGISTRADO";
            }
        }

        //Metodo que utilizaremos posteriormente para buscar la actividad
        public Actividad buscarActividad(string nombre)
        {
            return actividades.Find(a => a.NombreAct == nombre);
        }


        //Definimos metodo para inscribir un socio a una actividad
        public string inscribirActividad(string nombreActividad, string dni)
        {
            Actividad actividad = buscarActividad(nombreActividad);
            Socio socio = buscarSocio(dni);

            if (actividad == null)
            {
                return "Actividad no encontrada";
            }
            if (socio == null)
            {
                return "Socio no encontrado";
            }

            //ahora verificamos si el socio esta inscripto o no, en 3 actividades
            if (socio.ActividadesIncriptas.Count >= 3)
            {
                return "Maximo número de actividades alzandas [3]";
            }

            //verificamos el cupo disponible de la actividad
            if (actividad.CupoDisponible <= 0)
            {
                return "No quedan cupos disponibles";
            }

            if (actividad != null && socio != null && actividad.CupoDisponible >= 1)
            {
                socio.ActividadesIncriptas.Add(actividad);
                actividad.CupoDisponible--;//reduccimos en 1 el cupo de la actividad
                return "Inscripción éxitosa";
            }
            return "Socio o actividad no encontrados";
        }

        //definimos metodo para agregar nuevas actividades
        public void agregarActividad(string nombre, int cupoDisponible)
        {
            actividades.Add(new Actividad(nombre, cupoDisponible));
        }
    }
}
