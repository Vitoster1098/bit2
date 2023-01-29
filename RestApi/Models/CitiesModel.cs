using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestApi.Models
{
    [Table("Cities")]
    public class CitiesModel
    {
        [Display(Name = "Id города")]
        [Key]
        public int Id { get; set; }
        [Display(Name = "Название города")]
        [Required]
        [StringLength(100)]
        public string Name { get; set;}
        [NotMapped]
        public int StreetCount { get; set; }

        public CitiesModel(int Id, string Name) 
        { 
            this.Id = Id;            
            this.Name = Name;
            this.StreetCount = 0;
        }
    }
}
