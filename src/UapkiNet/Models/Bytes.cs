﻿using Newtonsoft.Json;
using UapkiNet.Utils;

namespace UapkiNet.Models
{
    internal class Bytes
    {
        [JsonProperty("bytes")]
        internal string BytesBase64
        {
            get => _bytesBase64;
            set
            {
                _bytesBase64 = value;
                Data = ConvertExtension.FromBase64OrNull(_bytesBase64);
            }
        }

        public byte[] Data { get; set; }

        private string _bytesBase64;
    }
}
