using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodPattern.ConcreteCreator;
using FactoryMethodPattern.ConcreteProduct;
using FactoryMethodPattern.Creator;
using FactoryMethodPattern.Producto;
namespace FactoryMethodPattern
{
    class Program
    {


        /// <summary>
        /// MainApp startup class for Real-World 
        /// Factory Method Design Pattern.
        /// </summary>
        class MainApp
        {
            /// <summary>
            /// Entry point into console application.
            /// </summary>
            static void Main()
            {
                // Note: constructors call Factory Method
                //List<Formulario> documents = new List<Formulario>();

                ////documents.Add(new Resume());
                //documents.Add(new Reporte());

               Reporte ReporteSimple =   new Reporte();

                ReporteSimple.ExportarPreguntas();
             int cantidadPreguntas =   ReporteSimple.ListaTextoPreguntasXML.Count ;

                Console.WriteLine("total preguntas " + cantidadPreguntas.ToString());
                //// Display document pages
    

                // Wait for user
                Console.ReadKey();
            }
        }

    

  
    }

}

