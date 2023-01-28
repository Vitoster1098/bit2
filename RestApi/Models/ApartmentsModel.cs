using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestApi.Models
{
    [Table("Apartments")]
    public class ApartmentsModel
    {
        [Display(Name = "Id квартиры")]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Площадь")]
        public float Area { get; set; }
        public int House_id { get; set; }

        public ApartmentsModel(int Id, float Area, int House_id)
        {
            this.Id = Id;
            this.Area = Area;
            this.House_id = House_id;
        }
    }
}
