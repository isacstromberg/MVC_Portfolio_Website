using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MVC_Portfolio_Website.Models
{
    public class Estate
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Model { get; set; }

        public string Name { get; set; }

        public bool IsToggled { get; set; }
        public Estate(int id, string model,string name, bool istoggled)
        {
            Id = id;
            Model = model;
            Name = name;   
            IsToggled = istoggled;
        }


        public Estate()
        {

        }





    }
}
