using MVC_Portfolio_Website.Models;

namespace MVC_Portfolio_Website.Repositories
{

    public class MockData : IEstateRepo
    {
    
       private List<Estate> _estates = new List<Estate>
        {
            new Estate(1,"Stuga", "Kalles stuga", false),
            new Estate(2,"Stuga", "Annas stuga", true),
            new Estate(3,"Stuga", "Einars stuga", false)
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
