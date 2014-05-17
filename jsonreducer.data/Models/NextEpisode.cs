using System;

namespace jsonreducer.data.Models
{
    public class NextEpisode
    {
        public string Channel { get; set; }
        public string ChannelLogo { get; set; }
        public DateTime? Date { get; set; }
        public string Html { get; set; }
        public Uri Url { get; set; }
    }
}