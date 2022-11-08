﻿using Newtonsoft.Json;

namespace TestConfigurator.Models.API.Board.Submodels
{
    public class Attachments
    {
        [JsonProperty("perBoard")]
        public PerBoard PerBoard { get; set; }

        [JsonProperty("perCard")]
        public PerCard PerCard { get; set; }
    }
}
