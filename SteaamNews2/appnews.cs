using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteaamNews2
{
    public class appnews
    {
        public long appid { get; set; }
        public List<newsitem> newsitems { get; set; }
        public long count { get; set; }
    }
}
