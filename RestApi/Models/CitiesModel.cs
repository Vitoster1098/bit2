namespace RestApi.Models
{
    public class CitiesModel
    {
        public int Id { get; set; }
        public string Name { get; set;}

        public CitiesModel(int Id, string Name) 
        { 
            this.Id = Id;
            this.Name = Name;
        }
    }
}
