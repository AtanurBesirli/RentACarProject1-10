﻿using Core.Utilities.Results;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IDataResult<List<CarImage>> GetAll();

        IDataResult<CarImage> GetById(int id);
        IDataResult<List<CarImage>> GetByCarId(int carId);

        IResult Add(CarImage carImage, IFormFile file);
        IResult Remove(CarImage carImage);
        IResult Update(CarImage carImage, IFormFile file);
        
    }
}
