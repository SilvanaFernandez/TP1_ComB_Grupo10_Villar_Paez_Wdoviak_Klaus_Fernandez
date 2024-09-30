using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TP1_ComB_Grupo10_Villar_Paez_Wdoviak_Klaus_Fernandez
{
    class Program
    {
        static void Main(string[] args)
        {
            ClubDeportivo clubDeportivo = new ClubDeportivo();

            ClubDeportivo club = new ClubDeportivo();

            //creamos actividades
            club.agregarActividad("pesas", 4);
            club.agregarActividad("calistenia", 10);
            club.agregarActividad("natacion", 10);
            club.agregarActividad("running", 10);
            club.agregarActividad("yudo", 3);

            // registramos un par de socios
            Console.WriteLine(club.registrarSocio("pedro", "11111"));
            Console.WriteLine(club.registrarSocio("raul", "22222"));
            Console.WriteLine(club.registrarSocio("juan", "33333"));
            Console.WriteLine(club.registrarSocio("jesus", "44444"));
            Console.WriteLine(club.registrarSocio("ramon", "55555"));
            Console.WriteLine(club.registrarSocio("susana", "66666"));
            Console.WriteLine(club.registrarSocio("sofia", "77777"));
            Console.WriteLine(club.registrarSocio("andrea", "88888"));
            Console.WriteLine(club.registrarSocio("romina", "99999"));

            // Inscribimos socios en actividades
            Console.WriteLine(club.inscribirActividad("pesas", "11111"));
            Console.WriteLine(club.inscribirActividad("pesas", "22222"));
            Console.WriteLine(club.inscribirActividad("pesas", "33333"));
            Console.WriteLine(club.inscribirActividad("pesas", "44444"));
            Console.WriteLine(club.inscribirActividad("pesas", "55555"));
            Console.WriteLine(club.inscribirActividad("calistenia", "66666"));
            Console.WriteLine(club.inscribirActividad("calistenia", "77777"));
            Console.WriteLine(club.inscribirActividad("natacion", "88888"));
            Console.WriteLine(club.inscribirActividad("natacion", "99999"));
            Console.WriteLine(club.inscribirActividad("calistenia", "99999"));
            Console.WriteLine(club.inscribirActividad("running", "99999"));
            Console.WriteLine(club.inscribirActividad("yudo", "99999"));

        }
    }
}