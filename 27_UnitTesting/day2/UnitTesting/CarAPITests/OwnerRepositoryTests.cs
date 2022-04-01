using CarAPI.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using CarAPI.Repositories_DAL;

namespace CarAPITests
{
    [TestClass]
    public class OwnerRepositoryTests
    {
        private static List<Owner> owners;
        private static Mock<InMemoryContext> MockOwnerRespository;
        private static OwnerRepository ownerRespoitory;

        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            MockOwnerRespository = new Mock<InMemoryContext>();
           

            owners = new List<Owner>()
            {
                new Owner(1,"shimaa")
            };

            


        }
        // ***************************** 4 ************************
        [TestMethod]
        public void GetAllOwners_EquilvantOwners_Equvlant()
        {
            //assign
            MockOwnerRespository.Setup(X => X.Owners).Returns(owners);

            ownerRespoitory = new OwnerRepository(
                MockOwnerRespository.Object);

            //act
            var Result = ownerRespoitory.GetAllOwners();

            //assert
            CollectionAssert.AreEquivalent(owners, Result);
        }

        // ***************************** 5 ************************
        [TestMethod]
        public void GetById_OwnerID2_Null()
        {
            //assign
            MockOwnerRespository.Setup(X => X.Owners).Returns(owners);

           // MockOwnerRespository.Setup(X => X.Owners.FirstOrDefault(o => o.Id == id)).Returns(owners.Find(X => X.Id == 2));

            ownerRespoitory = new OwnerRepository(
                MockOwnerRespository.Object);
            

            //act
            var Result = ownerRespoitory.GetOwnerById(2);

            //assert
            Assert.IsNull(Result);
        }

        // **************************** 6 ***************************
        [TestMethod]
        public void AddOwner_Owner_sucess()
        {
            //assign
            MockOwnerRespository.Setup(X => X.Owners).Returns(owners);
            //MockOwnerRespository.Setup(X => X.Owners.Add());

            ownerRespoitory = new OwnerRepository(
                MockOwnerRespository.Object);

            //act
            var Result = ownerRespoitory.AddOwner(owners[0]);

            //assert
            StringAssert.Contains(Result,"success");
        }


    }
}
