using app.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace ui.Features;

internal partial class Feature
{
    public static Task<bool> ViewProducts(IServiceProvider sp)
    {
        var productsRepository = sp.GetRequiredService<IProductsRepository>();
        var products = productsRepository.GetAll();

        Console.WriteLine("Here is the list of all our products");
        foreach (var product in products)
        {
            Console.WriteLine($"Id:\t{product.Id}");
            Console.WriteLine($"Name:\t{product.Name}");
            Console.WriteLine($"Price:\t{product.Price}");
            Console.WriteLine("___________________________________________");
        }

        return Task.FromResult(false);
    }
}
