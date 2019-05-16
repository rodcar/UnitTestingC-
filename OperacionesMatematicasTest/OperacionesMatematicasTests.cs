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

            Assert.AreEqual<int>(25, Resultado);  
        }

        public void testResta()

        {

            var OperacionesMatematicas = new OperacionesMatematicas();
            int Resultado = OperacionesMatematicas.resta(10, 15);

            Assert.AreEqual<int>(-5, Resultado);
        }

        public void testMultiplicacion()

        {

            var OperacionesMatematicas = new OperacionesMatematicas();
            int Resultado = OperacionesMatematicas.resta(4, 15);

            Assert.AreEqual<int>(60, Resultado);
        }

        public void testDivison()

        {

            var OperacionesMatematicas = new OperacionesMatematicas();
            int Resultado = OperacionesMatematicas.resta(8, 2);

            Assert.AreEqual<int>(4, Resultado);
        }
    }
}