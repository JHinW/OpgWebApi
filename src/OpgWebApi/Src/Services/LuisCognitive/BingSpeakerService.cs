using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpgWebApi.Src.Services.LuisCognitive
{
    public class BingSpeakerService
    {
        public BingSpeakerService(string key)
        {
            SpeakerKey = key;
        }

        public string SpeakerKey { get; set; }
    }
}
