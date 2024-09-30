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
        private string id;
        private List<Actividad> actividadesInscriptas;// asociación simple

        //método constructor
        public Socio(string nombre, string id)
        {
            this.Nombre = nombre;
            this.Id = id;
            actividadesInscriptas = new List<Actividad>();
        }

        //métodos get y set
        public string Nombre { get => nombre; set => nombre = value; }
        public string Id { get => id; set => id = value; }
        internal List<Actividad> ActividadesIncriptas { get => actividadesInscriptas; set => actividadesInscriptas = value; }
        //sobreescribir el método ToString con un override
        public override string ToString()
        {
            return "Nombre: " + Nombre + "\nDNI: " + Id + "\nActividades que realiza: " + ActividadesIncriptas;
        }               
    }
}
