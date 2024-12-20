﻿using Newtonsoft.Json;

namespace PlayerDotNet.models
{
    public class GameConfig
    {
        [JsonProperty("base_levels")]
        public required List<BaseLevel> BaseLevels { get; set; }

        [JsonProperty("paths")]
        public required PathConfig Paths { get; set; }
    }
}
