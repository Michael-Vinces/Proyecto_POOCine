using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOO_Cine
{
    // Clase Abstracta
    public abstract class Formato
    {
        // Propiedades de la clase

        public string formato { get; set; }
        public int EscogerFormato { get; set; }
        
        //Propiedad dependiente del formato escogido
        public string Accesorio { get; set; }

        // Constructor de la clase
        public Formato()
        {

        }

        // Metodos de la clase
        public abstract string MostrarFormato();
        public abstract string ImprimirFormato();
    }
}
