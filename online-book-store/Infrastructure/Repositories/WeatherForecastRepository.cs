using OnlineBookStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using OnlineBookStore.Domain.Repositories;

namespace OnlineBookStore.Infrastructure.Repositories;

public class WeatherForecastRepository(TodoContext context) : IWeatherForecastRepository
{
    /*public async Task<IEnumerable<WeatherForecast>> GetAllAsync()
    {
        return await context.WeatherForecasts
            .Include(w => w.Region)
            .ToListAsync();
    }

    public async Task<int> AddAsync(WeatherForecast entity)
    {
        await context.WeatherForecasts.AddAsync(entity);
        await context.SaveChangesAsync();
        return entity.Id;
    }

    public async Task<WeatherForecast?> GetById(int id)
    {
        return await context.WeatherForecasts
            .Include(w => w.Region)
            .FirstOrDefaultAsync(forecast => forecast.Id == id);
    }
    */
}
