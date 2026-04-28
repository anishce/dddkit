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
    internal class CartItem
    {
        public Guid CartItemId { get; private set; }
        public Guid CartId { get; private set; }
        public Guid BookId { get; private set; }
        public int Quantity { get; private set; }
        public decimal Price { get; private set; }

        public CartItem(Guid cartItemId, Guid cartId, Guid bookId, int quantity, decimal price)
        {
            CartItemId = cartItemId;
            CartId = cartId;
            BookId = bookId;
            Quantity = quantity;
            Price = price;
        }

        public void Increase(int amount) => Quantity += amount;
        public void Decrease(int amount)
        {
            Quantity -= amount;
            if (Quantity < 0) Quantity = 0;
        }

    }
}
