using TimelySkills.Core.Entities;
using TimelySkills.Core.Interfaces;
using TimelySkills.Infrastructure.Context;

namespace TimelySkills.Infrastructure.Repositories;

public sealed class OrderRepository : IOrderRepository
{
    private readonly ApplicationDbContext _dbContext;

    public OrderRepository(ApplicationDbContext dbContext) => _dbContext = dbContext;


    public IEnumerable<Order> GetAll()
    {
        return _dbContext.Orders.ToList();
    }

    public void AddOrder(Order order)
    {
        _dbContext.Orders.Add(order);
    }

    public void SaveChanges()
    {
        _dbContext.SaveChanges();
    }
}