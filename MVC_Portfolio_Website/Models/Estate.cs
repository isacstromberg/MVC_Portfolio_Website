namespace MVC_Portfolio_Website.Models
{
    public class Estate
    {
        public string Model { get; set; }

        public int Id { get; set; }
        public Estate(int id, string model)
        {
            Id = id;
            Model = model;
        }

     
    }
}
