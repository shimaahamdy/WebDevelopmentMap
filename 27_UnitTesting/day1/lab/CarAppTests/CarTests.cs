using CarsApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CarAppTests
{
    [TestClass]
    public class CarTests
    {

        #region Initialize
        public TestContext TestContext { get; set; }
        
        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            context.WriteLine("Class initialize");
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
        }
        public Car AudiCar { get; set; }

        [TestInitialize]
        public void MyTestInitialize()
        {
            AudiCar = new Car(CarType.Audi, 0, DrivingMode.Forward);
            TestContext.WriteLine("Test Initialize");
        }

        [TestCleanup]
        public void MyTestCleanup()
        {
            TestContext.WriteLine("Test Cleanup");
        }
        #endregion



        #region Assert class
        [TestMethod]
        public void TimeToCoverProvidedDistance_Distance100Velocity25_Time4()
        {
            // Arrange
            Car car = new Car(CarType.Audi, 25, DrivingMode.Forward);

            // Act
            var distanceToBeCovered = 100;
            var actualTime = car.TimeToCoverProvidedDistance(distanceToBeCovered);
            double expectedTime = 4;

            // Assert
            Assert.AreEqual(expectedTime, actualTime);
        }

        [TestMethod]
        public void CarInstances_2DifferentInstancesSameAttributes_NotSameReference()
        {
            // Arrange
            Car car1 = new Car(CarType.Audi, 25, DrivingMode.Forward);
            Car car2 = new Car(CarType.Audi, 25, DrivingMode.Forward);

            // Act


            // Assert
            Assert.AreNotSame(car1, car2);
        }

        [Owner("Waleed")]
        [TestCategory("Equality")]
        [Priority(2)]
        [TestMethod]
        public void CarInstances_2DifferentInstancesSameAttributes_Equal()
        {
            // Arrange
            Car car1 = new Car(CarType.Audi, 25, DrivingMode.Forward);
            Car car2 = new Car(CarType.Audi, 25, DrivingMode.Forward);

            // Act


            // Assert
            Assert.AreEqual(car1, car2);
        }

        [Owner("Mohamed")]
        [TestCategory("Null")]
        [Priority(1)]
        [TestMethod]
        public void GetMyCar_InstanceExist_NotNull()
        {
            var car = new Car();

            var outcome = car.GetMyCar();

            Assert.IsNotNull(outcome);
        }

        [Ignore]
        [TestMethod]
        public void GetMyCar_InstanceOfTypeCar_IsCar()
        {
            var car = new Car();

            var outcome = car.GetMyCar();

            Assert.IsInstanceOfType(outcome, typeof(Car));
        }

        [Owner("Waleed")]
        [TestMethod]
        public void Accelerate_ToyotaInitialVelocity50_Velocity60()
        {
            var car = new Car(CarType.Toyota, 50, DrivingMode.Forward);

            car.Accelerate();
            var actualVelocity = car.Velocity;
            double expected = 60;

            Assert.IsTrue(actualVelocity == expected);
        }
        #endregion


        #region Exception
        [ExpectedException(typeof(NotImplementedException))]
        [TestMethod]
        public void Accelerate_HondaCarNotImplemented_ThrowException()
        {
            var car = new Car(CarType.Honda, 0, DrivingMode.Forward);

            car.Accelerate();
        }
        #endregion

        #region String Assert
        [TestMethod]
        public void GetDirection_CarMovingForward_PrintForward()
        {
            var car = new Car(CarType.BMW, 0, DrivingMode.Forward);

            var actualDirection = car.GetDirection();
            var expectedDirection = "Forward";

            StringAssert.Equals(actualDirection,expectedDirection);
        }
        #endregion
    }
}
