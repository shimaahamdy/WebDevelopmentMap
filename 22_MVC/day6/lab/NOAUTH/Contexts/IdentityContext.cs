using NOAUTH.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NOAUTH.Contexts
{
    public class IdentityContext:DbContext
    {
        public IdentityContext() : base("Conn")
        {

        }

        public DbSet<Client> Clients { get; set; }
    }
}