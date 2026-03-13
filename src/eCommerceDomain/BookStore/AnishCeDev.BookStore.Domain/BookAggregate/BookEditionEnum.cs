// ************************************************************************
// Copyright (c) 2025 AnishCeDev All Rights Reserved.
// Author: AnishCeDev
// ************************************************************************
namespace AjSys.DigitalBookShop.BookCatalog.Domain.BookAggregate
{
    using System.ComponentModel.DataAnnotations;

    public enum BookEdition
    {
        [Display(Name = "First Edition")]
        FirstEdition = 1,

        [Display(Name = "Second Edition")]
        SecondEdition = 2,

        [Display(Name = "Revised Edition")]
        RevisedEdition = 3,

        [Display(Name = "Special Edition")]
        SpecialEdition = 4,

        [Display(Name = "Collector's Edition")]
        CollectorsEdition = 5
    }

}