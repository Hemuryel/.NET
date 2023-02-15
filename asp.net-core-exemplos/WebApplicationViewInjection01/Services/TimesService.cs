using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationViewInjection01.Services
{
    public class TimesService
    {
        public List<string> GetTimes()
        {
            return new List<string>() { "Corinthians", "Grêmio", "Santos", "Flamengo" };
        }
    }
}
