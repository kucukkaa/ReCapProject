﻿using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using DataAccess.Abstract;
using DataAccess.Abstract;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {

        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public List<Brand> GetBrands()
        {
            return _brandDal.GetAll();
        }
    }
}
