﻿namespace Movies.Contract.Requests;
public class GetAllMoviesRequest
{
    public required string? Title { get; init; }
    public required int? YearOfRelease { get; init; }
    public required string? SortBy { get; init;}
}