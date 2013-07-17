using System.Collections.Generic;
using Newtonsoft.Json;

namespace ZendeskApi_v2.Models.Tickets
{
    public class TicketImport : Ticket
    {
        [JsonProperty("solved_at")]
        public string SolvedAt { get; set; }

        [JsonProperty("comments")]
        public IList<CommentImport> Comments { get; set; }
    }
}
