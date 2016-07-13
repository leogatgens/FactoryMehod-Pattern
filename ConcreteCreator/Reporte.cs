using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodPattern.Creator;
using FactoryMethodPattern.ConcreteProduct;
using FactoryMethodPattern.Producto;


namespace FactoryMethodPattern.ConcreteCreator
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    class Reporte : Formulario
    {

     
        // Factory Method implementation
        public override void CreatePreguntas()
        {

            // Display document pages
            foreach (var item in ListaTextoPreguntasXML )
            {
                switch (item.TipoPregunta)
                {
                    case "PreguntaSeleccionUnica":
                        preguntasDelFormulario.Add(new PreguntaSeleccionUnica(item));
                        break;

                    case "PreguntaSimple":
                        preguntasDelFormulario.Add(new PreguntaSimple(item ));
                        break;

                    case "PreguntaSimpleDetalle":
                        preguntasDelFormulario.Add(new PreguntaSimpleDetalle(item));
                        break;
                        //Pages.Add(new PreguntaTextoMultilinea());
                        //Pages.Add(new PreguntaSeleccionMultiple());
                        //Pages.Add(new SummaryPage());

                }
                
            }

          
        }

        public override void ExportarPreguntas()
        {
            foreach (Pregunta laPreguntaDelFormulario in preguntasDelFormulario    ) {

                AdministraProcesoDeSalto(laPreguntaDelFormulario );
                AdministraProcesoDetalle(laPreguntaDelFormulario );
                AdministraProcesoComentario(laPreguntaDelFormulario);
                Console.WriteLine(laPreguntaDelFormulario.CodigoPregunta.ToString() + ": " + laPreguntaDelFormulario.Enunciado + "," + laPreguntaDelFormulario.GetType().Name.ToString());

            }

            
                
        }

        private void AdministraProcesoDeSalto(Pregunta laPreguntaDelFormulario) {
            if (laPreguntaDelFormulario.EsPreguntaConSalto)
            {
                Console.WriteLine("Me saltaron");
            }
            else
            {
               //nada

            }

        }


        private void AdministraProcesoDetalle(Pregunta laPreguntaDelFormulario)
        {

        
            if (laPreguntaDelFormulario.EsDetalle)
            {
                Console.WriteLine("Tengo detalle");
            }
            else
            {
                //nada

            }

        }


        private void AdministraProcesoComentario(Pregunta laPreguntaDelFormulario)
        {


            if (laPreguntaDelFormulario.EsPreguntaConComentario )
            {
                Console.WriteLine("Tengo comentario");
            }
            else
            {
                //nada

            }

        }

    }
}
