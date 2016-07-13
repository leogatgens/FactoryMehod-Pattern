using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodPattern.ConcreteProduct;
using FactoryMethodPattern.Creator;


namespace FactoryMethodPattern.ConcreteCreator
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    class Resume : Formulario
    {
        // Factory Method implementation
        public override void CreatePreguntas()
        {
            preguntasDelFormulario.Add(new PreguntaListaDespegable());
            preguntasDelFormulario.Add(new PreguntaSimpleDetalle(new PreguntaDelXML() ));
            preguntasDelFormulario.Add(new PreguntaMatriz());
        }
        public override void ExportarPreguntas()
        {
            throw new NotImplementedException();
        }


    }
}
