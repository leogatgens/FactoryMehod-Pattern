using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using FactoryMethodPattern.Producto;

namespace FactoryMethodPattern.ConcreteProduct
{
    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    class PreguntaSimple : Pregunta
    {


    public  PreguntaSimple(PreguntaDelXML DatosPreguntaDelXml){

            CodigoPregunta = DatosPreguntaDelXml.CodPregunta;
            Enunciado = DatosPreguntaDelXml.Enunciado;            
            EsDetalle = false;
            EsPreguntaConSalto = false;
            EsPreguntaConComentario = false;
            Salto = string.Empty;
    }

       
        public override string ExportarXMlPregunta()
        {
            XmlDocument doc = new XmlDocument();
        doc.LoadXml("<?xml version='1.0' ?>" +
                        "<book genre='novel' ISBN='1-861001-57-5'>" +
                        "<title>Pride And Prejudice</title>" +
                        "</book>");

            return doc.ToString ();
            
        }
    }

}
