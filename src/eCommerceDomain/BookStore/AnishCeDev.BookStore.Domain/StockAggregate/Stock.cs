using AnishCeDev.BookStore.Domain.StockAggregate;
using AnishCeDev.Ddd.Infra.DomainBase;
using System;

public class Stock : EntityBase<Guid>, IAggregateRoot
{
    public Stock(Guid id, Guid bookId, int quantity, Guid locationId, int version) : base(id,version)
    {
        BookId = bookId;
        Quantity = quantity;
        LocationId = locationId;

        base.ThrowExceptionIfInvalid();
    }

    public Guid BookId { get; set; }
    public int Quantity { get; set; }
    public Guid LocationId { get; set; }

    protected override void Validate()
    {
        if(Quantity < 0)
        {
            base.AddBrokenValidationRule(StockBusinessRule.QuantityMustNotBeNegative);
        }
    }
}
