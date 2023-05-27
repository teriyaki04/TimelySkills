using TimelySkills.Core.Entities;

namespace TimelySkills.Core.Interfaces;

public interface IOrderRepository
{
    IEnumerable<Order> GetAll();
    void AddOrder(Order order);
    void SaveChanges();
}