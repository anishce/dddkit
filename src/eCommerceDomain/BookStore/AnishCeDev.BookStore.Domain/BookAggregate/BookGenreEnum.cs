// ************************************************************************
// Copyright (c) 2025 AnishCeDev All Rights Reserved.
// Author: AnishCeDev
// ************************************************************************

namespace AnishCeDev.BookStore.Domain.BookAggregate
{
    using System.ComponentModel.DataAnnotations;

    public enum BookGenre
    {
        [Display(Name = "Fiction")]
        Fiction = 1,

        [Display(Name = "Fantasy")]
        Fantasy = 2,

        [Display(Name = "Mystery")]
        Mystery = 3,

        [Display(Name = "Romance")]
        Romance = 4,

        [Display(Name = "Horror")]
        Horror = 5,

        [Display(Name = "Science Fiction")]
        ScienceFiction = 6,

        [Display(Name = "Non-Fiction")]
        NonFiction = 7,

        [Display(Name = "Biography")]
        Biography = 8
    }

}