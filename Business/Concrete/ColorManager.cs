using Business.Abstrac;
using Core.Utilities.Result;
using Core.Utilities.Results;
using DataAccess.Abstrac;
using DataAccess.Concrete.EntityFreamwork;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal= colorDal;
        }

        public IResult Add(Color color)
        {
            _colorDal.Add(color);
            return new SuccesResult();
        }

        public IResult Delete(Color color)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(),"Ürünler listelendi");

        }

        public IDataResult<Color> GetById(int id)
        {
           return new SuccessDataResult<Color>(_colorDal.Get(p=>p.ColorId == id));
        }

        public IResult Update(Color color)
        {
            throw new NotImplementedException();
        }
    }
}
