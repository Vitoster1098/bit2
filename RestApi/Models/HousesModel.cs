namespace RestApi.Models
{
    public class HousesModel
    {
        public int Id { get; set; }
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
