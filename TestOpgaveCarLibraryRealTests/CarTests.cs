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
    public class CarTests
    {

        #region DoorTests

        /// <summary>
        /// Tester Antal døre.
        /// tester også om Den kaster Exceptions hvis der er for få eller mange døre.
        /// </summary>

        [TestMethod()]
        public void CarDoor()
        {
            //Arrange
            Car TestCar = new Car(Car.Color.Green, 5, "Volvo", "AS69420", "Bent");
            //Act
            //Assert
            Assert.AreEqual(5, TestCar.Doors);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void CarDoorLidt()
        {
            //Arrange
            Car TestCar = new Car(Car.Color.Green, 1, "Volvo", "AS69420", "Bent");
            //Act            
            //Assert
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void CarDoorMange()
        {
            //Arrange
            Car TestCar = new Car(Car.Color.Green, 7, "Volvo", "AS69420", "Bent");
            //Act            
            //Assert
        }
        #endregion

        #region ModelTests

        /// <summary>
        /// Tester Bilens model.
        /// Tester også om den kaster exception hvis Model = Null
        /// </summary>
        /// 
        [TestMethod()]
        public void CarModel()
        {
            //Arrange
            Car TestCar = new Car(Car.Color.Green, 5, "Volvo", "AS69420", "Bent");
            //Act
            //Assert
            Assert.AreEqual("Volvo", TestCar.Model);
        }


        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void CarModelNull()
        {
            //Arrange
            Car TestCar = new Car(Car.Color.Green, 7, null, "AS69420", "Bent");
            //Act            
            //Assert
        }
        #endregion

        #region RegNoTests

        /// <summary>
        /// Tester bilens Registrerings Nummer
        /// Tester også om den kaster exception hvis nummeret er for kort eller langt
        /// </summary>

        [TestMethod()]
        public void CarRegNo()
        {
            //Arrange
            Car TestCar = new Car(Car.Color.Green, 5, "Volvo", "AS69420", "Bent");
            //Act
            //Assert
            Assert.AreEqual("AS69420", TestCar.RegNo);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void CarRegNoKort()
        {
            //Arrange
            Car TestCar = new Car(Car.Color.Green, 5, null, "AS6942", "Bent");
            //Act            
            //Assert
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void CarRegNoLangt()
        {
            //Arrange
            Car TestCar = new Car(Car.Color.Green, 5, null, "ASS69420", "Bent");
            //Act            
            //Assert
        }
        #endregion

        #region ColorTests

        //[TestMethod()]
        //public void CarColor()
        //{
        //    //Arrange
        //    Car TestCar = new Car(Car.Color.Green, 5, "Volvo", "AS69420");
        //    //Act
        //    //Assert
        //    Assert.AreEqual(Car.Color.Green, TestCar.RegNo);
        //}

        //[TestMethod()]
        //[ExpectedException(typeof(ArgumentException))]
        //public void CarColorForkert()
        //{
        //    //Arrange
        //    Car TestCar = new Car("Pink", 5, null, "AS6942");
        //    //Act            
        //    //Assert
        //}

        #endregion
    }
}