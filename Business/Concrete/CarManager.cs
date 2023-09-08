using Busines.BusinessAspect.Autofac;
using Business.Abstrac;
using Business.ValidationRules.FluentValidation;
using Core.Aspect.Autofac.Validation;
using Core.Utilities.Result;
using Core.Utilities.Results;
using DataAccess.Abstrac;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        [ValidationAspect(typeof(CarValidater))]
        [SecuredOperation("product.add,admin")]
        public IResult Add(Car car)
        {
            _carDal.Add(car);
            return new SuccesResult();
        }

        public IResult Delete(Car car)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetAll()
        {
             return new SuccessDataResult<List<Car>>(_carDal.GetAll(),"Başarıyla listelendi");
        }

        public IDataResult<Car> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
