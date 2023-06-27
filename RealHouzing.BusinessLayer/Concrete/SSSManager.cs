﻿using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DataAccessLayer.Abstract;
using RealHouzing.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.BusinessLayer.Concrete
{
    public class SSSManager : ISSSService
    {
        private readonly ISSSDal _sSSDal;

        public SSSManager(ISSSDal sSSDal)
        {
            _sSSDal = sSSDal;
        }

        public void TDelete(SSS t)
        {
            _sSSDal.Delete(t);
        }

        public SSS TGetById(int id)
        {
            return _sSSDal.GetById(id); 
        }

        public List<SSS> TGetList()
        {
            return _sSSDal.GetList();
        }

        public void TInsert(SSS t)
        {
            _sSSDal.Insert(t);
        }

        public void TUpdate(SSS t)
        {
            _sSSDal.Update(t);
        }
    }
}
