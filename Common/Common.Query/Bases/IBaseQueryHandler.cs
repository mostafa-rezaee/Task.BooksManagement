using MediatR;

namespace Common.Query.Bases
{
    public interface IBaseQueryHandler<TQuery, TResponse> : IRequestHandler<TQuery, TResponse> 
        where TQuery : IBaseQuery<TResponse> 
        where TResponse : class?
    {

    }
}
