using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DataAccessLayer.Abstract;
using RealHouzing.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.BusinessLayer.Concrete
{
    public class FindManager : IFindService
    {
        private readonly IFindDal _findDal;

        public FindManager(IFindDal findDal)
        {
            _findDal = findDal;
        }

        public void TDelete(Find t)
        {
            _findDal.Delete(t);
        }

        public Find TGetById(int id)
        {
            return _findDal.GetById(id);
        }

        public List<Find> TGetList()
        {
            return _findDal.GetList();
        }

        public void TInsert(Find t)
        {
            _findDal.Insert(t);
        }

        public void TUpdate(Find t)
        {
            _findDal.Update(t);
        }
    }
}
