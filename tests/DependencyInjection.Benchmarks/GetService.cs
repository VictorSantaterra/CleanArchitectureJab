using BenchmarkDotNet.Attributes;
using Core.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Repositories;
using Rest;

namespace DependencyInjection.Benchmarks;

[MemoryDiagnoser]
public class GetService
{
    private readonly ServicesProvider _serviceProvider;
    private readonly ServiceProvider _defaultServiceProvider;

    public GetService()
    {
        _serviceProvider = new ServicesProvider();
        
        ServiceCollection serviceCollection = new();
        serviceCollection.AddTransient<IUseCaseRepository, UseCaseRepository>();
        _defaultServiceProvider = serviceCollection.BuildServiceProvider();
    }

    [Benchmark]
    public void Default() => _defaultServiceProvider.GetService<IUseCaseRepository>();

    [Benchmark(Baseline = true)]
    public void Jab() => _serviceProvider.GetService<IUseCaseRepository>();
}