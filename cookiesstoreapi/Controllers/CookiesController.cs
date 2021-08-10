using cookiesstoreapi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cookiesstoreapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CookiesController : ControllerBase
    {
 
        private List<Cookies> thecookieslist = new List<Cookies>
        {
            new Cookies{ID = Guid.NewGuid(),Date =DateTime.Now.ToShortDateString(),Name="Snickerdoodles",ImageUrl="https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fstatic.onecms.io%2Fwp-content%2Fuploads%2Fsites%2F43%2F2020%2F05%2F13%2F4561384.jpg&w=200&c=sc&poi=face&q=85" },
            new Cookies{ID = Guid.NewGuid(),Date =DateTime.Now.ToShortDateString(),Name="Chocolate Chip Cookies",ImageUrl="https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fstatic.onecms.io%2Fwp-content%2Fuploads%2Fsites%2F43%2F2019%2F12%2Fbest-chocolate-chip-cookies.jpg&w=200&c=sc&poi=face&q=85" },
            new Cookies{ID = Guid.NewGuid(),Date =DateTime.Now.ToShortDateString(),Name="Oatmeal Raisin Cookies",ImageUrl="https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fstatic.onecms.io%2Fwp-content%2Fuploads%2Fsites%2F43%2F2020%2F07%2F15%2FBeths-Spicy-Oatmeal-Raisin-Cookies.jpg&w=200&c=sc&poi=face&q=85" },
            new Cookies{ID = Guid.NewGuid(),Date =DateTime.Now.ToShortDateString(),Name="Gingersnaps",ImageUrl="https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fstatic.onecms.io%2Fwp-content%2Fuploads%2Fsites%2F43%2F2020%2F07%2F15%2Fimage-1-2000.jpg&w=200&c=sc&poi=face&q=85" },
            new Cookies{ID = Guid.NewGuid(),Date =DateTime.Now.ToShortDateString(),Name="Shortbread Cookies",ImageUrl="https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fstatic.onecms.io%2Fwp-content%2Fuploads%2Fsites%2F43%2F2020%2F07%2F15%2F1164242.jpg&w=200&c=sc&poi=face&q=85" },
            new Cookies{ID = Guid.NewGuid(),Date =DateTime.Now.ToShortDateString(),Name="Peanut Butter Cookies",ImageUrl="https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fstatic.onecms.io%2Fwp-content%2Fuploads%2Fsites%2F43%2F2020%2F07%2F10%2F5473886-2000.jpg&w=200&c=sc&poi=face&q=85" }

    };

        private readonly ILogger<CookiesController> _logger;

        public CookiesController(ILogger<CookiesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Cookies> GetCookies()
        {

            return thecookieslist;
        }


    }
}
