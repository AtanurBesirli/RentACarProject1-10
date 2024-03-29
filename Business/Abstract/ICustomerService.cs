﻿using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<List<Customer>> GetAll();

        IDataResult<Customer> GetByCustomerId(int id);

        IResult Add(Customer customer);
        IResult Remove(Customer customer);
        IResult Update(Customer customer);
        IResult AddTransactionalTest(Customer customer);
    }
}
