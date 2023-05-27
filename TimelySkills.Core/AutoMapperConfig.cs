using AutoMapper;
using TimelySkills.Core.DTOs;
using TimelySkills.Core.Entities;

namespace TimelySkills.Core;

internal static class AutoMapperConfig
{
    private static MapperConfiguration _mapperConfiguration;
    private static IMapper _mapper;

    public static IMapper Mapper => _mapper ??= MapperConfiguration.CreateMapper();

    private static MapperConfiguration MapperConfiguration
    {
        get
        {
            if (_mapperConfiguration == null)
            {
                CreateMapperConfiguration();
            }

            return _mapperConfiguration;
        }
    }

    private static void CreateMapperConfiguration()
    {
        _mapperConfiguration = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Order, OrderDTO>()
                .ForMember(i => i.Sender,
                    d => d.MapFrom(c => new Sender
                    {
                        SenderFirstName = c.SenderFirstName,
                        SenderLastName = c.SenderLastName,
                        SenderPatronymic = c.SenderPatronymic,
                        SenderCity = c.SenderCity,
                        SenderAddress = c.SenderAddress
                    }))
                .ForMember(i => i.Receiver,
                    d => d.MapFrom(c => new Receiver
                    {
                        ReceiverFirstName = c.ReceiverFirstName,
                        ReceiverLastName = c.ReceiverLastName,
                        ReceiverPatronymic = c.ReceiverPatronymic,
                        ReceiverCity = c.ReceiverCity,
                        ReceiverAddress = c.ReceiverAddress
                    }));
            cfg.CreateMap<OrderDTO, Order>()
                .ForMember(i => i.SenderFirstName,
                    d => d.MapFrom(c => c.Sender.SenderFirstName))
                .ForMember(i => i.SenderLastName,
                    d => d.MapFrom(c => c.Sender.SenderLastName))
                .ForMember(i => i.SenderPatronymic,
                    d => d.MapFrom(c => c.Sender.SenderPatronymic))
                .ForMember(i => i.SenderCity,
                    d => d.MapFrom(c => c.Sender.SenderCity))
                .ForMember(i => i.SenderAddress,
                    d => d.MapFrom(c => c.Sender.SenderAddress))
                .ForMember(i => i.ReceiverFirstName,
                    d => d.MapFrom(c => c.Receiver.ReceiverFirstName))
                .ForMember(i => i.ReceiverLastName,
                    d => d.MapFrom(c => c.Receiver.ReceiverLastName))
                .ForMember(i => i.ReceiverPatronymic,
                    d => d.MapFrom(c => c.Receiver.ReceiverPatronymic))
                .ForMember(i => i.ReceiverCity,
                    d => d.MapFrom(c => c.Receiver.ReceiverCity))
                .ForMember(i => i.ReceiverAddress,
                    d => d.MapFrom(c => c.Receiver.ReceiverAddress));
        });
    }
}