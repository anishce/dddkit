// ************************************************************************
// Copyright (c) 2025 AnishCeDev All Rights Reserved.
// Author: AnishCeDev
// ************************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnishCeDev.BookStore.Domain.BookAggregate
{
    internal class BookEdition
    {
        public Guid EditionId { get; private set; }
        public Guid BookId { get; private set; }
        public EditionFormat Format { get; private set; }
        public string Isbn { get; private set; }
        public int Pages { get; private set; }

        public BookEdition(Guid editionId, Guid bookId, EditionFormat format, string isbn, int pages)
        {
            EditionId = editionId;
            BookId = bookId;
            Format = format;
            Isbn = isbn;
            Pages = pages;
        }

    }
}
