﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain.Bases
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task<T?> GetTrackingAsync(Guid id);
        Task AddAsync(T entity);
        Task<int> SaveAsync();
    }
}