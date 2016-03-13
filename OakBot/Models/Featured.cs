﻿using Newtonsoft.Json;

namespace OakBot.Models
{
    [JsonObject("featured")]
    public class Featured
    {
        #region Public Properties

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("scheduled")]
        public bool Scheduled { get; set; }

        [JsonProperty("sponsored")]
        public bool Sponsored { get; set; }

        [JsonProperty("stream")]
        public Stream Stream { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        #endregion Public Properties
    }
}