using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DocumentManagerSample.Models
{
    public class Document
    {
        public string DocID { get; set; }

        public string DocTitle { get; set; }

        public string DocStatus { get; set; }

        public string Author { get; set; }

        public string LastUpdate { get; set; }
    }
}