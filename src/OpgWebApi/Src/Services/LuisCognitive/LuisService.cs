using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpgWebApi.Src.Services.LuisCognitive
{
    public class LuisService
    {
        public LuisService(string appId, string subKey)
        {
            AppId = appId;
            SubKey = subKey;
        }

        public string AppId { get; set; }

        public string SubKey { get; set; }
    }
}
