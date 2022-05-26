
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Display(Name = "Vacation Id")]
        [Required(ErrorMessage = "Please fill in id")] // server side
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        //foreign key
        public int CategoryId { get; set; }

        [Display(Name = "Vacation Name")]
        [Required(ErrorMessage = "Please fill in name")]
        [DataType(DataType.MultilineText)]
        [MaxLength(200, ErrorMessage = "Title of your trip.")]
        public string Name { get; set; }


        [Range(3, 30, ErrorMessage = "Please fill age in between 18 and 75!")]
        public int Days { get; set; }

        [Display(Name = "Description")]
        [DataType(DataType.MultilineText)]
        [MaxLength(200, ErrorMessage = "Summarize the trip.")]
        public string Description { get; set; }



        public string ImageName { get; set; }

        
        [DataType(DataType.Currency)]
        public double Price { get; set; }

        public Category Categories { get; set; }

        public string Buyer { get; set; }






    }
}
