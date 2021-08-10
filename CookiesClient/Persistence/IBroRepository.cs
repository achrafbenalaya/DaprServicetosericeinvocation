using CookiesClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookiesClient.Persistence
{
   public interface IBroRepository 
    {
        Task<IEnumerable<Cookies>> Getcookies();

    }
}
