using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestApi.Models
{
    [Table("Streets")]
    public class StreetsModel
    {
        [Display(Name = "Id улицы")]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name = "Название улицы")]
        public string Name { get; set; }
        public int City_id { get; set; }

        public StreetsModel(int Id, string Name, int City_id)
        {
            this.Id = Id;
            this.Name = Name;
            this.City_id = City_id;
        }
    }
}
