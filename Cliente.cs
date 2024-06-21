using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOO_Cine
{
    class Cliente:Persona, IImprimir
    {
        // Propiedades de la clase
            
            //Propiedad de Apellidos y Nombres heredadas desde la clase persona


        // Constructor de la clase
        public Cliente()
        {

        }

        public string ImprimirCliente()
        {
            return "\t\t\t-----------------------------------------------------------------" +
                "\n\t\t\t    Nombres  \t\t|\t" + this.Nombres +
                "\n\t\t\t    Apellidos\t\t|\t" + this.Apellidos +
                "\n\t\t\t-----------------------------------------------------------------";

        }

        public string ImprimirFormato()
        {
            throw new NotImplementedException();
        }

        // Metodos de la clase
    }
}
