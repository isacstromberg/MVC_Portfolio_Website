using MVC_Portfolio_Website.Data;
using MVC_Portfolio_Website.Models;

namespace MVC_Portfolio_Website.Repositories
{
    public class DbRepository : IEstateRepo
    {
        private readonly EstateContext context;
        //private List<Estate> _estates = new List<Estate>
        //{
       
        //    new Estate(3,"Stuga", "Einars stuga")
        //};

        public DbRepository(EstateContext context)
        {
            this.context = context;
        }

        public Estate AddEstate(Estate estate)
        {
            // _estates.Add(estate);
            try
            {
                context.Add(estate);
                context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            return estate;
        }

        public List<Estate> GetEstates()
        {

            return context.Estates.ToList();
        }

        /*
         * 
         *  private List<Estate> _estates = new List<Estate>
        {
            new Estate(1,"Stuga", "Kalles stuga"),
            new Estate(2,"Stuga", "Annas stuga"),
            new Estate(3,"Stuga", "Einars stuga")
        };
        public List<Estate> GetEstates()
        {
            return _estates;
        }

        public Estate AddEstate(Estate estate) 
        {
            _estates.Add(estate);
            return estate;
        }
         *public Estate AddEstate(Estate estate)
{
    context.Estates.Add(estate);
    context.SaveChanges();
    return estate;
}

public List<Estate> GetEstates()
{
    return GetEstates();
}*/
    }
}
