using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        //private List<Car> _cars;
        //public InMemoryCarDal()
        //{
        //    _cars = new List<Car>
        //    {
        //        new Car{Id = 1,BrandId = 1,ColorId = 1,DailyPrice = 600,ModelYear = 2020,Description = "Abs, Yolcu Airbag,27 Yaþ Üstü,Ehliyet Yaþý 5 ve üzeri"},
        //        new Car{Id = 2,BrandId =1,ColorId = 2,DailyPrice = 220,ModelYear = 2015,Description = "Abs, Yolcu Airbag,23 Yaþ Üstü,Ehliyet Yaþý 1 ve üzeri"},
        //        new Car{Id = 3,BrandId = 2,ColorId = 2,DailyPrice = 300,ModelYear = 2017,Description = "Abs, Yolcu Airbag,25 Yaþ Üstü,Ehliyet Yaþý 3 ve üzeri"},
        //        new Car{Id = 4,BrandId = 2,ColorId = 3,DailyPrice = 350,ModelYear = 2019,Description = "Abs, Yolcu Airbag,21 Yaþ Üstü,Ehliyet Yaþý 2 ve üzeri"},
        //        new Car{Id = 5,BrandId =2,ColorId = 3,DailyPrice = 400,ModelYear = 2019,Description = "Abs, Yolcu Airbag,25 Yaþ Üstü,Ehliyet Yaþý 2 ve üzeri"},
        //        new Car{Id = 6,BrandId =3,ColorId = 5,DailyPrice = 200,ModelYear = 2015,Description = "Abs, Yolcu Airbag,30 Yaþ Üstü,Ehliyet Yaþý 1 ve üzeri"}
        //    };
        //}
        //public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        //{
        //    throw new NotImplementedException();
        //}

        //public Car Get(Expression<Func<Car, bool>> filter)
        //{
        //    throw new NotImplementedException();
        //}
        //public List<Car> GetAll()
        //{
        //    return _cars;
        //}



        //public Car GetById(int Id)
        //{
        //    Car carToFind= _cars.SingleOrDefault(p => p.Id == Id);
        //    return carToFind;
        //}


        //public void Add(Car car)
        //{
        //    _cars.Add(car);
        //}

        //public void Delete(Car car)
        //{
        //    Car carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
        //    _cars.Remove(carToDelete);
        //}

        //public void Update(Car car)
        //{
        //    Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);

        //    carToUpdate.Id = car.Id;
        //    carToUpdate.BrandId = car.BrandId;
        //    carToUpdate.ColorId = car.ColorId;
        //    carToUpdate.DailyPrice = car.DailyPrice;
        //    carToUpdate.ModelYear = car.ModelYear;
        //    carToUpdate.Description = car.Description;
        //}
        public void Add(Car entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            throw new NotImplementedException();
        }
    }
}