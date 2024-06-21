using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOO_Cine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            Pelicula pelicula = new Pelicula();    // Instancia de la clase Pelicula
            Cliente cliente = new Cliente();       // Instancia de la clase Cliente
            Formato2D formato2D = new Formato2D(); // Instancia de la clase Formato2D
            Formato3D formato3D = new Formato3D(); // Instancia de la clase Formate3D
            BarComida barComida = new BarComida(); // Instancia de la clase BarComida
            Sala sala = new Sala();                // Instancia de la clase Sala


            // Instancias para las 6 salas
            Sala sala1 = new Sala();
            Sala sala2 = new Sala();
            Sala sala3 = new Sala();
            Sala sala4 = new Sala();
            Sala sala5 = new Sala();
            Sala sala6 = new Sala();

            // Definicion de propiedades de las salas 2D
            
       	    sala1.Asientos = new int[4, 4];
            sala2.Asientos = new int[4, 4];
            sala3.Asientos = new int[4, 4];

            // Definicion de propiedades de las salas 3D

            sala4.Asientos = new int[5, 5];
            sala5.Asientos = new int[5, 5];
            sala6.Asientos = new int[5, 5];

            // Instancias para las 3 peliculas
            Pelicula pelicula1 = new Pelicula();           
            Pelicula pelicula2 = new Pelicula();
            Pelicula pelicula3 = new Pelicula();

            // Definicion de propiedades de las peliculas
            pelicula1.Titulo = "Venom: Habrá Matanza";
            pelicula2.Titulo = "Snake Eyes: El origen";            
            pelicula3.Titulo = "Halloween Kills";


            // Lista de los consumibles del Bar
            List<string> Aperitivos = new List<string>();

            Aperitivos.Add("Canguil");
            Aperitivos.Add("Hot-Dog");
            Aperitivos.Add("Gaseosa");
            Aperitivos.Add("Doritos");

            // Lista de los Precios de los consumibles del Bar

            List<double> precios = new List<double>();

            precios.Add(2.99);
            precios.Add(2.49);
            precios.Add(1.99);
            precios.Add(1.75);

            // Listas que guarda los pedidos del cliente
            List<string> VentaProducto = new List<string>();
            List<double> VentaPrecio = new List<double>();

            bool acceso = false;

            while (true)
            {

                if (acceso == false)
                {
                    menu();
                }
            }

            void menu()
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                int opcion;

                while (true)

                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\t\t********************************************************************************");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("\t\t**********************            CINEMA BONVITEJ          *********************");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\t\t********************************************************************************");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("\t\t~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine("\t\t*    1. Aperitivos Disponibles                                                 *");
                    Console.WriteLine("\t\t*    2. Escoger Pelicula                                                       *");
                    Console.WriteLine("\t\t*    3. Agregar Consumible                                                     *");
                    Console.WriteLine("\t\t*    4. Eliminar Consumible                                                    *");
                    Console.WriteLine("\t\t*    5. Lista de Comestibles agregados                                         *");
                    Console.WriteLine("\t\t*    6. Salir                                                                  *");
                    Console.WriteLine("\t\t~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine("\t\t*                                                                              *");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\t\t********************************************************************************");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\t\t     Elige una opción : ");
                    opcion = Int32.Parse(Console.ReadLine());

                    Console.Clear();

                    switch (opcion)
                    {
                        case 1:
                            
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("\t\t********************************************************************************");
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("\t\t**********************          Lista de Productos         *********************");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("\t\t********************************************************************************");
                            Console.ForegroundColor = ConsoleColor.Black;

                            //Este ciclo permite imprimir por pantalla la lista de los consumibles disponibles
                            for (int i = 0; i < Aperitivos.Count; i++)
                            {
                                string ImprimirAper = Aperitivos[i];
                                Console.Write("\t\t*  " + ImprimirAper + "");

                                for (int n = 0; n < precios.Count; n++) 
                                {
                                    double ImprimirPrecio = precios[i];
                                    Console.Write("---------$" + ImprimirPrecio + "\n");

                                    break;
                                }
                            }
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("\t\t~~~~~~~~~~~~~~~          Presione enter para continuar           ~~~~~~~~~~~~~~~");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 2:
                            bool accesoVenta = true;

                            while (true)
                            {
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("\t\t********************************************************************************");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("\t\t*******************               CINEMA BONVITEJ           ********************");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("\t\t********************************************************************************");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("\t\t~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                                Console.WriteLine("\t\t                                Escoja la pelicula                              ");
                                Console.WriteLine("\t\t~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                                Console.WriteLine("\t\t*    1.  " + pelicula1.Titulo + "                                                  *");
                                Console.WriteLine("\t\t*    2.  " + pelicula2.Titulo + "                                                 *");
                                Console.WriteLine("\t\t*    3.  " + pelicula3.Titulo + "                                                       *");
                                Console.WriteLine("\t\t*    6.  Salir                                                                 *");
                                Console.WriteLine("\t\t*                                                                              *");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("\t\t********************************************************************************");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write("\t\t     Elige una opción : ");
                                int opc = Int32.Parse(Console.ReadLine());
                                Console.Clear();
                                string ImprimirAsiento;
                                switch (opc)
                                {
                                    case 1:
                                        do
                                        {

                                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                                            Console.WriteLine("\t\t********************************************************************************");
                                            Console.ForegroundColor = ConsoleColor.Black;
                                            Console.WriteLine("\t\t********************          " + pelicula1.Titulo + "         *********************");
                                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                                            Console.WriteLine("\t\t********************************************************************************\n");
                                            // Escoger Formato
                                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                                            Console.WriteLine("\t\t********************************************************************************");
                                            Console.ForegroundColor = ConsoleColor.Black;
                                            Console.WriteLine("\t\t********************            Escoja el Formato          *********************");
                                            Console.WriteLine("\t\t**   1. Formato 2D                                                            **");
                                            Console.WriteLine("\t\t**   2. Formato 3D                                                            **");
                                            Console.WriteLine("\t\t********************************************************************************");
                                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                                            Console.Write("\t\t********************************************************************************\n\t\t  ");
                                            Console.ForegroundColor = ConsoleColor.Black;
                                            formato2D.EscogerFormato = int.Parse(Console.ReadLine()); // Permite escoger la opcion del formato que desee e cliente
                                            if (formato2D.EscogerFormato != 1 && formato2D.EscogerFormato != 2) // Valida las dos opciones disponibles
                                            {
                                                Console.Clear();
                                            }
                                        } while (formato2D.EscogerFormato != 1 && formato2D.EscogerFormato != 2);// Repite si marca algo que no es
                                        Console.Clear();
                                        if (formato2D.EscogerFormato == 1) // Si es 2D Entra al IF
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.WriteLine("\t\t********************************************************************************");
                                            Console.ForegroundColor = ConsoleColor.Black;
                                            Console.WriteLine(formato2D.MostrarFormato()); // Muestra el formato escogido de la pelicula
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.WriteLine("\t\t********************************************************************************\n");
                                            Console.Clear();
                                            Console.BackgroundColor = ConsoleColor.Black;

                                            // Escoger Asiento
                                            ImprimirAsiento=ReservarAsientos(sala1.Asientos, 4, 4);

                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            Console.WriteLine("--------------------------------------------------------------------------------");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("~~~~~~~~~~~~~~~          Presione enter para continuar           ~~~~~~~~~~~~~~~");
                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            Console.WriteLine("--------------------------------------------------------------------------------");
                                            Console.ReadKey();
                                            Console.Clear();
                                            Console.BackgroundColor = ConsoleColor.Gray;
                                            barComida.Aperitivo = "Canguil Pequeño";// Declaro el aperitivo gratuito
                                            sala.NumeroSala = 1;              // Declaro el numero de la sala 
                                        }
                                        else // Si es 3D entra al else
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.WriteLine("\t\t********************************************************************************");
                                            Console.ForegroundColor = ConsoleColor.Black;
                                            Console.WriteLine(formato3D.MostrarFormato()); // Muestra el formato escogido de la pelicula
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            
                                            Console.WriteLine("\t\t********************************************************************************\n");                                           
                                            Console.Clear();
                                            Console.BackgroundColor = ConsoleColor.Black;

                                            // Escoger Asiento
                                            ImprimirAsiento=ReservarAsientos(sala4.Asientos, 5, 5);
                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            Console.WriteLine("--------------------------------------------------------------------------------");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("~~~~~~~~~~~~~~~          Presione enter para continuar           ~~~~~~~~~~~~~~~");
                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            Console.WriteLine("--------------------------------------------------------------------------------");
                                            Console.ReadKey();
                                            Console.Clear();
                                            Console.BackgroundColor = ConsoleColor.Gray;
                                            barComida.Aperitivo = "Maní Cris";// Declaro el aperitivo gratuito
                                            sala.NumeroSala = 4;              // Declaro el numero de la sala 
                                        }
                                        Console.Clear();

                                        // Datos del Cliente
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.WriteLine("\t\t********************************************************************************");
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.WriteLine("\t\t**********************          Datos del cliente          *********************");
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.WriteLine("\t\t********************************************************************************");
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.Write("\t\t*  Ingrese los nombres del cliente: \n\t\t  ");
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        cliente.Nombres = Console.ReadLine();    // Permite el ingreso de los nombres del cliente
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.Write("\t\t* Ingrese los apellidos del cliente: \n\t\t  ");
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        cliente.Apellidos = Console.ReadLine();  //Permite el ingreso de los apellidos del cliente
                                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.WriteLine("\t\t~~~~~~~~~~~~~~~          Presione enter para continuar           ~~~~~~~~~~~~~~~");
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                        Console.ReadKey();
                                        Console.Clear();

                                        // Imprimir Detalles de la Venta
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.WriteLine("\t\t\t-----------------------------------------------------------------");
                                        Console.WriteLine("\t\t\t----------------------      Sala " + sala.NumeroSala + "     --------------------------");
                                        Console.WriteLine("\t\t\t------------------  " + pelicula1.Titulo + "   ----------------------");
                                        Console.WriteLine(cliente.ImprimirCliente());// Muestra los datos del cliente

                                        Console.WriteLine("\t\t\t-----------------------------------------------------------------\n");

                                        Console.WriteLine(ImprimirAsiento);
                                        Console.WriteLine("\t\t\t-----------------------------------------------------------------");
                                        if (formato2D.EscogerFormato == 1)
                                        {
                                            Console.WriteLine(formato2D.ImprimirFormato());
                                            Console.WriteLine("\t\t\t    Aperitivo  \t\t|\t" + barComida.Aperitivo);
                                            Console.WriteLine("\t\t\t-----------------------------------------------------------------");
                                        }
                                        else
                                        {
                                            Console.WriteLine(formato3D.ImprimirFormato());
                                            Console.WriteLine("\t\t\t    Aperitivo  \t\t|\t" + barComida.Aperitivo);
                                            Console.WriteLine("\t\t\t-----------------------------------------------------------------");
                                        }
                                         for (int i = 0; i < VentaProducto.Count; i++)
                                        {
                                            Console.WriteLine("\t\t\t-----------------------------------------------------------------");
                                            string ImprimirAper = VentaProducto[i];
                                            Console.Write("\t\t\t|\t" + (i + 1) + ". " + ImprimirAper + " ");

                                            for (int n = 0; n < VentaPrecio.Count; n++)
                                            {
                                                double ImprimirPrecio = VentaPrecio[i];
                                                Console.Write("\t$" + ImprimirPrecio + "\t\t\t\t\t|\n");
                                                break;
                                            }

                                        }
                                        Console.WriteLine("\t\t\t-----------------------------------------------------------------\n\n");
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.WriteLine("\t\t~~~~~~~~~~~~         Presione enter para realiar otra venta         ~~~~~~~~~~~~");
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                        Console.ReadKey();
                                        VentaProducto.Clear();
                                        VentaPrecio.Clear();
                                        Console.Clear();                                        
                                        break;
                                    case 2:
                                        do{
                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            Console.WriteLine("\t\t********************************************************************************");
                                            Console.ForegroundColor = ConsoleColor.Black;
                                            Console.WriteLine("\t\t*******************          " + pelicula2.Titulo + "         *********************");
                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            Console.WriteLine("\t\t********************************************************************************");
                                            Console.ForegroundColor = ConsoleColor.Black;

                                            // Escoger Formato
                                            
                                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                                            Console.WriteLine("\t\t********************************************************************************");
                                            Console.ForegroundColor = ConsoleColor.Black;
                                            Console.WriteLine("\t\t********************            Escoja el Formato          *********************");
                                            Console.WriteLine("\t\t**   1. Formato 2D                                                            **");
                                            Console.WriteLine("\t\t**   2. Formato 3D                                                            **");
                                            Console.WriteLine("\t\t********************************************************************************");
                                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                                            Console.Write("\t\t********************************************************************************\n\t\t  ");
                                            Console.ForegroundColor = ConsoleColor.Black;
                                            formato2D.EscogerFormato = int.Parse(Console.ReadLine()); // Permite escoger la opcion del formato que desee e cliente
                                            if (formato2D.EscogerFormato != 1 && formato2D.EscogerFormato != 2) // Valida las dos opciones disponibles
                                            {
                                                Console.Clear();
                                            }
                                        } while (formato2D.EscogerFormato != 1 && formato2D.EscogerFormato != 2) ;// Repite si marca algo que no es
                                        Console.Clear();
                                        if (formato2D.EscogerFormato == 1) // Si es 2D Entra al IF
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.WriteLine("\t\t********************************************************************************");
                                            Console.ForegroundColor = ConsoleColor.Black;
                                            Console.WriteLine(formato2D.MostrarFormato()); // Muestra el formato escogido de la pelicula
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.WriteLine("\t\t********************************************************************************\n");
                                            Console.Clear();
                                            Console.BackgroundColor = ConsoleColor.Black;

                                            // Escoger Asiento
                                            ImprimirAsiento=ReservarAsientos(sala2.Asientos, 4, 4);

                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            Console.WriteLine("--------------------------------------------------------------------------------");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("~~~~~~~~~~~~~~~          Presione enter para continuar           ~~~~~~~~~~~~~~~");
                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            Console.WriteLine("--------------------------------------------------------------------------------");
                                            Console.ReadKey();
                                            Console.Clear();
                                            Console.BackgroundColor = ConsoleColor.Gray;
                                            barComida.Aperitivo = "Canguil Pequeño";// Declaro el aperitivo gratuito
                                            sala.NumeroSala = 2;              // Declaro el numero de la sala 
                                        }
                                        else // Si es 3D entra al else
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.WriteLine("\t\t********************************************************************************");
                                            Console.ForegroundColor = ConsoleColor.Black;
                                            Console.WriteLine(formato3D.MostrarFormato()); // Muestra el formato escogido de la pelicula
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.WriteLine("\t\t********************************************************************************\n");
                                            Console.Clear();
                                            Console.BackgroundColor = ConsoleColor.Black;

                                            // Escoger Asiento
                                            ImprimirAsiento=ReservarAsientos(sala5.Asientos, 5, 5);

                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            Console.WriteLine("--------------------------------------------------------------------------------");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("~~~~~~~~~~~~~~~          Presione enter para continuar           ~~~~~~~~~~~~~~~");
                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            Console.WriteLine("--------------------------------------------------------------------------------");
                                            Console.ReadKey();
                                            Console.Clear();
                                            Console.BackgroundColor = ConsoleColor.Gray;
                                            barComida.Aperitivo = "Maní Cris";// Declaro el aperitivo gratuito
                                            sala.NumeroSala = 5;              // Declaro el numero de la sala 
                                        }
                                        Console.Clear();

                                        // Datos del Cliente
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.WriteLine("\t\t********************************************************************************");
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.WriteLine("\t\t**********************          Datos del cliente          *********************");
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.WriteLine("\t\t********************************************************************************");
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.Write("\t\t*  Ingrese los nombres del cliente: \n\t\t  ");
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        cliente.Nombres = Console.ReadLine();    // Permite el ingreso de los nombres del cliente
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.Write("\t\t* Ingrese los apellidos del cliente: \n\t\t  ");
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        cliente.Apellidos = Console.ReadLine();  //Permite el ingreso de los apellidos del cliente
                                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.WriteLine("\t\t~~~~~~~~~~~~~~~          Presione enter para continuar           ~~~~~~~~~~~~~~~");
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                        Console.ReadKey();
                                        Console.Clear();

                                        // Imprimir Detalles de la Venta   
                                       
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.WriteLine("\t\t\t-----------------------------------------------------------------");
                                        Console.WriteLine("\t\t\t----------------------      Sala " + sala.NumeroSala + "     --------------------------");
                                        Console.WriteLine("\t\t\t------------------  " + pelicula2.Titulo + "   ---------------------");
                                        Console.WriteLine(cliente.ImprimirCliente());// Muestra los datos del cliente
                                        Console.WriteLine("\t\t\t-----------------------------------------------------------------\n");
                                        Console.WriteLine(ImprimirAsiento);
                                        Console.WriteLine("\t\t\t-----------------------------------------------------------------");
                                        if (formato2D.EscogerFormato == 1)
                                        {
                                            Console.WriteLine(formato2D.ImprimirFormato());
                                            Console.WriteLine("\t\t\t    Aperitivo  \t\t|\t" + barComida.Aperitivo);
                                            Console.WriteLine("\t\t\t-----------------------------------------------------------------");
                                        }
                                        else
                                        {
                                            Console.WriteLine(formato3D.ImprimirFormato());
                                            Console.WriteLine("\t\t\t    Aperitivo  \t\t|\t" + barComida.Aperitivo);
                                            Console.WriteLine("\t\t\t-----------------------------------------------------------------");
                                        }
                                         for (int i = 0; i < VentaProducto.Count; i++)
                                        {
                                            Console.WriteLine("\t\t\t-----------------------------------------------------------------");
                                            string ImprimirAper = VentaProducto[i];
                                            Console.Write("\t\t\t|\t" + (i + 1) + ". " + ImprimirAper + " ");

                                            for (int n = 0; n < VentaPrecio.Count; n++)
                                            {
                                                double ImprimirPrecio = VentaPrecio[i];
                                                Console.Write("\t$" + ImprimirPrecio + "\t\t\t\t\t|\n");
                                                break;
                                            }
                                        }
                                        Console.WriteLine("\t\t\t-----------------------------------------------------------------\n\n");
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.WriteLine("\t\t~~~~~~~~~~~~         Presione enter para realiar otra venta         ~~~~~~~~~~~~");
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                        Console.ReadKey();
                                        VentaProducto.Clear();
                                        VentaPrecio.Clear();
                                        Console.Clear();                                        
                                        break;
                                    case 3:
                                        do{
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("\t\t********************************************************************************");
                                            Console.ForegroundColor = ConsoleColor.Black;
                                            Console.WriteLine("\t\t*******************             " + pelicula3.Titulo + "            *********************");
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("\t\t********************************************************************************");
                                            Console.ForegroundColor = ConsoleColor.Black;

                                            // Escoger Formato
                                            
                                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                                            Console.WriteLine("\t\t********************************************************************************");
                                            Console.ForegroundColor = ConsoleColor.Black;
                                            Console.WriteLine("\t\t********************            Escoja el Formato          *********************");
                                            Console.WriteLine("\t\t**   1. Formato 2D                                                            **");
                                            Console.WriteLine("\t\t**   2. Formato 3D                                                            **");
                                            Console.WriteLine("\t\t********************************************************************************");
                                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                                            Console.Write("\t\t********************************************************************************\n\t\t  ");
                                            Console.ForegroundColor = ConsoleColor.Black;
                                            formato2D.EscogerFormato = int.Parse(Console.ReadLine()); // Permite escoger la opcion del formato que desee e cliente
                                            if (formato2D.EscogerFormato != 1 && formato2D.EscogerFormato != 2) // Valida las dos opciones disponibles
                                            {
                                                Console.Clear();
                                            }
                                        } while (formato2D.EscogerFormato != 1 && formato2D.EscogerFormato != 2) ;// Repite si marca algo que no es
                                        Console.Clear();
                                        if (formato2D.EscogerFormato == 1) // Si es 2D Entra al IF
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.WriteLine("\t\t********************************************************************************");
                                            Console.ForegroundColor = ConsoleColor.Black;
                                            Console.WriteLine(formato2D.MostrarFormato()); // Muestra el formato escogido de la pelicula
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.WriteLine("\t\t********************************************************************************\n");
                                            Console.Clear();
                                            Console.BackgroundColor = ConsoleColor.Black;

                                            // Escoger Asiento
                                            ImprimirAsiento=ReservarAsientos(sala3.Asientos, 4, 4);

                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            Console.WriteLine("--------------------------------------------------------------------------------");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("~~~~~~~~~~~~~~~          Presione enter para continuar           ~~~~~~~~~~~~~~~");
                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            Console.WriteLine("--------------------------------------------------------------------------------");
                                            Console.ReadKey();
                                            Console.Clear();
                                            Console.BackgroundColor = ConsoleColor.Gray;
                                            barComida.Aperitivo = "Canguil Pequeño";// Declaro el aperitivo gratuito
                                            sala.NumeroSala = 3;              // Declaro el numero de la sala 
                                        }
                                        else // Si es 3D entra al else
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.WriteLine("\t\t********************************************************************************");
                                            Console.ForegroundColor = ConsoleColor.Black;
                                            Console.WriteLine(formato3D.MostrarFormato()); // Muestra el formato escogido de la pelicula
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.WriteLine("\t\t********************************************************************************\n");
                                            Console.Clear();
                                            Console.BackgroundColor = ConsoleColor.Black;

                                            // Escoger Asiento
                                            ImprimirAsiento=ReservarAsientos(sala6.Asientos, 5, 5);

                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            Console.WriteLine("--------------------------------------------------------------------------------");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("~~~~~~~~~~~~~~~          Presione enter para continuar           ~~~~~~~~~~~~~~~");
                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            Console.WriteLine("--------------------------------------------------------------------------------");
                                            Console.ReadKey();
                                            Console.Clear();
                                            Console.BackgroundColor = ConsoleColor.Gray;
                                            barComida.Aperitivo = "Maní Cris";// Declaro el aperitivo gratuito
                                            sala.NumeroSala = 6;              // Declaro el numero de la sala 
                                        }
                                        Console.Clear();

                                        // Datos del Cliente
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.WriteLine("\t\t********************************************************************************");
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.WriteLine("\t\t**********************          Datos del cliente          *********************");
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.WriteLine("\t\t********************************************************************************");
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.Write("\t\t*  Ingrese los nombres del cliente: \n\t\t  ");
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        cliente.Nombres = Console.ReadLine();    // Permite el ingreso de los nombres del cliente
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.Write("\t\t* Ingrese los apellidos del cliente: \n\t\t  ");
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        cliente.Apellidos = Console.ReadLine();  //Permite el ingreso de los apellidos del cliente
                                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.WriteLine("\t\t~~~~~~~~~~~~~~~          Presione enter para continuar           ~~~~~~~~~~~~~~~");
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                        Console.ReadKey();
                                        Console.Clear();

                                        // Imprimir Detalles de la Venta

                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.WriteLine("\t\t\t-----------------------------------------------------------------");
                                        Console.WriteLine("\t\t\t------------------------      Sala " + sala.NumeroSala + "     --------------------------");
                                        Console.WriteLine("\t\t\t------------------  " + pelicula3.Titulo + "   ----------------------");
                                        Console.WriteLine(cliente.ImprimirCliente());// Muestra los datos del cliente
                                        Console.WriteLine("\t\t\t-----------------------------------------------------------------\n");
                                        Console.WriteLine(ImprimirAsiento);
                                        Console.WriteLine("\t\t\t-----------------------------------------------------------------");
                                        if (formato2D.EscogerFormato == 1)
                                        {
                                            Console.WriteLine(formato2D.ImprimirFormato());
                                            Console.WriteLine("\t\t\t    Aperitivo  \t\t|\t" + barComida.Aperitivo);
                                            Console.WriteLine("\t\t\t-----------------------------------------------------------------");
                                        }
                                        else
                                        {
                                            Console.WriteLine(formato3D.ImprimirFormato());
                                            Console.WriteLine("\t\t\t    Aperitivo  \t\t|\t" + barComida.Aperitivo);
                                            Console.WriteLine("\t\t\t-----------------------------------------------------------------");
                                        }
                                         for (int i = 0; i < VentaProducto.Count; i++)
                                        {
                                            Console.WriteLine("\t\t\t-----------------------------------------------------------------");
                                            string ImprimirAper = VentaProducto[i];
                                            Console.Write("\t\t\t|\t" + (i + 1) + ". " + ImprimirAper + " ");

                                            for (int n = 0; n < VentaPrecio.Count; n++)
                                            {
                                                double ImprimirPrecio = VentaPrecio[i];
                                                Console.Write("\t$" + ImprimirPrecio + "\t\t\t\t\t|\n");
                                                break;
                                            }
                                        }
                                        Console.WriteLine("\t\t\t-----------------------------------------------------------------\n\n");
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.WriteLine("\t\t~~~~~~~~~~~~         Presione enter para realiar otra venta         ~~~~~~~~~~~~");
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                        Console.ReadKey();
                                        VentaProducto.Clear();
                                        VentaPrecio.Clear();
                                        Console.Clear();                                        
                                        break;
                                    default:
                                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                                        Console.WriteLine("\t\t********************************************************************************");
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.WriteLine("\t\t****************         Seleccione una opcion valida           ****************");
                                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                                        Console.WriteLine("\t\t********************************************************************************");
                                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                                        Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.WriteLine("\t\t~~~~~~~~~~~~~~~          Presione enter para continuar           ~~~~~~~~~~~~~~~");
                                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                                        Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                }
                                if (accesoVenta == false)
                                {
                                    break;
                                }
                                break;
                            }
                            break;

                        case 3:
                            
			                Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("\t\t********************************************************************************");
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("\t\t**********************          Lista de Productos         *********************");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("\t\t********************************************************************************");
                            Console.ForegroundColor = ConsoleColor.Black;

                            for (int i = 0; i < Aperitivos.Count; i++) //Este ciclo permite imprimir por pantalla la lista de los consumibles disponibles
                            {
                                string ImprimirAper = Aperitivos[i];
                                Console.Write("\t\t*  " + (i + 1) + ". " + ImprimirAper + " ");

                                for (int n = 0; n < precios.Count; n++)
                                {
                                    double ImprimirPrecio = precios[i];
                                    Console.Write("\t$" + ImprimirPrecio + "\n");
                                    break;
                                }
                            }

                            // Se inicializan las variables

                            barComida.Comestible = "";
                            barComida.ValorUnitario = 0;
                            int agg = 0;

                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("\t\t********************************************************************************");
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("\t\t**********************          Elija los productos         ********************");
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("\t\t********************************************************************************");
                            Console.ForegroundColor = ConsoleColor.Black;

                            while (agg <= 0 || agg >= Aperitivos.Count + 1)
                            {
                                Console.Write("\t\t  Elige el producto: ");
                                agg = Int32.Parse(Console.ReadLine());
                            }

                            for (int i = 0; i < agg; i++)   //Este ciclo permite imprimir por pantalla la lista de los consumibles disponibles
                            {
                                barComida.Comestible = Aperitivos[i];

                                for (int n = 0; n < agg; n++)
                                {

                                    barComida.ValorUnitario = precios[i];
                                    break;

                                }

                            }
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("\t\t********************************************************************************");
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("\t\t***************         Ingrese la cantidad que requiera         ***************");
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("\t\t********************************************************************************");
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("\t\t" + barComida.Comestible + "~~~~~~~~~~~~~~~$" + barComida.ValorUnitario);
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("\t\t********************************************************************************");
                            barComida.Cantidad = 0;
                            while (barComida.Cantidad <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write("\t\tIngrese el número de unidades : ");
                                barComida.Cantidad = Int32.Parse(Console.ReadLine());
                            }
                            for (int i = 0; i < barComida.Cantidad; i++)
                            {
                                VentaProducto.Add(barComida.Comestible); //Se agrega el producto escogido a la lista de productos
                                VentaPrecio.Add(barComida.ValorUnitario); //Se agrega el valor unitario del producto escogido a la lista de precios
                            }
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("\t\t********************************************************************************");
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("\t\t**********************          Operacion Exitosa         **********************");
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("\t\t********************************************************************************");
                            Console.ForegroundColor = ConsoleColor.Black;
                            if (barComida.Cantidad == 1)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("\t\t  Se ha agregado correctamente " + barComida.Comestible + " cuyo valor es $" + barComida.ValorUnitario);
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                Console.ForegroundColor = ConsoleColor.Black;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("\t\tSe han agregado correctamente " + barComida.Cantidad + " " + barComida.Comestible + " cuyo valor es $" + barComida.ValorUnitario + " c/u");
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                Console.ForegroundColor = ConsoleColor.Black;
                            }
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("\t\t~~~~~~~~~~~~~~~          Presione enter para continuar          ~~~~~~~~~~~~~~~");
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 4:
                            // Este caso le permite al usuario poder eliminar los productos que el cliente ya no desee
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("\t\t********************************************************************************");
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("\t\t*****************         Elimine el producto que desee         ****************");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("\t\t********************************************************************************");
                            Console.ForegroundColor = ConsoleColor.Black;
                            // En caso de no haber un producto en la lista, ingresa al if y muestra que la lista esta vacia
                            if (VentaProducto.Count == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("\t\t~~~~~~~~~~~~~~~~~~~~~            LISTA DE VENTA            ~~~~~~~~~~~~~~~~~~~~~");
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("\t\t La lista está vacía.\n");
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("\t\t~~~~~~~~~~~~~~~~~~~~~            LISTA DE VENTA            ~~~~~~~~~~~~~~~~~~~~~");
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                Console.ForegroundColor = ConsoleColor.Black;
                                for (int i = 0; i < VentaProducto.Count; i++) // Este ciclo muestra la lista de los productos agregados
                                {
                                    string ImprimirAper = VentaProducto[i];
                                    Console.Write("\t\t " + (i + 1) + ". " + ImprimirAper + " ");
                                    for (int n = 0; n < VentaPrecio.Count; n++) 
                                    {
                                        double ImprimirPrecio = VentaPrecio[i];
                                        Console.Write("----------------$" + ImprimirPrecio + "\n");
                                        break;
                                    }
                                }
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("\t\t********************************************************************************");
                                Console.ForegroundColor = ConsoleColor.Black;
                                while (barComida.EliminarCantidad <= 0 || barComida.EliminarCantidad >= VentaProducto.Count + 1)
                                {
                                    Console.Write("\t\t\n               Selecciona el producto a eliminar : ");
                                    barComida.EliminarCantidad = Int32.Parse(Console.ReadLine());
                                }
                                for (int i = 0; i < barComida.EliminarCantidad; i++)
                                {
                                    barComida.EliminarComestible = VentaProducto[i];
                                    for (int n = 0; n < barComida.EliminarCantidad; n++)
                                    {

                                        barComida.EliminarPrecio = VentaPrecio[i];
                                        break;

                                    }
                                }

                                VentaProducto.Remove(barComida.EliminarComestible);
                                VentaPrecio.Remove(barComida.EliminarPrecio);

                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("\t\t~~~~~~~~~~~~~~~~~~~~~             El producto              ~~~~~~~~~~~~~~~~~~~~~");
                                Console.WriteLine("\t\t                                 " + barComida.EliminarComestible + " $" + barComida.EliminarPrecio);
                                Console.WriteLine("\t\t~~~~~~~~~~~~~~~~~~~~~            fue eliminado             ~~~~~~~~~~~~~~~~~~~~~");
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                            }
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("\t\t~~~~~~~~~~~~~~~          Presione enter para continuar           ~~~~~~~~~~~~~~~");
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 5:
                          
			                if (VentaProducto.Count == 0) // Si no hay ningun producto en la lista entrar a este if y que vuelva al menu 
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("\t\t~~~~~~~~~~~~            LISTA DE CONSUMIBLES AGREGADOS            ~~~~~~~~~~~~~~");
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("\t\t La lista está vacía.");
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("\t\t~~~~~~~~~~~~            LISTA DE CONSUMIBLES AGREGADOS            ~~~~~~~~~~~~~~");
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                Console.ForegroundColor = ConsoleColor.Black;

                                for (int i = 0; i < VentaProducto.Count; i++) // Este ciclo muestra la lista de los productos agregados
                                {
                                    string ImprimirProducto = VentaProducto[i];
                                    Console.Write("\t\t " + (i + 1) + ". " + ImprimirProducto + " ");

                                    for (int n = 0; n < VentaPrecio.Count; n++)
                                    {
                                        double ImprimirPrecio = VentaPrecio[i];
                                        Console.Write("---------------$" + ImprimirPrecio + "\n");
                                        break;
                                    }

                                }
                            }
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("\t\t~~~~~~~~~~~~~~~          Presione enter para continuar           ~~~~~~~~~~~~~~~");
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                            Console.ReadKey();
                            Console.Clear();
                            break;

                        case 6:

                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("\t\t********************************************************************************");
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("\t\t******************          Finalizando el programa           ******************");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("\t\t********************************************************************************");
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("\t\t********************************************************************************");
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("\t\t******************        DESARROLLADORES DEL PROGRAMA        ******************");
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("\t\t********************************************************************************");
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("\t\t~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            Console.WriteLine("\t\t*     Bonilla Moreira Cristian Jair                                            *");
                            Console.WriteLine("\t\t*     Tejena Chavez Christopher Aaron                                          *");
                            Console.WriteLine("\t\t*     Vinces Andrade Michael Leonardo                                          *");
                            Console.WriteLine("\t\t~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            Console.WriteLine("\t\t*                                                                              *");
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("\t\t********************************************************************************");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("\t\t~~~~~~~~~~~~~~~           Presione enter para cerrar             ~~~~~~~~~~~~~~~");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                            Console.ReadKey();
                            Environment.Exit(1);
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("\t\t********************************************************************************");
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("\t\t****************         Seleccione una opcion valida           ****************");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("\t\t********************************************************************************");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("\t\t~~~~~~~~~~~~~~~          Presione enter para continuar           ~~~~~~~~~~~~~~~");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                    if (acceso == false)
                    {
                        break;
                    }
                }
            }
        }

        // Método para imprimir los asientos
        public static void ImprimirAsientos(int[,] matriz, int nFilas)
        {
            for (int i = 1; i <= nFilas; i++)
            {
                Console.Write("\t" + i);
            }
            Console.WriteLine("");
            Console.WriteLine("");

            for (int filas = 0; filas < matriz.GetLength(0); filas++)
            {
                Console.Write(filas + 1);
                for (int columnas = 0; columnas < matriz.GetLength(1); columnas++)
                {
                    if (matriz[filas, columnas] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\t" + matriz[filas, columnas].ToString());
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("\t" + matriz[filas, columnas].ToString());
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                Console.WriteLine(" ");
                Console.WriteLine(" ");
            }
        }
        //Método para reservar asientos
        public static string ReservarAsientos(int[,] matriz, int nFilas, int nColumnas)
        {
            int totalAsientos = nFilas * nColumnas;
            string ImprimAsientos = "";
            int Contador = 0;
            while (totalAsientos >= 1)
            {
                Console.Clear();
                ImprimirAsientos(matriz, nFilas);

                int nAsientos = 0;

                while (nAsientos <= 0 || nAsientos > totalAsientos)
                {
                    Console.Clear();
                    ImprimirAsientos(matriz, nFilas);
                    Console.WriteLine("\nCuantos asientos va a reservar? : ");
                    nAsientos = Int32.Parse(Console.ReadLine());
                }
                Console.Clear();
                ImprimirAsientos(matriz, nFilas);

                for (int i = 1; i <= nAsientos; i++)
                {
                    int x = 0, y = 0;

                    while (true)
                    {
                        while ((x <= 0 || x > nFilas) || (y <= 0 || y > nColumnas))
                        {
                            Console.Clear();
                            ImprimirAsientos(matriz, nFilas);
                            Console.WriteLine("\nElija el asiento");
                            Console.Write("\nFila: ");
                            x = Int32.Parse(Console.ReadLine());
                            Console.Write("\nColumna: ");
                            y = Int32.Parse(Console.ReadLine());
                        }
                        while (matriz[x - 1, y - 1] != 0)
                        {
                            Console.Clear();
                            ImprimirAsientos(matriz, nFilas);

                            Console.WriteLine("\nAsiento reservado");
                            Console.WriteLine("\nElija otro asiento");
                            Console.Write("\nFila: ");
                            x = Int32.Parse(Console.ReadLine());
                            Console.Write("\nColumna: ");
                            y = Int32.Parse(Console.ReadLine());
                        }
                        if (matriz[x - 1, y - 1] == 0)
                        {
                            Contador++;
                            ImprimAsientos += "\t\t\t    Asiento " + Contador+ "\t\t|\t" + x.ToString() + " - " + y.ToString() + "\n";
                            break;
                        }
                    }
                    for (int a = 0; a < 5; a++)
                    {
                        for (int b = 0; b < 5; b++)
                        {
                            matriz[x - 1, y - 1] = 1;

                        }
                    }
                    totalAsientos--;
                    if (totalAsientos == 0)
                    {
                        Console.Clear();
                        ImprimirAsientos(matriz, nFilas);

                        Console.WriteLine("\nSala llena");
                        Console.WriteLine("\nPulse ENTER para continuar");
                        Console.ReadKey();
                    }
                    Console.Clear();
                    ImprimirAsientos(matriz, nFilas);
                }
                break;
                
            }
            return ImprimAsientos;
        }

    }
}
