﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CankutayUcarAuthServer.Shared.Dtos;

namespace CankutayUcarAuthServer.Core.Services
{
    public interface IGenericService<TEntity, TDto>
    where TEntity : class where TDto : class
    {
        Task<Response<TDto>> GetByIdAsync(int id);
        Task<Response<IEnumerable<TDto>>> GetAllAsync();
        Task<Response<IEnumerable<TDto>>> Where(Expression<Func<TEntity, bool>> expression);
        Task<Response<TDto>> AddAsync(TDto dto);
        Task<Response<NoDataDto>> Remove(int id);
        Task<Response<NoDataDto>> Update(TDto dto, int id);
    }
}
