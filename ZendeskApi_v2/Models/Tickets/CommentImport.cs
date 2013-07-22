using System.Collections.Generic;
using Newtonsoft.Json;

namespace ZendeskApi_v2.Models.Tickets
{
    public class CommentImport
    {
        [JsonProperty("author_id")]
        public long? AuthorId { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("public")]
        public bool Public { get; set; }

        [JsonProperty("uploads")]
        public IList<string> Uploads { get; set; }
    }
}