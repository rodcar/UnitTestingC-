
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OperacionesMatematicas
{
    [TestClass]
    public class OperacionesMatematicasTests
    {
        [TestMethod]

        public void testSuma()

        {

            var OperacionesMatematicas = new OperacionesMatematicas();
            int Resultado = OperacionesMatematicas.suma(10, 15);

            Assert.AreEqual<int>(25, result);  
        }
    }
}
