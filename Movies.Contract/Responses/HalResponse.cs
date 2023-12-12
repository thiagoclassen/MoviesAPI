﻿using System.Text.Json.Serialization;

namespace Movies.Contract.Responses;
public abstract class HalResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<Link> Links { get; set; } = new();
}

public class Link
{
    public required string Href { get; init; }
    public required string Rel { get; init; }
    public required string Type { get; init; }   
}