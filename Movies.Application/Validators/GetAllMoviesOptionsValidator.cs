﻿using FluentValidation;
using Movies.Application.Models;

namespace Movies.Application.Validators;
public class GetAllMoviesOptionsValidator : AbstractValidator<GetAllMoviesOptions>
{
    private static readonly string[] AcceptableSortParameters = new[]
    {
        "title", "yearofrelease"
    };

    public GetAllMoviesOptionsValidator()
    {
        RuleFor(x => x.YearOfRelease).LessThanOrEqualTo(DateTime.UtcNow.Year);

        RuleFor(x => x.SortField)
            .Must( x=> x is null || AcceptableSortParameters.Contains(x, StringComparer.OrdinalIgnoreCase) )
            .WithMessage("You can only sort by title and yearofrelease");

        RuleFor(x => x.Page)
            .GreaterThanOrEqualTo(1);

        RuleFor(x => x.PageSize)
            .InclusiveBetween(1, 25)
            .WithMessage("You can get between 1 and 25 movies per page");

    }
}
