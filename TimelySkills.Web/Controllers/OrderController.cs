using Microsoft.AspNetCore.Mvc;
using TimelySkills.Core.DTOs;
using TimelySkills.Core.Interfaces;
using TimelySkills.Web.Models;

namespace TimelySkills.Web.Controllers;

public class OrderController : Controller
{
    private readonly IOrderService _orderService;

    public OrderController(IOrderService orderService) => _orderService = orderService;
    
    public IActionResult Index()
    {
        var orders = _orderService
            .GetAll()
            .ToList();
        
        return View(orders);
    }

    [HttpGet]
    public IActionResult AddOrder()
    {
        return View();
    }

    [HttpPost]
    public IActionResult AddOrder(OrderViewModel model)
    {
        if (!ModelState.IsValid) return View(model);

        var senderFIO = model.SenderFIO.Split(' ');
        var receiverFIO = model.ReceiverFIO.Split(' ');

        var dto = new OrderDTO
        {
            Sender = new Sender
            {
                SenderLastName = senderFIO[0],
                SenderFirstName = senderFIO[1],
                SenderPatronymic = senderFIO[2],
                SenderCity = model.SenderCity,
                SenderAddress = model.SenderAddress
            },
            Receiver = new Receiver
            {
                ReceiverLastName = receiverFIO[0],
                ReceiverFirstName = receiverFIO[1],
                ReceiverPatronymic = receiverFIO[2],
                ReceiverCity = model.ReceiverCity,
                ReceiverAddress = model.ReceiverAddress
            },
            Weight = model.Weight,
            DateOfDispatch = model.DateOfDispatch
        };

        _orderService.Create(dto);

        return RedirectToAction("Index", "Order");
    }
}