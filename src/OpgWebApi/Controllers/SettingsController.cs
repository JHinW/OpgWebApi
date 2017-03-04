using Microsoft.AspNetCore.Mvc;
using OpgWebApi.Src.Services.LuisCognitive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpgWebApi.Controllers
{
    [Route("api/[controller]")]
    public class SettingsController
    {
        private BingSpeakerService _bingSpeakerService;

        private LuisService _luisService;

        public SettingsController(BingSpeakerService bingSpeakerService,
            LuisService luisService)
        {
            _bingSpeakerService = bingSpeakerService;
            _luisService = luisService;
        }

        [HttpGet("LuisSettings")]
        public JsonResult GetLuisSettings()
        {
            return new JsonResult(new
            {
                AppId = _luisService.AppId,
                SubKey = _luisService.SubKey
            });
        }

        [HttpGet("BingSpeakerSettings")]
        public JsonResult GetBingSpeakerSettings()
        {
            return new JsonResult(new
            {
                SpeakerKey = _bingSpeakerService.SpeakerKey
            });
        }
    }
}
