using MVC_Portfolio_Website.Models;

namespace MVC_Portfolio_Website.ViewModels
{
    public class HomeViewModel
    {
        public List<Estate> Estates { get; set; }

        public int SelectedEstate { get; set; }
        
        public List<Estate> DisplayedEstates { get; set; }

    }
}
