using CarAPI.Entities;
using CarAPI.Repositories_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAPITests
{
    public class FakeOwnerRepository : IOwnerRepository
    {
        private readonly FakeInMemoryContext _context;

        public FakeOwnerRepository(FakeInMemoryContext context)
        {
            _context = context;
        }
        public string AddOwner(Owner owner)
        {
            _context.Owners.Add(owner);
            return "h";
        }

        public List<Owner> GetAllOwners()
        {
            return _context.Owners;
        }

        public Owner GetOwnerById(int id)
        {
            return _context.Owners.FirstOrDefault(o => o.Id == id);
        }
    }
}
