using CarsApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAppTests
{
    [TestClass]
    public class CarStoreTests
    {

        #region Assert

        [TestMethod]
        public void GetAllStoreCars_Provide5Cars_CarListLength5()
        {
            // Arrange
            var car1 = new Car();
            var car2 = new Car();
            var car3 = new Car();
            var car4 = new Car();
            var car5 = new Car();

            var store = new CarStore();

            // Act
            store.AddCar(car1);
            store.AddCar(car2);
            store.AddCar(car3);
            store.AddCar(car4);
            store.AddCar(car5);
            var carsList = store.GetAllStoreCars();
            var actualLength = carsList.Count;
            var expectedLength = 5;

            Assert.AreEqual(actualLength, expectedLength);
        }
        #endregion

        #region Collection Assert
        [TestMethod]
        public void GetAllStoreCars_SameCarsSameOrder_Equal()
        {
            // Arrange
            var car1 = new Car(CarType.Audi, 0, DrivingMode.Forward);
            var car2 = new Car(CarType.BMW, 10, DrivingMode.Stopped);
            var car3 = new Car(CarType.Toyota, 20, DrivingMode.Reverse);

            var store1 = new CarStore();
            var store2 = new CarStore();

            // Act
            store1.AddCar(car1);
            store1.AddCar(car2);
            store1.AddCar(car3);

            store2.AddCar(car1);
            store2.AddCar(car2);
            store2.AddCar(car3);

            var store1Cars = store1.GetAllStoreCars();
            var store2Cars = store2.GetAllStoreCars();

            // Assert
            CollectionAssert.AreEqual(store2Cars, store1Cars);
        }

        [TestMethod]
        public void GetAllStoreCars_SameCarsDifferentOrder_Equivelant()
        {
            // Arrange
            var car1 = new Car(CarType.Audi, 0, DrivingMode.Forward);
            var car2 = new Car(CarType.BMW, 10, DrivingMode.Stopped);
            var car3 = new Car(CarType.Toyota, 20, DrivingMode.Reverse);

            var store1 = new CarStore();
            var store2 = new CarStore();

            // Act
            store1.AddCar(car1);
            store1.AddCar(car2);
            store1.AddCar(car3);

            store2.AddCar(car1);
            store2.AddCar(car3);
            store2.AddCar(car2);

            var store1Cars = store1.GetAllStoreCars();
            var store2Cars = store2.GetAllStoreCars();

            // Assert
            CollectionAssert.AreEquivalent(store2Cars, store1Cars);
        }

        #endregion
    }
}
