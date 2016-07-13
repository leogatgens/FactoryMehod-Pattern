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
    class PreguntaSeleccionMultiple : Pregunta
    {
        public override string ExportarXMlPregunta()
        {
            throw new NotImplementedException();
        }
    }
}
