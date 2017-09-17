using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestOpgaveCarLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOpgaveCarLibrary.Tests
{
    [TestClass()]
    public class OwnerTests
    {

        #region NameTest
        //Tester for om Navnet er godt nok
        [TestMethod()]
        public void OwnerTestNavn()
        {
            //Arrange
            Owner TestOwner = new Owner("TestAddresse", "Vanessa", "65872471");
            //act           
            //assert
            Assert.AreEqual("Vanessa", TestOwner.Name);
        }

        //Tester om navnet er for kort
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void OwnerTestNavnKort()
        {
            //Arrange
            Owner TestOwner = new Owner("TestAddresse", "Bo", "65872471");
            //act
            //assert
        }

        /// <summary>
        /// opretter objekt med Navn som er OK.
        /// Ændre navnet til et som er for kort.
        /// Køre metode for at checke Navnet;
        /// hvis OK, retunere det, hvis ikke kaster exception
        /// Samme princip kan udføres på alle andre metoder som checker samme ting.
        /// </summary>

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void OwnerTestNavnÆndring()
        {
            //Arrange
            Owner TestOwner = new Owner("TestAddresse", "Vanessa", "65872471");
            //act
            TestOwner.Name = "Bo";
            TestOwner.navneÆndring();
            //assert
        }

        #endregion

        #region AddresseTest

        //Tester om Addressen virker
        [TestMethod()]
        public void OwnerTestAddresse()
        {
            //Arrange
            Owner TestOwner = new Owner("TestAddresse", "Vanessa", "65872471");
            //act           
            //assert
            Assert.AreEqual("TestAddresse", TestOwner.Address);
        }

        //Tester om Addresse-navnet er for kort
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void OwnerTestAddresseKort()
        {
            //Arrange
            Owner TestOwner = new Owner("Addr", "Bo", "65872471");
            //act
            //assert
        }

        #endregion

        #region PhoneTests
        //Tester Om Phone-Nummeret er rigtigt
        [TestMethod()]
        public void OwnerTestPhone()
        {
            //Arrange
            Owner TestOwner = new Owner("TestAddresse", "Vanessa", "65872471");
            //act           
            //assert
            Assert.AreEqual("65872471", TestOwner.Phone);
        }

        //Tester om Phone-Nummeret er for kort
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void OwnerTestPhoneKort()
        {
            //Arrange
            Owner TestOwner = new Owner("Addr", "Bo", "6587247");
            //act
            //assert
        }

        //Tester om Phone-Nummeret er for langt
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void OwnerTestPhoneLangt()
        {
            //Arrange
            Owner TestOwner = new Owner("Addr", "Bo", "658724714");
            //act
            //assert
        }

        #endregion

        
    }
}