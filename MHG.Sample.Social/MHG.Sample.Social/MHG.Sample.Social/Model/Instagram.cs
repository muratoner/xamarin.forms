using System.Collections.Generic;
using Newtonsoft.Json;

namespace MHG.Sample.Social.Model
{
    public class Location
    {

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class LowResolution
    {

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }
    }

    public class Thumbnail
    {

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }
    }

    public class StandardResolution
    {

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }
    }

    public class Images
    {

        [JsonProperty("low_resolution")]
        public LowResolution LowResolution { get; set; }

        [JsonProperty("thumbnail")]
        public Thumbnail Thumbnail { get; set; }

        [JsonProperty("standard_resolution")]
        public StandardResolution StandardResolution { get; set; }
    }

    public class From
    {

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("profile_picture")]
        public string ProfilePicture { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }
    }

    public class Comments
    {

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("data")]
        public IList<Datum> Data { get; set; }
    }

    public class Caption
    {

        [JsonProperty("created_time")]
        public string CreatedTime { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("from")]
        public From From {
            get;
            set;
        }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class Likes
    {

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("data")]
        public IList<Datum> Data { get; set; }
    }

    public class User
    {

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("profile_picture")]
        public string ProfilePicture { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }
    }

    public class LowBandwidth
    {

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }
    }

    public class Videos
    {

        [JsonProperty("low_resolution")]
        public LowResolution LowResolution { get; set; }

        [JsonProperty("standard_resolution")]
        public StandardResolution StandardResolution { get; set; }

        [JsonProperty("low_bandwidth")]
        public LowBandwidth LowBandwidth { get; set; }
    }

    public class Item
    {

        [JsonProperty("can_delete_comments")]
        public bool CanDeleteComments { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("images")]
        public Images Images { get; set; }

        [JsonProperty("can_view_comments")]
        public bool CanViewComments { get; set; }

        [JsonProperty("comments")]
        public Comments Comments { get; set; }

        [JsonProperty("alt_media_url")]
        public string AltMediaUrl { get; set; }

        [JsonProperty("caption")]
        public Caption Caption { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("likes")]
        public Likes Likes { get; set; }

        [JsonProperty("created_time")]
        public string CreatedTime { get; set; }

        [JsonProperty("user_has_liked")]
        public bool UserHasLiked { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("video_views")]
        public int? VideoViews { get; set; }

        [JsonProperty("videos")]
        public Videos Videos { get; set; }
    }

    public class Instagram
    {

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("items")]
        public IList<Item> Items { get; set; }

        [JsonProperty("more_available")]
        public bool MoreAvailable { get; set; }
    }
}
