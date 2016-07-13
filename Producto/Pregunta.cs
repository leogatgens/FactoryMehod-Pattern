using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Producto
{  
    /// <summary>
   /// The 'Product' abstract class
   /// </summary>
    abstract class   Pregunta
    {

        /// <summary>
        /// Codigo de la pregunta, por ejemplo A.1
        /// </summary>
        /// <returns></returns>
        public  string CodigoPregunta { get; set; }

       

        /// <summary>
        /// Descripción de la pregunta que se visualiza en pantalla
        /// </summary>
        /// <returns></returns>
       public string Enunciado { get; set; }




        public string Validacion { get; set; }

        public bool EsPreguntaConSalto { get; set; }

        public string Salto { get; set; }

        public bool EsPreguntaConComentario { get; set; }

        public string Comentario { get; set; }

        public bool EsDetalle { get; set; }

        public abstract string ExportarXMlPregunta();
     }
}
