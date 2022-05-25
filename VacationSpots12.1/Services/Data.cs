using System.Collections.Generic;
using VacationSpots12._1.Models;

namespace VacationSpots12._1.Services
{
    public class Data : IData
    {
        public List<Vacation> Vacations { get; set; }

        //constructor

        public Data()
        {
            Vacations = new List<Vacation>()
            {
                new Vacation()
                {
                    Id = 1,
                    Name ="African Safari",
                    Days = 5,
                    Description ="Get chased by lions and cheetahs while getting head banged inside a tiny jeep wrangler!",
                    ImageName ="africa.jpg",
                    Price = "$6000",
                    Categories = Category.Outback
                },
                new Vacation()
                {
                    Id = 2,
                    Name ="Kangaroo Boxing",
                    Days = 7,
                    Description ="Front row seat watching Kangaroos amateur boxing fights.",
                    ImageName ="australia.jpg",
                    Price = "$8000",
                    Categories = Category.Backpacking
                },
                new Vacation()
                {
                    Id = 3,
                    Name ="Indonesian Vitamin Sea",
                    Days = 7,
                    Description =" Enjoy fresh seafood after exploring the coral reef. ",
                    ImageName ="indonesia.jpg",
                    Price = "$5000",
                    Categories = Category.Island
                },
                new Vacation()
                {
                    Id = 4,
                    Name ="Elope in Italy ",
                    Days = 4,
                    Description = "Perfect location for a quick rendezvous with your boo! ",
                    ImageName ="italy.jpg",
                    Price = "$5000",
                    Categories = Category.City
                },
                 new Vacation()
                 {
                    Id = 5,
                    Name = "Free climb El Capitan.",
                    Days = 3,
                    Description ="Experience full force adrenaline pump! ",
                    ImageName ="usa.jpg",
                    Price = "$1000",
                    Categories = Category.Backpacking
                 }
            };
        }


        public void AddVacation(Vacation vacation)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteVacation(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Vacation GetVacation(int? id)
        {
            if (id == null)
            {
                return null;

            }
            else
            {

                return Vacations.Find(x => x.Id == id);

            }

        }

        public List<Vacation> ReadAll()
        {
            return Vacations;
        }

        public void UpdateVacation(Vacation vacation)
        {
            throw new System.NotImplementedException();
        }
    }
}
