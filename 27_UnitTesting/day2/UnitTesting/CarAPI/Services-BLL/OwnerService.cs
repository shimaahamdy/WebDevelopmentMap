using CarAPI.Entities;
using CarAPI.Models;
using CarAPI.Payment;
using CarAPI.Repositories_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Unity;

namespace CarAPI.Services_BLL
{
    public class OwnerService : IOwnerService
    {
        private IOwnerRepository OwnerRepository { get; set; }
        public ICarsRepository CarsRepository { get; set; }
        public IPaymentService PaymentService { get; set; }

        public OwnerService(
            IOwnerRepository ownerRepository, 
            ICarsRepository carsRepository,
            [Dependency("CreditCardService")]IPaymentService paymentService
            )
        {
            OwnerRepository = ownerRepository;
            CarsRepository = carsRepository;
            PaymentService = paymentService;
        }

        public List<Owner> GetOwners()
        {
            return OwnerRepository.GetAllOwners();
        }

        public void AddOwner(Owner owner)
        {
            
            OwnerRepository.AddOwner(owner);
        }


        public Owner GetById(int id)
        {
            return OwnerRepository.GetOwnerById(id);
        }

        public string BuyCar(BuyCarInput input)
        {
            // validate CarId is present
            // validate CarId is not sold
            // validate OwnerId is found
            // validate Amount is positive
            // Validate Amount == car.Price
            var car = CarsRepository.GetCarById(input.CarId);
            var owner = OwnerRepository.GetOwnerById(input.OwnerId);
            
            owner.Car = car;
            car.Owner = owner;

            if (input.Amount == car.Price)
            {
                var paymentResult = PaymentService.Pay(input.Amount);
                return $"Successfull \r\nCar of Id: {input.CarId} is bought by {owner.Name} with payment result {paymentResult}";
            }
            else return $"Failed \r\nCar of Id: {input.CarId} cost more than owner {owner.Name} {input.Amount}";
        }
    }
}