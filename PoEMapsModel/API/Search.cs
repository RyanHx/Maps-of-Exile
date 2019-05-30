namespace PoEMapsModel.API
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class SearchModel
    {
        [JsonProperty("query")]
        public Query Query { get; set; }

        [JsonProperty("sort")]
        public Sort Sort { get; set; }

        public SearchModel()
        {
            Query = new Query();
            Sort = new Sort();
        }
    }

    public partial class Query
    {
        [JsonProperty("status")]
        public Status Status { get; set; }

        //[JsonProperty("term")]
        //public string Term { get; set; }

        [JsonProperty("name")]
        public Name Name { get; set; }

        [JsonProperty("type")]
        public Name Type { get; set; }

        [JsonProperty("stats")]
        public List<Stat> Stats { get; set; }

        [JsonProperty("filters")]
        public QueryFilters Filters { get; set; }

        public Query()
        {
            Status = new Status();
            Name = new Name();
            Type = new Name();
            Stats = new List<Stat>();
            Filters = new QueryFilters();
        }
    }

    public partial class QueryFilters
    {
        [JsonProperty("type_filters")]
        public TypeFilters TypeFilters { get; set; }

        [JsonProperty("map_filters")]
        public MapFilters MapFilters { get; set; }

        public QueryFilters()
        {
            TypeFilters = new TypeFilters();
            MapFilters = new MapFilters();
        }
    }

    public partial class MapFilters
    {
        [JsonProperty("filters")]
        public MapFiltersFilters Filters { get; set; }

        public MapFilters()
        {
            Filters = new MapFiltersFilters();
        }
    }

    public partial class MapFiltersFilters
    {
        [JsonProperty("map_tier")]
        public MapTier MapTier { get; set; }

        public MapFiltersFilters()
        {
            MapTier = new MapTier();
        }
    }

    public partial class MapTier
    {
        [JsonProperty("max")]
        public long Max { get; set; }
    }

    public partial class TypeFilters
    {
        [JsonProperty("filters")]
        public TypeFiltersFilters Filters { get; set; }

        public TypeFilters()
        {
            Filters = new TypeFiltersFilters();
        }
    }

    public partial class TypeFiltersFilters
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        public TypeFiltersFilters()
        {
            Category = "map";
        }
    }

    public partial class Status
    {
        [JsonProperty("option")]
        public string Option { get; set; }

        public Status()
        {
            Option = "online";
        }
    }

    public partial class Name
    {
        [JsonProperty("option")]
        public string Option { get; set; }

        [JsonProperty("discriminator")]
        public string Discriminator { get; set; }

        public Name()
        {
            Discriminator = "warfortheatlas";
        }
    }

    public partial class Stat
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("disabled")]
        public bool Disabled { get; set; }

        public Stat()
        {
            Type = "and";
            Disabled = true;
        }
    }

    public partial class Sort
    {
        [JsonProperty("price")]
        public string Price { get; set; }

        public Sort()
        {
            Price = "asc";
        }
    }
}
