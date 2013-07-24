namespace ZendeskApi_v2
{
    public class LogItem
    {
        public string Url { get; set; }
        public string HttpMethod { get; set; }
        public object RequestBody { get; set; }
        public string RequestBodyJson { get; set; }
        public RequestResult Response { get; set; }
    }
}
