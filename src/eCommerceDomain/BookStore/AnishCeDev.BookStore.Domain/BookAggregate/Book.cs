// ************************************************************************
// Copyright (c) 2025 AnishCeDev All Rights Reserved.
// Author: AnishCeDev
// ************************************************************************

// Ignore Spelling: Aj

using AjSys.DigitalBookShop.BookCatalog.Domain.CategoryAggregate;
using AjSys.DigitalBookShop.BookCatalog.Domain.PublisherAggregate;
using AjSys.DigitalBookShop.BookCatalog.Infrastructure.DomainBase;
using System;

namespace AjSys.DigitalBookShop.BookCatalog.Domain.BookAggregate
{
    public class Book : EntityBase<Guid>, IAggregateRoot
    {
        public Book(Guid id, string title, string author, BookVariant variant, BookGenre genre, Category category, string description, 
            Publisher publisher, decimal price, BookEdition edition, int stock, int version) : base(id, version)
        {
            Title= title;
            Author= author;
            Variant= variant;
            Genre = Genre;
            Category= category;
            Description= description;
            Publisher= publisher;
            Price= price;
            Edition= edition;
            Stock= stock;
        }


        public string Title { get; private set; }

        public string Author { get; private set; }

        public BookVariant Variant { get; private set; }

        //A literary or stylistic classification based on content, tone, or narrative form.
        //Fiction,Fantasy,Mystery,Romance,Horror,ScienceFiction,NonFiction,Biography
        public BookGenre Genre { get; private set; }

        //A high-level classification for business or organizational purposes.
        //“Fiction” + “New Arrival”, "Top Rated", "Children's Books"
        public Category Category { get; private set; }

        public string Description { get; private set; }

        public Publisher Publisher { get; private set; }

        public decimal Price { get; private set; }

        public BookEdition Edition { get; private set; }

        public int Stock { get; private set; }

        public float Rating { get; private set; }

        protected override void ValidateEntity()
        {
            if (!Guid.TryParse(Id.ToString(), out _))
            {
                base.AddBrokenValidationRule("A book Id must be valid unique id.");
            }

            if (string.IsNullOrWhiteSpace(Title))
            {
                base.AddBrokenValidationRule("A book must have title.");
            }

            if (string.IsNullOrWhiteSpace(Author))
            {
                base.AddBrokenValidationRule("A book must have author.");
            }
        }

        public void UpdateStock()
        {

        }
        
        public void UpdatePrice()
        {

        }
        
        public void UpdateMetaData()
        {

        }
    }
}
