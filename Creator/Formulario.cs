using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using FactoryMethodPattern.Producto;

using System.Xml.Linq;
using System.Collections;

namespace FactoryMethodPattern.Creator
{

    /// <summary>
    /// The 'Creator' abstract class
    /// </summary>
    abstract class Formulario
    {
        //Todo formulario es formado por una lista de preguntas.
        List<Pregunta> preguntas = new List<Pregunta>();

        //Variable para mantener un spread en memoria para exportar
        private string  FpSpread;

        //XML existente el cual me sirve para obtener las preguntas existentes, y exportarla a Excel con el SpreadSheet
        private XDocument  ArchivoXmlFormulario;

        private  IEnumerable<PreguntaDelXML > listaPreguntasDelXml;
        // Constructor calls abstract Factory method
        public Formulario()
        {
           //El primer paso para crear un formulario es leer el xml existente del formulario
            this.ObtenerArchivoXMldeBD();
            //El segundo paso es validar la estructura del Xml que no este vacio
            this.ValidaCorrectaEstructuraArchivo();
            this.ObtienePreguntasDelArchivoXML();
         
            //El tercer paso es leer el xml y crear las paginas    
            this.CreatePreguntas();
         
        }

        public List<Pregunta> preguntasDelFormulario
        {
            get { return preguntas ; }
        }

        public List<PreguntaDelXML> ListaTextoPreguntasXML
        {
            get { return listaPreguntasDelXml.ToList(); }
        }


        #region Metodos Implementados


        // Factory Method
        //Estos metodos bien los puede implementar cada concrete creator si lo ocupara
        public void ObtenerArchivoXMldeBD() {
            XDocument doc = new XDocument(
          new XDeclaration("1.0", "utf-8", "yes"),
          new XComment("Starbuzz Customer Loyalty Data"),
          new XElement("starbuzzData",
              new XAttribute("storeName", "Park Slope"),
              new XAttribute("location", "Brooklyn, NY"),
              new XElement("Pregunta",
                  new XElement("PreguntaInfo",                      
                      new XElement("TipoPregunta", "PreguntaSeleccionUnica")),
                   new XElement("CodPregunta", "A1.2"),
                  new XElement("Enunciado", "Total Compras"),
                  new XElement("visits", 50)),
    
              new XElement("Pregunta",
                  new XElement("PreguntaInfo",                      
                      new XElement("TipoPregunta", "PreguntaSimple")),
                  new XElement("CodPregunta", "A1.1"),
                  new XElement("Enunciado", "Total Ventas"),
                  new XElement("visits", 15)),

                  new XElement("Pregunta",
                  new XElement("PreguntaInfo",
                      new XElement("TipoPregunta", "PreguntaSimpleDetalle")),
                  new XElement("CodPregunta", "A5.1"),
                  new XElement("Enunciado", "Total Ventas"),
                  new XElement("visits", 15))
                  )
                  );
            

            ArchivoXmlFormulario = doc;
        }
        public void ObtienePreguntasDelArchivoXML()
        {
             listaPreguntasDelXml = from item in ArchivoXmlFormulario.Descendants("Pregunta")
                       select new PreguntaDelXML 
                       {
                           CodPregunta = item.Element("CodPregunta").Value,
                           Enunciado = item.Element("Enunciado").Value,
                           TipoPregunta = item.Element("PreguntaInfo").Element("TipoPregunta").Value
                       };
       


        }

        public  Boolean  ValidaCorrectaEstructuraArchivo() {
            if (string.IsNullOrEmpty(ArchivoXmlFormulario.ToString ()))
            {
                Console.WriteLine("Error archivo vacio");
                return false;
            }
            else {
                Console.WriteLine("Todo la estructura es correcta, felicidades.");
                return true;
            }           
           
        }

        #endregion


        public abstract void CreatePreguntas();

        public abstract void ExportarPreguntas();

    }
}
