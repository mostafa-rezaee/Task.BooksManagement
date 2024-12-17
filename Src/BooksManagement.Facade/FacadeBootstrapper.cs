using BooksManagement.Facade.Authors;
using BooksManagement.Facade.Books;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksManagement.Facade
{
    public class FacadeBootstrapper
    {
        public static void InitialaizeFacadeDependency(IServiceCollection services)
        {
            services.AddScoped<IAuthorFacade, AuthorFacade>();
            services.AddScoped<IBookFacade, BookFacade>();
        }
    }
}
