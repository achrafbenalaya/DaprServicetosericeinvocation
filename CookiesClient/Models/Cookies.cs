using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookiesClient.Models
{
    public class Cookies
    {
        public Guid ID { get; set; }
        public string Date { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }

    }
}
