using Microsoft.EntityFrameworkCore;
using MVC_Portfolio_Website.Models;
using System.Data.Entity;

namespace MVC_Portfolio_Website.Data
{
    public class EstateContext : Microsoft.EntityFrameworkCore.DbContext
    {
     /*   public EstateContext(DbContextOptions<EstateContext> options) : base(options)
        {

        }*/
        public EstateContext(DbContextOptions<EstateContext> options) : base(options)
        {
        }

        //Database set
        public Microsoft.EntityFrameworkCore.DbSet<Estate> Estates { get; set; }
    }
}
