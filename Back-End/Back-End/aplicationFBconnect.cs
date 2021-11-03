using Back_End.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Back_End
{
    public class aplicationFBconnect : DbContext
    {
        public DbSet<Comentario> comentario { get; set; }

        public aplicationFBconnect(DbContextOptions<aplicationFBconnect> options) : base(options)
        {

        }

    }
}
