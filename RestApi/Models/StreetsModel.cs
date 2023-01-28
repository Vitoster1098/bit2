namespace RestApi.Models
{
    public class StreetsModel
    {
        public int Id { get; set; }
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
