using MVC_Portfolio_Website.Models;

namespace MVC_Portfolio_Website.Repositories
{

    public class MockData : IEstateRepo
    {
    
        private List<Estate> _estates = new List<Estate>
        {
            new Estate(1,"Stuga"),
            new Estate(2,"Stuga"),
            new Estate(3,"Stuga")
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

    }
}
