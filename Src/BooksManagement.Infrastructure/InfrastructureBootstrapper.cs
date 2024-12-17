using BooksManagement.Domain.Repositories;
using BooksManagement.Infrastructure.EFCore;
using BooksManagement.Infrastructure.EFCore.AuthorConfings;
using BooksManagement.Infrastructure.EFCore.BookConfigs;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksManagement.Infrastructure
{
    public class InfrastructureBootstrapper
    {
        public static void BootstrappInfrastructure(IServiceCollection services, string connectionString)
        {
            services.AddTransient<IAuthorRepository, AuthorRepository>();
            services.AddTransient<IBookRepository, BookRepository>();
            services.AddDbContext<BooksContext>(optionsAction: options => {
                options.UseSqlServer(connectionString);
            });
        }
    }
}
