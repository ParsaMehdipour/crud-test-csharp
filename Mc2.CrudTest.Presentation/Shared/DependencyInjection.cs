using FluentValidation;
using Mc2.CrudTest.Shared.Behaviors;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Mc2.CrudTest.Shared
{
    public static class DependencyInjection
    {
        public static void SetupSharedApplication(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();

            services.AddMediatR(assembly);

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationPipelineBehavior<,>));

            services.AddValidatorsFromAssembly(assembly);
        }
    }
}
