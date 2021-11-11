﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Contracts
{
    public interface IRepositoryBase<T> where T : class  // It means this interface is generic enough that I can pass any class in here
    {                                                    // and that class (table) should be able to perform any operations I want (CRUD)
        ICollection<T> FindAll();
        T FindById(int id);
        bool isExists(int id);                         // Icollection is a very generic class kind of like list, it can be almost any iterable
        bool Create(T entity);                           
        bool Update(T entity);
        bool Delete(T entity);
        bool Save();
    }                                                   
}
