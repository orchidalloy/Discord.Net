﻿using Newtonsoft.Json;

namespace Discord.API
{
    public class Overwrite
    {
        [JsonProperty("id")]
        public ulong TargetId { get; set; }
        [JsonProperty("type")]
        public PermissionTarget TargetType { get; set; }
        [JsonProperty("deny")]
        public ulong Deny { get; set; }
        [JsonProperty("allow")]
        public ulong Allow { get; set; }
    }
}
