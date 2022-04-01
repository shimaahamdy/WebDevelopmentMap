using CarAPI.Entities;
using CarAPI.Models;
using CarAPI.Payment;
using CarAPI.Repositories_DAL;
using CarAPI.Services_BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;

namespace CarAPITests
{
    [TestClass]
    public class OwnerServiceTests
    {
        private static Mock<IOwnerRepository> mockOwnerRespository;
        private static Mock<ICarsRepository> mockCarsRespository;
        private static Mock<IPaymentService> mockPaymentService;
        private static OwnerService ownerService;
        private static List<Owner> owners;
        

        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            mockOwnerRespository = new Mock<IOwnerRepository>();
            mockCarsRespository = new Mock<ICarsRepository>();
            mockPaymentService = new Mock<IPaymentService>();

            owners = new List<Owner>()
            {
                new Owner(1,"shimaa")
            };
            
           
        }

        #region Tightly coupled
        [TestMethod]
        public void GetById_ExistingId1_NotNull()
        {
            // Arrange
            var ownerService = new OwnerService(
                new OwnerRepository(new InMemoryContext()),
                new CarsRepository(new InMemoryContext()),
                new CashService());

            // Act
            var owner = ownerService.GetById(1);

            // Assert
            Assert.IsNotNull(owner);
        } 

        [TestMethod]
        public void BuyCar_ExistingCarId1AndOwnerId1_Successfull_TightlyCoupled()
        {
            // Arrange
            var ownerService = new OwnerService(
                new OwnerRepository(new InMemoryContext()),
                new CarsRepository(new InMemoryContext()),
                new CashService());
            var buyCarInput = new BuyCarInput()
            {
                CarId = 1,
                OwnerId = 1,
                Amount = 500000
            };

            // Act
            var result = ownerService.BuyCar(buyCarInput);

            // Assert
            StringAssert.Contains(result,"Successfull");
        }
        #endregion

        #region Fake Data
        [TestMethod]
        public void BuyCar_ExistingCarId1AndOwnerId1_Successfull_FakeContext()
        {
            // Arrange
            var ownerService = new OwnerService(
                new FakeOwnerRepository(new FakeInMemoryContext()),
                new FakeCarRespository(new FakeInMemoryContext()),
                new CashService());
            var buyCarInput = new BuyCarInput()
            {
                CarId = 1,
                OwnerId = 1,
                Amount = 500000
            };

            // Act
            var result = ownerService.BuyCar(buyCarInput);

            // Assert
            StringAssert.Contains(result, "Successfull");
        }
        #endregion

        #region MOQ

        [TestMethod]
        public void BuyCar_ExistingCarId1AndOwnerId1_Successfull_MOQ()
        {
            // Arrange

            //Mock<IOwnerRepository> mockOwnerRespository = new Mock<IOwnerRepository>();
            //Mock<ICarsRepository> mockCarsRespository = new Mock<ICarsRepository>();
            //Mock<IPaymentService> mockPaymentService = new Mock<IPaymentService>();

            var buyCarInput = new BuyCarInput()
            {
                CarId = 1,
                OwnerId = 1,
                Amount = 500000
            };

            var car = new Car(1, CarType.Audi, 0);
            var owner = new Owner(1,"Waleed");
            var paymentResult = $"Amount: {buyCarInput.Amount} is paid through Cash";

            mockOwnerRespository.Setup(o => o.GetOwnerById(buyCarInput.OwnerId)).Returns(owner);
            mockCarsRespository.Setup(o => o.GetCarById(buyCarInput.CarId)).Returns(car);
            mockPaymentService.Setup(o => o.Pay(buyCarInput.Amount)).Returns(paymentResult);

            //var ownerService = new OwnerService(
            //    mockOwnerRespository.Object,
            //    mockCarsRespository.Object,
            //    mockPaymentService.Object
            //    );

            // Act
            var result = ownerService.BuyCar(buyCarInput);

            // Assert
            StringAssert.Contains(result, "Successfull");
        }
        #endregion

        
        
        
        
        
        // ****************************** 1 *************************
        [TestMethod]
        public void BuyCar_AmountNotEnough_Failed()
        {
            //Assign
            var buyCarInput = new BuyCarInput()
            {
                CarId = 1,
                OwnerId = 1,
                Amount = 500000
            };

            var car = new Car(1, CarType.Audi, 0);
            car.Price = 600000;
            var owner = new Owner(1, "Waleed");
            var paymentResult = $"Amount: {buyCarInput.Amount} is paid through Cash";

            mockOwnerRespository.Setup(o => o.GetOwnerById(buyCarInput.OwnerId)).Returns(owner);
            mockCarsRespository.Setup(o => o.GetCarById(buyCarInput.CarId)).Returns(car);
            mockPaymentService.Setup(o => o.Pay(buyCarInput.Amount)).Returns(paymentResult);

            ownerService = new OwnerService(
                mockOwnerRespository.Object,
                mockCarsRespository.Object,
                mockPaymentService.Object
                );

            // Act
            var result = ownerService.BuyCar(buyCarInput);

            // Assert
            StringAssert.Contains(result, "Failed");
        }


        // ****************************** 2 *************************
        [TestMethod]
        public void GetById_OwnerID2_Null()
        {
            //Assign

            mockOwnerRespository.Setup(o => o.GetOwnerById(2)).Returns(owners.Find(O=>O.Id==2));
      

            ownerService = new OwnerService(
                mockOwnerRespository.Object,
                mockCarsRespository.Object,
                mockPaymentService.Object
                );

            // Act
            var result = ownerService.GetById(2);

            // Assert
            Assert.IsNull(result);
        }

        // ****************************** 3 *********************************

        [TestMethod]
        public void GetOwners_EquilvantOwners_Equvlant()
        {
            //Assign
            owners = new List<Owner>()
            {
                new Owner(1,"shimaa"),
                new Owner(1,"shimaa")
            };
            mockOwnerRespository.Setup(o => o.GetAllOwners()).Returns(owners);


            ownerService = new OwnerService(
                mockOwnerRespository.Object,
                mockCarsRespository.Object,
                mockPaymentService.Object
                );

            // Act
            var result = ownerService.GetOwners();

            // Assert
            CollectionAssert.AreEquivalent(owners, result);
        }





    }
}
