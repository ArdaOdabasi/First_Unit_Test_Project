using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.Tests
{
    [TestClass]
    public class StringHelperTests
    {
        [TestMethod]
        public void Girilen_ifadenin_basindaki_ve_sonundaki_fazla_bosluklar_silinmelidir()
        {
            //Arrange
            var ifade = "   Arda Odabaşı  ";
            var beklenen = "Arda Odabaşı";

            //Act
            var gerceklesen = StringHelper.FazlaBosluklariSil(ifade);

            //Assert
            Assert.AreEqual(beklenen,gerceklesen);
        }

        [TestMethod]
        public void Girilen_ifadenin_icindeki_fazla_bosluklar_silinmelidir()
        {
            //Arrange
            var ifade = "Arda Odabaşı  Ersun     Yanal Alex De   Souza";
            var beklenen = "Arda Odabaşı Ersun Yanal Alex De Souza";

            //Act
            var gerceklesen = StringHelper.FazlaBosluklariSil(ifade);

            //Assert
            Assert.AreEqual(beklenen, gerceklesen);
        }
    }
}
