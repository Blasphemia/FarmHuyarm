using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                var milk = new Product { Name = "Milk", Weight = 5 };
                var egg = new Product { Name = "Egg", Weight = 1 };
                var wool = new Product { Name = "Wool", Weight = 2 };
                var cow = new Animal { Name = "Cow", Product = milk };
                var chicken = new Animal { Name = "Chicken", Product = egg };
                var sheep = new Animal { Name = "Sheep", Product = wool };
                var barn = new Building { Name = "Barn", AnimalRoominess = 2, Square = 50, Animals = new List<Animal>() };

                barn.Animals.Add(chicken);
                barn.Animals.Add(chicken);

                var yard = new Building { Name = "Yard", AnimalRoominess = 5, Square = 200 , Animals = new List<Animal>() };

                yard.Animals.Add(chicken);
                yard.Animals.Add(sheep);
                yard.Animals.Add(sheep);
                yard.Animals.Add(cow);

                var paddock = new Building { Name = "Paddock", AnimalRoominess = 3, Square = 150, Animals = new List<Animal>() };

                paddock.Animals.Add(cow);
                paddock.Animals.Add(cow);
                paddock.Animals.Add(sheep);

                var potato = new Plant { Name = "Potato", SeasonLanding = "Spring", Square = 5, SeasonGathering = "Autumn" };
                var corn = new Plant { Name = "Corn", SeasonLanding = "Spring", Square = 3, SeasonGathering = "Summer" };
                var tomato = new Plant { Name = "Tomato", SeasonLanding = "Summer", Square = 2, SeasonGathering = "Autumn" };

                var gardenBedFirst = new GardenBed { Square = 100, Plants = new List<Plant>() };

                gardenBedFirst.Plants.Add(potato);
                gardenBedFirst.Plants.Add(potato);
                gardenBedFirst.Plants.Add(potato);

                var gardenBedSecond = new GardenBed { Square = 70, Plants = new List<Plant>() };

                gardenBedSecond.Plants.Add(corn);
                gardenBedSecond.Plants.Add(corn);
                gardenBedSecond.Plants.Add(corn);

                var gardenBedThird = new GardenBed { Square = 50, Plants = new List<Plant>() };

                gardenBedThird.Plants.Add(tomato);
                gardenBedThird.Plants.Add(tomato);
                gardenBedThird.Plants.Add(tomato);

                var farm = new Farm { Name = "Huyarm", Square = 10000, Buildings = new List<Building>(), GardenBeds = new List<GardenBed>() };

                farm.Buildings.Add(barn);
                farm.Buildings.Add(yard);
                farm.Buildings.Add(paddock);
                farm.GardenBeds.Add(gardenBedFirst);
                farm.GardenBeds.Add(gardenBedSecond);
                farm.GardenBeds.Add(gardenBedThird);


                Console.WriteLine($"Farm name - {farm.Name}, " +
                    $"square = {farm.Square.ToString()}, buildings = {farm.Buildings.Count}");

                


                Console.ReadKey();
            }

        }
    }
}
