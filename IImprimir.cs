using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOO_Cine
{
    interface IImprimir
    {
        // Metodos para imprimir los detalles de la venta
        string ImprimirCliente(); 
        string ImprimirFormato();
    }
}
