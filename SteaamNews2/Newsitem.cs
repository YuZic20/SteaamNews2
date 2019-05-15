using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteaamNews2
{
    public class newsitem
    {
        public string gid { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public bool is_external_url { get; set; }
        public string author { get; set; }
        public string contents { get; set; }
        public string feedlabel { get; set; }
        public long date { get; set; }
        public string feedname { get; set; }
        public long feed_type { get; set; }
        public long appid { get; set; }
    }
}
