using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TimelySkills.Core.Entities;

namespace TimelySkills.Infrastructure.Configurations;

internal sealed class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {

        builder.HasKey(o => o.OrderId); 

        builder.Property(o => o.SenderFirstName)
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(o => o.SenderLastName)
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(o => o.SenderPatronymic)
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(o => o.SenderCity)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(o => o.SenderAddress)
            .HasMaxLength(200)
            .IsRequired();

        builder.Property(o => o.ReceiverFirstName)
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(o => o.ReceiverLastName)
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(o => o.ReceiverPatronymic)
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(o => o.ReceiverCity)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(o => o.ReceiverAddress)
            .HasMaxLength(200)
            .IsRequired();

        builder.Property(o => o.Weight)
            .IsRequired();

        builder.Property(o => o.DateOfDispatch)
            .IsRequired();
    }
}