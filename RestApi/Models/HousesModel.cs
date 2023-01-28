using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestApi.Models
{
    [Table("Houses")]
    public class HousesModel
    {
        [Display(Name = "Id города")]
        public int Id { get; set; }
        [Display(Name = "Номер дома")]
        [Required]
        [StringLength(50)]
        public string Number{ get; set; }
        public int Street_id { get; set; }

        public HousesModel(int Id, string Number, int Street_id)
        {
            this.Id = Id;
            this.Number = Number;
            this.Street_id = Street_id;
        }
    }
}
