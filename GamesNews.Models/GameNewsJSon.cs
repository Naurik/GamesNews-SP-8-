using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesNews.Models
{
    public class GameNewsJSon
    {
        public class Rating
        {

            [JsonProperty("id")]
            public int id { get; set; }

            [JsonProperty("title")]
            public string title { get; set; }

            [JsonProperty("count")]
            public int count { get; set; }

            [JsonProperty("percent")]
            public double percent { get; set; }
        }

        public class AddedByStatus
        {

            [JsonProperty("yet")]
            public int yet { get; set; }

            [JsonProperty("owned")]
            public int owned { get; set; }

            [JsonProperty("beaten")]
            public int beaten { get; set; }

            [JsonProperty("toplay")]
            public int toplay { get; set; }

            [JsonProperty("dropped")]
            public int dropped { get; set; }

            [JsonProperty("playing")]
            public int playing { get; set; }
        }

        public class Platform
        {

            [JsonProperty("id")]
            public int id { get; set; }

            [JsonProperty("name")]
            public string name { get; set; }

            [JsonProperty("slug")]
            public string slug { get; set; }

            [JsonProperty("image")]
            public object image { get; set; }

            [JsonProperty("year_end")]
            public object year_end { get; set; }

            [JsonProperty("year_start")]
            public object year_start { get; set; }

            [JsonProperty("games_count")]
            public int games_count { get; set; }

            [JsonProperty("image_background")]
            public string image_background { get; set; }
        }

        public class Genre
        {

            [JsonProperty("id")]
            public int id { get; set; }

            [JsonProperty("name")]
            public string name { get; set; }

            [JsonProperty("slug")]
            public string slug { get; set; }

            [JsonProperty("games_count")]
            public int games_count { get; set; }

            [JsonProperty("image_background")]
            public string image_background { get; set; }
        }

        public class Store
        {

            [JsonProperty("id")]
            public int id { get; set; }

            [JsonProperty("name")]
            public string name { get; set; }

            [JsonProperty("slug")]
            public string slug { get; set; }

            [JsonProperty("domain")]
            public string domain { get; set; }

            [JsonProperty("games_count")]
            public int games_count { get; set; }

            [JsonProperty("image_background")]
            public string image_background { get; set; }
        }

        public class Result
        {
        
            [JsonProperty("id")]
            public int id { get; set; }
        
            [JsonProperty("slug")]
            public string slug { get; set; }
        
            [JsonProperty("name")]
            public string name { get; set; }
        
            [JsonProperty("promo")]
            public string promo { get; set; }
        
            [JsonProperty("released")]
            public string released { get; set; }
        
            [JsonProperty("tba")]
            public bool tba { get; set; }
        
            [JsonProperty("background_image")]
            public string background_image { get; set; }
        
            [JsonProperty("rating")]
            public double rating { get; set; }
        
            [JsonProperty("rating_top")]
            public int rating_top { get; set; }
        
            [JsonProperty("ratings")]
            public IList<Rating> ratings { get; set; }
        
            [JsonProperty("ratings_count")]
            public int ratings_count { get; set; }
        
            [JsonProperty("reviews_text_count")]
            public int reviews_text_count { get; set; }
        
            [JsonProperty("added")]
            public int added { get; set; }
        
            [JsonProperty("added_by_status")]
            public AddedByStatus added_by_status { get; set; }
        
            [JsonProperty("metacritic")]
            public int? metacritic { get; set; }
        
            [JsonProperty("playtime")]
            public int playtime { get; set; }
        
            [JsonProperty("comments_count")]
            public int comments_count { get; set; }
        
            [JsonProperty("comments_parent_count")]
            public int comments_parent_count { get; set; }
        
            [JsonProperty("suggestions_count")]
            public int suggestions_count { get; set; }
        
            [JsonProperty("user_game")]
            public object user_game { get; set; }
        
            [JsonProperty("reviews_count")]
            public int reviews_count { get; set; }
        
            [JsonProperty("saturated_color")]
            public string saturated_color { get; set; }
        
            [JsonProperty("dominant_color")]
            public string dominant_color { get; set; }
        
            [JsonProperty("platforms")]
            public IList<Platform> platforms { get; set; }
        
            [JsonProperty("genres")]
            public IList<Genre> genres { get; set; }
        
            [JsonProperty("stores")]
            public IList<Store> stores { get; set; }
        }

        public class GamesNews
        {
        
            [JsonProperty("count")]
            public int count { get; set; }
        
            [JsonProperty("next")]
            public string next { get; set; }
        
            [JsonProperty("previous")]
            public object previous { get; set; }
        
            [JsonProperty("results")]
            public IList<Result> results { get; set; }
        
            [JsonProperty("seo_h1")]
            public string seo_h1 { get; set; }
        
            [JsonProperty("seo_title")]
            public string seo_title { get; set; }
        
            [JsonProperty("seo_description")]
            public string seo_description { get; set; }
        
            [JsonProperty("description")]
            public string description { get; set; }
        
            [JsonProperty("noindex")]
            public bool noindex { get; set; }
        
            [JsonProperty("nofollow")]
            public bool nofollow { get; set; }
        
            [JsonProperty("nofollow_collections")]
            public IList<string> nofollow_collections { get; set; }
        }
    }
}
