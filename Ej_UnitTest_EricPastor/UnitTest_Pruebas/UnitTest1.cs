using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Ej_UnitTest_EricPastor;

namespace Ej_UnitTest_EricPastor.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void areaCuadrado_test()
        {
            Geometria geo = new Geometria();
            int resultado = geo.areacuadrado(2);
            Assert.AreEqual(4, resultado);
        }

        [TestMethod]
        public void areaCirculo_test()
        {
            Geometria geo = new Geometria();
            double resultado = geo.areaCirculo(2);
            Assert.AreEqual(12.5664, resultado);
        }

        [TestMethod]
        public void areaTriagulo_test()
        {
            Geometria geo = new Geometria();
            int resultado = geo.areatriangulo(2,1);
            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void areaRectangulo_test()
        {
            Geometria geo = new Geometria();
            int resultado = geo.arearectangulo(2, 5);
            Assert.AreEqual(10, resultado);
        }

        [TestMethod]
        public void areaPentagono_test()
        {
            Geometria geo = new Geometria();
            int resultado = geo.areapentagono(2, 5);
            Assert.AreEqual(5, resultado);
        }

        [TestMethod]
        public void areaRombo_test()
        {
            Geometria geo = new Geometria();
            int resultado = geo.arearombo(2, 50);
            Assert.AreEqual(50, resultado);
        }

        [TestMethod]
        public void areaRomboide_test()
        {
            Geometria geo = new Geometria();
            int resultado = geo.arearomboide(2, 5);
            Assert.AreEqual(10, resultado);
        }

        [TestMethod]
        public void areaTrapecio_test()
        {
            Geometria geo = new Geometria();
            int resultado = geo.areatrapecio(2, 2, 5);
            Assert.AreEqual(10, resultado);
        }

        [TestMethod]
        public void areaFigura_test()
        {
            Geometria geo = new Geometria();
            string resultado = geo.figura(5);
            Assert.AreEqual("Pentagono", resultado);
        }
    }
}
