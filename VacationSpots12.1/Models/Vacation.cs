namespace VacationSpots12._1.Models
{

    public enum Category
    {
        Backpacking,
        Outback,
        City,
        Island

    }




    public class Vacation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Days { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }
        public string Price { get; set; }   
        public Category Categories { get; set; }






    }
}
