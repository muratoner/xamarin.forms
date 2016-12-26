using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MHG.Sample.Social.Model
{
    public class School
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class With
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class Year
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Concentration
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Education
    {

        [JsonProperty("school")]
        public School School { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("with")]
        public IList<With> With { get; set; }

        [JsonProperty("year")]
        public Year Year { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("concentration")]
        public IList<Concentration> Concentration { get; set; }
    }

    public class Cover
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("offset_y")]
        public int OffsetY { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    public class Datum
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Cursors
    {

        [JsonProperty("before")]
        public string Before { get; set; }

        [JsonProperty("after")]
        public string After { get; set; }
    }

    public class Paging
    {

        [JsonProperty("cursors")]
        public Cursors Cursors { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }
    }

    public class Photos
    {

        [JsonProperty("data")]
        public IList<Datum> Data { get; set; }

        [JsonProperty("paging")]
        public Paging Paging { get; set; }
    }

    public class Data
    {

        [JsonProperty("is_silhouette")]
        public bool IsSilhouette { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Picture
    {

        [JsonProperty("data")]
        public Data Data { get; set; }
    }

    public class Profile
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("birthday")]
        public string Birthday { get; set; }

        [JsonProperty("education")]
        public IList<Education> Education { get; set; }

        [JsonProperty("cover")]
        public Cover Cover { get; set; }

        [JsonProperty("photos")]
        public Photos Photos { get; set; }

        [JsonProperty("picture")]
        public Picture Picture { get; set; }
    }
}
