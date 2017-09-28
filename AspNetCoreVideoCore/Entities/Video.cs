using AspNetCoreVideoCore.Models;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreVideoCore.Entities
{
    public class Video
    {
        public int Id { get; set; }
        [Required, MinLength(3), MaxLength(80)]
        public string Title { get; set; }
        [Display(Name = "Film Genre")]
        public Genres Genre { get; set; }
    }
}
