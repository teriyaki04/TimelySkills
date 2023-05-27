using TimelySkills.Core.DTOs;

namespace TimelySkills.Core.Interfaces;

public interface IOrderService
{
    IEnumerable<OrderDTO> GetAll();

    void Create(OrderDTO dto);
}