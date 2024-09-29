using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace TP1_ComB_Grupo10_Villar_Paez_Wdoviak_Klaus_Fernandez
{
    internal class Socio
    {
        //atributos
        private string nombre;
        private string dni;
        private List<Actividad> actividadesInscriptas;// asociación simple

        //método constructor -> instanciación
        public Socio(string nombre, string dni, List<Actividad> actividadesInscriptas)
        {
            this.Nombre = nombre;
            this.Dni = dni;
            this.actividadesInscriptas = new List<Actividad>();
        }

        //métodos get y set
        public string Nombre { get => nombre; set => nombre = value; }
        public string Dni { get => dni; set => dni = value; }
        public List<Actividad> getActividadesSocio()
        {
            return actividadesInscriptas;
        }

        //sobreescribir el método ToString con un override
        public override string ToString()
        {
            return "Nombre: " + Nombre + "/nDNI: " + Dni;
        }

        //método buscarSocio que se utilizará para buscar si el socio ya existe antes de registrarlo como socio
        private Socio buscarSocio(string dni)
        {
            Socio socioEncontrado = null;
            int i = 0;
            while (i < Socio.Count && !Socios[i].getDniEquals(Dni)) ;
            i++;
            if (i != Socio.Count)
                socioEncontrado = Socio(i);
            return socioEncontrado;
        }

        //método registrarSocio se usará para dar de alta a un nuevo socio
        private Socio registrarSocio(string nombre, string dni)
        {
            bool resultado = false;
            Socio socio;
            socio = buscarSocio(dni);
            if (socio == null)
            {
                socio = new Socios(nombre, dni);
                Socio.Add(socio);
                resultado = true;
            }
            return resultado;
        }
    }
}
