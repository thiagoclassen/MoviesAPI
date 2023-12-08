﻿using Movies.Application.Models;

namespace Movies.Application.Services;
public interface IMovieService
{
    public Task<bool> CreateAsync(Movie movie, CancellationToken token = default);
    public Task<Movie?> GetByIdAsync(Guid id, Guid? userId = default, CancellationToken token = default);
    public Task<Movie?> GetBySlugAsync(string slug, Guid? userId = default, CancellationToken token = default);
    public Task<IEnumerable<Movie>> GetAllAsync(GetAllMoviesOptions options, CancellationToken token = default);
    public Task<Movie?> UpdateAsync(Movie movie, Guid? userId = default, CancellationToken token = default);
    public Task<bool> DeleteAsync(Guid id, CancellationToken token = default);
}
