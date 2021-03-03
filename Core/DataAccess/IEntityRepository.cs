﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //generic constraint - T yerine yazacağımız şeyleri kısıtlar.
    //class : referans tip olabilir demek
    //IEntity :  IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
    //new() : new'lenebilir olmalı
    public interface IEntityRepository<T> where T: class, IEntity,new()
    {
        //GetAll'u kullandığımız zaman bir koşula göre çağırmayı sağlıyor.
        List<T> GetAll(Expression<Func<T,bool>> filter=null); 
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}