using Core.DataAccess.EntityFreamwork;
using DataAccess.Abstrac;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFreamwork
{
    public class EfColorDal : EfRepositoryBase<Color, CarDbContext>, IColorDal
    {
    }
}
