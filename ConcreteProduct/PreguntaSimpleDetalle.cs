using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodPattern.Producto;


namespace FactoryMethodPattern.ConcreteProduct
{
    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    class PreguntaSimpleDetalle : Pregunta
    {


        public PreguntaSimpleDetalle(PreguntaDelXML DatosPreguntaDelXml)
        {

            CodigoPregunta = DatosPreguntaDelXml.CodPregunta;
            Enunciado = DatosPreguntaDelXml.Enunciado;
            EsDetalle = true;
            EsPreguntaConSalto = false;
            EsPreguntaConComentario = false;
            Salto = string.Empty;
        }
        public override string ExportarXMlPregunta()
        {
            throw new NotImplementedException();
        }
    }
}
