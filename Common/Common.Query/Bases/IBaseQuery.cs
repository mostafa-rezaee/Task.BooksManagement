using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Query.Bases
{
    public interface IBaseQuery<TResponse> : IRequest<TResponse> where TResponse : class?
    {
    }
}
