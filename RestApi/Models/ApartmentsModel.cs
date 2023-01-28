namespace RestApi.Models
{
    public class ApartmentsModel
    {
        public int Id { get; set; }
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
