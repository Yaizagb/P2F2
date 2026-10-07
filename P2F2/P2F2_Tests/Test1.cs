
using Microsoft.VisualStudio.TestTools.UnitTesting;
using P2F2;

namespace P2F2_Tests
{
    [TestClass]
    public sealed class Test1
    {
        //n < 0 --> devolver -1
        //facotrial de 0 es 1, devuelve 1
        //valores positivos --> devolver el factorial
        [TestMethod]
        public void TestCalcularFactorialPositivos()
        {
            long resultado = Funciones.CalcularFactorial(5);
            Assert.AreEqual(120, resultado);
        }
        [TestMethod]
        public void TestCalcularFactorialCero()
        {
            long resultado = Funciones.CalcularFactorial(0);
            Assert.AreEqual(1, resultado);
        }
        public void TestCalcularFactorialNegativos()
        {
            long resultado = Funciones.CalcularFactorial(-3);
            Assert.AreEqual(-1, resultado);
        }

        [TestMethod]
        public void TestContrasenyaNull()
        {
            Assert.IsFalse(Funciones.EsContrasenyaValida(null));
        }

        [TestMethod]
        public void TestContrasenyaVacia()
        {
            Assert.IsFalse(Funciones.EsContrasenyaValida(""));
        }

        [TestMethod]
        public void TestContrasenyaMenor8SinCancela()
        {
            Assert.IsFalse(Funciones.EsContrasenyaValida("abc1234"));
        }

        [TestMethod]
        public void TestContrasenyaMayor8SinCancela()
        {
            Assert.IsFalse(Funciones.EsContrasenyaValida("abcdefgh"));
        }

        [TestMethod]
        public void TestContrasenyaConCancelaPeroCorta()
        {
            Assert.IsFalse(Funciones.EsContrasenyaValida("#abc"));
        }

        [TestMethod]
        public void TestContrasenyaValidaMinima()
        {
            Assert.IsTrue(Funciones.EsContrasenyaValida("abcdefg#"));
        }

        [TestMethod]
        public void TestContrasenyaValida()
        {
            Assert.IsTrue(Funciones.EsContrasenyaValida("mi#clave123"));
        }
    }
}