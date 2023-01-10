using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_Commerce.Models
{
    public class Actor
    {
        public int Id { get; set; }
        
        [Display(Name ="Profile Picture")]
        public string ProfilePictureURL { get; set; } = "";

        [Display(Name = "Full Name")]
        public string FullName { get; set; } = "";

        [Display(Name = "Biography")]
        public string Bio { get; set; } = "";

        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
