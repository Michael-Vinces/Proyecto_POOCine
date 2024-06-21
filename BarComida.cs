using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOO_Cine
{
    class BarComida
    {
        // Propiedades de la clase
        public string Comestible { get; set; }
        public double ValorUnitario { get; set; }
        public int Cantidad { get; set; }

            // Propiedades que eliminan los productos ingresados
        public int EliminarCantidad { get; set; }
        public string EliminarComestible { get; set; }
        public double EliminarPrecio { get; set; }
        
            // Propiedad dependiente del formato de la pelicula
        public string Aperitivo { get; set; }
       


        // Constructor de la clase
        public BarComida()
        {

        }

        // Metodos de la clase
    }
}
