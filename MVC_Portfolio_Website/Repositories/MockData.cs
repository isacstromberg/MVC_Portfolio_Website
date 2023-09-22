using MVC_Portfolio_Website.Models;

namespace MVC_Portfolio_Website.Repositories
{

    public class MockData : IEstateRepo
    {
    
        private List<Estate> _estates = new List<Estate>
        {
            new Estate(1),
            new Estate(2),
            new Estate(3)
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
