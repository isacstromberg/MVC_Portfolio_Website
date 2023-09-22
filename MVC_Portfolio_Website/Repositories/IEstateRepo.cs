using MVC_Portfolio_Website.Models;

namespace MVC_Portfolio_Website.Repositories
{
    public interface IEstateRepo
    {
        Estate AddEstate(Estate estate);
        List<Estate> GetEstates();
       

        //public interface IEstateRepo
        //{
        //    public List<Estate> GetEstates();
        //}
    }
}
