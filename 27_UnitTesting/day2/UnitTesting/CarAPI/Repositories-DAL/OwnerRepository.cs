using CarAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarAPI.Repositories_DAL
{
    public class OwnerRepository : IOwnerRepository
    {
        public InMemoryContext Context { get; set; }

        public OwnerRepository(InMemoryContext memoryContext)
        {
            Context = memoryContext;
        }

        public List<Owner> GetAllOwners()
        {
            return Context.Owners;
        }

        public Owner GetOwnerById(int id)
        {
            return Context.Owners.FirstOrDefault(o => o.Id == id);
        }

        public string AddOwner(Owner owner)
        {
            Context.Owners.Add(owner);
            return "success";

        }

       
    }

}