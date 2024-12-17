using BooksManagement.Application.AuthorCommands.Add;
using BooksManagement.Facade;
using BooksManagement.Infrastructure;
using BooksManagement.Query.AuthorQueries.GetAll;
using Microsoft.Extensions.DependencyInjection;

namespace BooksManagement.Config
{
    public static class BooksMngBootstrapper
    {
        public static void RegisterBooksMngDependency(this IServiceCollection services, string connectionString)
        {
            //Infrastructure
            InfrastructureBootstrapper.BootstrappInfrastructure(services, connectionString);

            //MediatR
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(AddAuthorCommand).Assembly));
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(GetAllAuthorQuery).Assembly));

            //Facade dependency
            FacadeBootstrapper.InitialaizeFacadeDependency(services);
        }
    }
}
