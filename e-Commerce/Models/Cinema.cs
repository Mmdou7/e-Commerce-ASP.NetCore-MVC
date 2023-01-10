using System.ComponentModel.DataAnnotations;

namespace e_Commerce.Models
{
    public class Cinema
    {
        public int Id { get; set; }

        [Display(Name ="Cinema logo")]
        public string Logo { get; set; } = "";

        public string Name { get; set; } = "";

        public string Description { get; set; } = "";

        public List<Movie> movies { get; set; }
    }
}
