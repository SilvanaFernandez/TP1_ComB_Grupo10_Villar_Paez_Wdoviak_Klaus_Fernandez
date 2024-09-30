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
        public string registrarSocio(string nombre, string id, Actividad actividad)
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
    }
}
