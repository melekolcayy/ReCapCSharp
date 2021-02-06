using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());




            Console.WriteLine("BrandId=1 Olan Arabalar: \nId\tColor Name\tBrand Name\tModel Year\tDaily Price\tDescriptions");
            foreach (var car in carManager.GetAllByBrandId(1))
            {
                Console.WriteLine($"{car.CarId}\t{colorManager.GetById(car.ColorId).ColorName}\t\t{brandManager.GetById(car.BrandId).BrandName}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Descriptions}");
            }

            Console.WriteLine("\n\nColorId=2 Olan Arabalar: \nId\tColor Name\tBrand Name\tModel Year\tDaily Price\tDescriptions");
            foreach (var car in carManager.GetAllByColorId(2))
            {
                Console.WriteLine($"{car.CarId}\t{colorManager.GetById(car.ColorId).ColorName}\t\t{brandManager.GetById(car.BrandId).BrandName}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Descriptions}");
            }

            Console.WriteLine("\n\nID=2 Olan Arabalar: \nId\tColor Name\tBrand Name\tModel Year\tDaily Price\tDescriptions");
            Car carById = carManager.GetById(2);
            Console.WriteLine($"{carById.CarId}\t{colorManager.GetById(carById.ColorId).ColorName}\t\t{brandManager.GetById(carById.BrandId).BrandName}\t\t{carById.ModelYear}\t\t{carById.DailyPrice}\t\t{carById.Descriptions}");


            Console.WriteLine("\n\nGünlük Fiyatı 100-165 Arası Olan Arabalar: \nId\tColor Name\tBrand Name\tModel Year\tDaily Price\tDescriptions");
            foreach (var car in carManager.GetByDailyPrice(100, 165))
            {
                Console.WriteLine($"{car.CarId}\t{colorManager.GetById(car.ColorId).ColorName}\t\t{brandManager.GetById(car.BrandId).BrandName}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Descriptions}");
            }

            Console.WriteLine("\n");

            carManager.Add(car: new Car { BrandId = 1, ColorId = 2, DailyPrice = -300, ModelYear = 2021, Descriptions = "Otomatik Dizel" });
            brandManager.Add(new Brand { BrandName = "a" });

        }
    }
}