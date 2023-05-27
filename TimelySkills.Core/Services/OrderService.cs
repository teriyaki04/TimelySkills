using AutoMapper;
using TimelySkills.Core.DTOs;
using TimelySkills.Core.Entities;
using TimelySkills.Core.Interfaces;

namespace TimelySkills.Core.Services;

public class OrderService : IOrderService
{
    private readonly IOrderRepository _orderRepository;
    private readonly IMapper _mapper = AutoMapperConfig.Mapper;

    public OrderService(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public IEnumerable<OrderDTO> GetAll()
    {
        var orders = _orderRepository.GetAll();
        var ordersDTO = orders
            .Select(o => _mapper.Map<Order, OrderDTO>(o))
            .ToList();

        return ordersDTO;
    }

    public void Create(OrderDTO dto)
    {
        var order = _mapper.Map<OrderDTO, Order>(dto);

        _orderRepository.AddOrder(order);
        _orderRepository.SaveChanges();
    }
}