﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShift_App.Model;

namespace EShift_App.Data.Repositories
{
    internal interface ICustomerRepository:IRepository<Customer>
    {
        Task<Customer?> GetCustomerByPhoneNumberAsync(string phoneNumber);
    }
}
