// ************************************************************************
// Copyright (c) 2025 AnishCeDev All Rights Reserved.
// Author: AnishCeDev
// ************************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnishCeDev.BookStore.ShoppingCart.Domain.ShoppingCartAggregate
{
    internal class Cart
    {
        public Guid CartId { get; private set; }
        public Guid UserId { get; private set; }
        public List<CartItem> Items { get; private set; }
        public decimal TotalPrice => CalculateTotal();

        public Cart(Guid cartId, Guid userId)
        {
            CartId = cartId;
            UserId = userId;
            Items = new List<CartItem>();
        }

        public void AddItem(Guid bookId, int quantity, decimal price)
        {
            var existing = Items.FirstOrDefault(i => i.BookId == bookId);
            if (existing != null) existing.Increase(quantity);
            else Items.Add(new CartItem(Guid.NewGuid(), CartId, bookId, quantity, price));
        }

        public void RemoveItem(Guid cartItemId) => Items.RemoveAll(i => i.CartItemId == cartItemId);
        public void ClearCart() => Items.Clear();
        private decimal CalculateTotal() => Items.Sum(i => i.Quantity * i.Price);

    }
}
