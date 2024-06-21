using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOO_Cine
{
    class Formato2D : Formato, IFormato, IImprimir
    {
        // Propiedades de la clase

            //Propiedad de formato y Accesorio heredadas desde la clase Formato

        // Constructor de la clase
        public Formato2D()
        {
            this.formato = "2D";
            this.Accesorio = "Sin accesorio";
        }

        // Metodos de la clase
        public string ImprimirCliente()
        {
            throw new NotImplementedException();
        }

        public override string MostrarFormato()
        {
            return "\t\t********************************************************************************" +
                "\n\t\t                              FORMATO DE LA PELÍCULA                            " +
                "\n\t\t********************************************************************************" +
                "\n\t\t----------------------------------     2D    -----------------------------------" +
                "\n\t\t********************************************************************************";
        }
        public override string ImprimirFormato()
        {
            return "\t\t\t-----------------------------------------------------------------" +
                "\n\t\t\t    Formato    \t\t|\t" + this.formato +
                "\n\t\t\t    Accesorio  \t\t|\t" + this.Accesorio;
        }
    }
}
